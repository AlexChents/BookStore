using BookStore.Helpers;
using BookStore.Models;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class OrdersForm : Form
    {
        int accessLevel;
        public OrdersForm(int level)
        {
            InitializeComponent();
            this.accessLevel = level;
        }

        private void InitAccess(int level)
        {
            switch (level)
            {
                case 2:
                    PayOrderStripButton.Enabled = false;
                    CancelPaymentToolStripButton.Enabled = false;
                    break;
                case 3:
                    ShipmentOrderStripButton.Enabled = false;
                    CancelShippedToolStripButton.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            dgvOrderDetails.Columns.Add("Номер по порядку", "Номер по порядку");
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    DgvOrdersRefresh(context, -1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitAccess(this.accessLevel);
        }

        private void DgvOrders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Context.ToString());
        }

        //обновление данных в dgv
        #region
        private void DgvOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, e.RowIndex].Value);
                DgvOrdersDetailsRefresh(numberIdOrderSelect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
        private void DgvOrdersRefresh(BookStoreContext context, int numberRow)
        {
            dgvOrders.DataSource = context.Orders
                                    .Select(o => new
                                    {
                                        NumberOrder = o.Id,
                                        o.DateOrder,
                                        ClientName = context.Clients.Where(c => c.Id == o.ClientId).Select(c => c.ClientName).FirstOrDefault(),
                                        o.CountBooks,
                                        SumOrder = Math.Round(o.SumOrder, 2),
                                        o.Payment,
                                        o.Shipped,
                                        Manager = context.Users.Where(u => u.Id == o.UserId).Select(u => u.FirstName + " " + u.LastName).FirstOrDefault()
                                    }).ToList();
            if (numberRow >= 0)
                dgvOrders.CurrentCell = dgvOrders.Rows[numberRow].Cells[0];
        }

        private void DgvOrdersDetailsRefresh(int numberIdOrderSelect)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                dgvOrderDetails.DataSource = context.OrderDetails
                    .Where(od => od.OrderId == numberIdOrderSelect)
                    .Select(od => new
                    {
                        Book = context.Books.Where(b => b.Id == od.BookId).Select(b => b.Title).FirstOrDefault(),
                        od.CountBook,
                        Price = Math.Round(od.Price, 2),
                        SumOnPosition = Math.Round(od.Price * od.CountBook, 2)
                    }).ToList();
                for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    dgvOrderDetails.Rows[i].Cells["Номер по порядку"].Value = i + 1;
                }
            }
        }

        private void RefreshOrderToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    DgvOrdersRefresh(context, dgvOrders.CurrentCell.RowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        //корректировка списка заказов
        #region
        private void AddOrderToolStripBtn_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        context.Orders.Add(new Order
                        {
                            Client = context.Clients.Where(c => c.ClientName == addOrderForm.cbClients.Text).FirstOrDefault(),
                            CountBooks = 0,
                            DateOrder = DateTime.Now,
                            Payment = false,
                            Shipped = false,
                            SumOrder = 0,
                            User = context.Users.Where(u => u.Login == StartForm.userOnLine).FirstOrDefault()
                        });
                        context.SaveChanges();
                        if (dgvOrderDetails.RowCount != 0)
                        {
                            DgvOrdersRefresh(context, dgvOrders.CurrentCell.RowIndex);
                            dgvOrders.CurrentCell = dgvOrders.Rows[dgvOrders.Rows.Count - 1].Cells[0];
                        }
                        else
                        {
                            DgvOrdersRefresh(context, -1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void EditOrderToolStripButton_Click(object sender, EventArgs e)
        {
            if (dgvOrders.RowCount != 0)
            {
                int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value);
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        if (!context.Orders.Find(numberIdOrderSelect).Shipped)
                        {
                            if (!context.Orders.Find(numberIdOrderSelect).Payment)
                            {
                                AddOrderForm editOrder = new AddOrderForm();
                                if (editOrder.ShowDialog() == DialogResult.OK)
                                {
                                    int clientId = context.Clients.Where(c => c.ClientName == editOrder.cbClients.Text).
                                        Select(c => c.Id).FirstOrDefault();
                                    context.Orders.Where(o => o.Id == numberIdOrderSelect).FirstOrDefault()
                                        .ClientId = clientId;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Для редактирования отмените оплату");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Для редактирования отмените отгрузку");
                        }
                        context.SaveChanges();
                        DgvOrdersRefresh(context, dgvOrders.CurrentCell.RowIndex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteOrderToolStripButton_Click(object sender, EventArgs e)
        {
            if (dgvOrders.RowCount != 0)
            {
                int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value);
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        if (!context.Orders.Find(numberIdOrderSelect).Shipped)
                        {
                            if (!context.Orders.Find(numberIdOrderSelect).Payment)
                            {
                                if (MessageBox.Show($"Удалить заказ №{numberIdOrderSelect}?", "Удаление заказа", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    var orderDetailsId = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect)
                                        .Select(od => od.Id).ToList();
                                    foreach (var item in orderDetailsId)
                                    {
                                        context.OrderDetails.Remove(context.OrderDetails.Find(item));
                                    }
                                    context.Orders.Remove(context.Orders.Find(numberIdOrderSelect));
                                }
                            }
                            else
                            {
                                MessageBox.Show("Для редактирования отмените оплату");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Для редактирования отмените отгрузку");
                        }
                        context.SaveChanges();
                        DgvOrdersRefresh(context, dgvOrders.CurrentCell.RowIndex - 1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        //проверка на отплату и отгрузку
        #region
        private void PayOrderStripButton_Click(object sender, EventArgs e)
        {
            int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value);
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    if (context.Orders.Find(numberIdOrderSelect).SumOrder != 0)
                    {
                        if (!context.Orders.Find(numberIdOrderSelect).Payment)
                        {
                            PaymentOkCancel(numberIdOrderSelect, context, "Провести оплату?", "Оплата заказа", true);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заказ не оформлен!!! Заполните позиции заказа");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelPaymentToolStripButton_Click(object sender, EventArgs e)
        {
            int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value);
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    if (context.Orders.Find(numberIdOrderSelect).SumOrder != 0)
                    {
                        if (context.Orders.Find(numberIdOrderSelect).Payment)
                        {
                            if (!context.Orders.Find(numberIdOrderSelect).Shipped)
                                PaymentOkCancel(numberIdOrderSelect, context, "Отменить оплату?", "Отмена оплаты заказа", false);
                            else
                                MessageBox.Show("Отмена оплаты возможно только отмены отгрузки");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ShipmentOrderStripButton_Click(object sender, EventArgs e)
        {
            int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value);
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    if (!context.Orders.Find(numberIdOrderSelect).Shipped)
                    {
                        if (context.Orders.Find(numberIdOrderSelect).Payment)
                            ShippedOkCancel(numberIdOrderSelect, context, "Провести отгрузку?", "Отгрузка заказа", true, -1);
                        else
                            MessageBox.Show("Отгрузка возможна только после оплаты заказа");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void CancelShippedToolStripButton_Click(object sender, EventArgs e)
        {
            int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value);
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    if (context.Orders.Find(numberIdOrderSelect).Shipped)
                        ShippedOkCancel(numberIdOrderSelect, context, "Отменить отгрузку?", "Отмена отгрузки заказа", false, 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void DgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && accessLevel == 3)
            {
                if ((bool)dgvOrders[e.ColumnIndex, e.RowIndex].Value)
                    CancelPaymentToolStripButton_Click(null, null);
                else
                    PayOrderStripButton_Click(null, null);
            }

            else if (e.ColumnIndex == 6 && accessLevel != 3)
            {
                if ((bool)dgvOrders[e.ColumnIndex, e.RowIndex].Value)
                    CancelShippedToolStripButton_Click(null, null);
                else
                    ShipmentOrderStripButton_Click(null, null);
            }
        }

        private void ShippedOkCancel(int numberIdOrderSelect, BookStoreContext context, string textMessage, string captionMessage, bool shipped, int coefficient)
        {
            if (MessageBox.Show(textMessage, captionMessage, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                context.Orders.Find(numberIdOrderSelect).Shipped = shipped;
                var booksWithCount = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect)
                        .Select(od => new
                        {
                            od.BookId,
                            od.CountBook
                        }).ToList();
                foreach (var item in booksWithCount)
                {
                    context.Books.Find(item.BookId).QuantityAll += item.CountBook * coefficient;
                    context.Books.Find(item.BookId).QuantityInOrders += item.CountBook * coefficient;
                }
                context.SaveChanges();
                DgvOrdersRefresh(context, dgvOrders.CurrentCell.RowIndex);
            }
        }

        private void PaymentOkCancel(int numberIdOrderSelect, BookStoreContext context, string textMessage, string captionMessage, bool payment)
        {
            if (MessageBox.Show(textMessage, captionMessage, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                context.Orders.Find(numberIdOrderSelect).Payment = payment;
                context.SaveChanges();
                DgvOrdersRefresh(context, dgvOrders.CurrentCell.RowIndex);
            }
        }
        #endregion

        //Выгрузка заказа в Excel
        #region
        /*private void PrintOrderToolStripButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelOrder = new Microsoft.Office.Interop.Excel.Application();
            excelOrder.Workbooks.Add();
            Worksheet worksheet = (Worksheet)excelOrder.ActiveSheet;
            (worksheet.Cells as Range).Font.Name = "Arial";
            (worksheet.Cells as Range).Font.Size = 12;

            worksheet.Cells[1, 3] = $"Счет № {dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value} от " +
                $"{dgvOrders[1, dgvOrders.CurrentCell.RowIndex].Value.ToString().Remove(10)}";
            worksheet.Cells[1, 3].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            worksheet.Cells[5, 1] = "Расчетный счет №12155335251";
            worksheet.Cells[6, 1] = "Код ЕДРПОУ №44444554241";
            worksheet.Cells[7, 1] = "ООО \"Книжный магазин\"";
            int indexRowForExcel = 10;
            worksheet.Cells[indexRowForExcel, 1] = "№ п/п";
            worksheet.Cells[indexRowForExcel, 2] = "Название";
            worksheet.Cells[indexRowForExcel, 3] = "Количество";
            worksheet.Cells[indexRowForExcel, 4] = "Цена";
            worksheet.Cells[indexRowForExcel, 5] = "Сумма по поз.";

            worksheet.get_Range($"A{indexRowForExcel}", $"E{indexRowForExcel}").Cells.BorderAround(
                        XlLineStyle.xlDouble,
                        XlBorderWeight.xlMedium,
                        XlColorIndex.xlColorIndexAutomatic,
                        ColorTranslator.ToOle(Color.Blue));
            indexRowForExcel++;

            for (int i = 0; i < dgvOrderDetails.ColumnCount; i++)
            {
                worksheet.Columns[i + 1].ColumnWidth = 15;
            }
            double sumTotal = 0;
            for (int i = 0; i < dgvOrderDetails.RowCount; i++)
            {
                for (int j = 0; j < dgvOrderDetails.ColumnCount; j++)
                {
                    worksheet.Cells[indexRowForExcel, j + 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[indexRowForExcel, j + 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[indexRowForExcel, j + 1] = dgvOrderDetails[j, i].Value;
                    if (j + 1 == dgvOrderDetails.ColumnCount)
                        sumTotal += (double)dgvOrderDetails[j, i].Value;
                }
                indexRowForExcel++;
            }
            worksheet.Cells[indexRowForExcel, 1] = "ИТОГО:";
            worksheet.Cells[indexRowForExcel, 1].Font.Bold = true;
            worksheet.get_Range($"A{indexRowForExcel}", $"E{indexRowForExcel}").Cells.BorderAround(
                        XlLineStyle.xlDouble,
                        XlBorderWeight.xlMedium,
                        XlColorIndex.xlColorIndexAutomatic,
                        ColorTranslator.ToOle(Color.Blue));
            worksheet.Cells[indexRowForExcel, 5] = sumTotal;
            worksheet.Cells[indexRowForExcel + 3, 1] = $"Составил ______________ {dgvOrders[7, dgvOrders.CurrentCell.RowIndex].Value}";
            worksheet.Cells[indexRowForExcel + 3, 1].Font.Size = 8;

            string pathExcelOrder = $"{Environment.CurrentDirectory}\\" +
                $"{dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value}_" +
                $"{dgvOrders[1, dgvOrders.CurrentCell.RowIndex].Value.ToString().Remove(10).Replace(".", "")}";

            SaveFileOrder(worksheet, pathExcelOrder);
            excelOrder.Visible = true;
        }
        */
        private static void SaveFileOrder(Worksheet worksheet, string pathExcelOrder, int indexCopyFile = 1)
        {
            if (!File.Exists(pathExcelOrder + ".xlsx"))
            {
                worksheet.SaveAs(pathExcelOrder);
            }
            else
            {
                if (indexCopyFile != 1)
                    pathExcelOrder = pathExcelOrder.Remove(pathExcelOrder.Length - (int)Math.Ceiling(Math.Log10(indexCopyFile)) - 2);
                pathExcelOrder += $"({indexCopyFile})";
                indexCopyFile++;
                SaveFileOrder(worksheet, pathExcelOrder, indexCopyFile);
            }
        }
        #endregion

        //корректировка заказа
        #region
        private void AddNewPositionOrderDetailsToolStripButton_Click(object sender, EventArgs e)
        {
            int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value);
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    if (!context.Orders.Find(numberIdOrderSelect).Shipped)
                    {
                        if (!context.Orders.Find(numberIdOrderSelect).Payment)
                        {
                            AddPositionOrderDetailsForm addPosition = new AddPositionOrderDetailsForm();
                            if (addPosition.ShowDialog() == DialogResult.OK)
                            {

                                context.OrderDetails.Add(new OrderDetail
                                {
                                    OrderId = numberIdOrderSelect,
                                    BookId = context.Books.Where(b => b.Title == addPosition.cbNameBook.Text)
                                       .Select(b => b.Id).FirstOrDefault(),
                                    CountBook = Convert.ToInt32(addPosition.txtBoxCountBook.Text),
                                    Price = context.Books.Where(b => b.Title == addPosition.cbNameBook.Text)
                                       .Select(b => b.Price).FirstOrDefault()
                                });
                                context.SaveChanges();

                                var changedDataOrder = context.Orders.Find(numberIdOrderSelect);
                                changedDataOrder.SumOrder = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect)
                                    .Select(od => od.CountBook * od.Price).Sum();
                                changedDataOrder.CountBooks = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect)
                                    .Select(od => od.CountBook).Sum();

                                var orderDetailsId = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect)
                                    .Select(od => od).ToList()[dgvOrderDetails.RowCount];
                                context.Books.Find(orderDetailsId.BookId).QuantityInOrders += orderDetailsId.CountBook;
                                context.SaveChanges();

                                DgvOrdersRefresh(context, dgvOrders.CurrentCell.RowIndex);
                                dgvOrderDetails.CurrentCell = dgvOrderDetails.Rows[dgvOrderDetails.Rows.Count - 1].Cells[0];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Для добавления позиции отмените оплату!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Для добавления позиций отмените отгрузку!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditPositionOrderDetailsToolStripButton_Click(object sender, EventArgs e)
        {
            int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value);
            if (dgvOrderDetails.RowCount > 0)
            {
                int indexRowInOrderDetails = dgvOrderDetails.CurrentCell.RowIndex;
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        if (!context.Orders.Find(numberIdOrderSelect).Shipped)
                        {
                            if (!context.Orders.Find(numberIdOrderSelect).Payment)
                            {
                                AddPositionOrderDetailsForm editPosition = new AddPositionOrderDetailsForm();
                                if (editPosition.ShowDialog() == DialogResult.OK)
                                {

                                    var orderDetailsId = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect)
                                        .Select(od => od).ToList()[indexRowInOrderDetails];
                                    context.Books.Find(orderDetailsId.BookId).QuantityInOrders -= orderDetailsId.CountBook;

                                    var newBookInOrder = context.Books.Where(b => b.Title == editPosition.cbNameBook.Text)
                                        .FirstOrDefault();
                                    context.Books.Find(newBookInOrder.Id).QuantityInOrders +=
                                        Convert.ToInt32(editPosition.txtBoxCountBook.Text);

                                    context.OrderDetails.Find(orderDetailsId.Id).CountBook = Convert.ToInt32(editPosition.txtBoxCountBook.Text);
                                    context.OrderDetails.Find(orderDetailsId.Id).BookId = newBookInOrder.Id;
                                    context.OrderDetails.Find(orderDetailsId.Id).Price = newBookInOrder.Price;
                                    context.SaveChanges();

                                    var changedDataOrder = context.Orders.Find(numberIdOrderSelect);
                                    changedDataOrder.SumOrder = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect).
                                        Select(od => od.CountBook * od.Price).Sum();
                                    changedDataOrder.CountBooks = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect).
                                        Select(od => od.CountBook).Sum();
                                    context.SaveChanges();
                                    DgvOrdersRefresh(context, dgvOrders.CurrentCell.RowIndex);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Для редактирования позиции отмените оплату!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Для редактирования позиций отмените отгрузку!");
                        }
                    }   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeletePositionOrderDetailsToolStripButton_Click(object sender, EventArgs e)
        {
            int numberIdOrderSelect = Convert.ToInt32(dgvOrders[0, dgvOrders.CurrentCell.RowIndex].Value);
            if (dgvOrderDetails.RowCount > 0)
            {
                int indexRowInOrderDetails = dgvOrderDetails.CurrentCell.RowIndex;
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        if (!context.Orders.Find(numberIdOrderSelect).Shipped)
                        {
                            if (!context.Orders.Find(numberIdOrderSelect).Payment)
                            {
                                var orderDetailsId = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect)
                                    .ToList()[indexRowInOrderDetails];
                                context.Books.Find(orderDetailsId.BookId).QuantityInOrders -= orderDetailsId.CountBook;
                                context.OrderDetails.Remove(context.OrderDetails.Find(orderDetailsId.Id));
                                context.SaveChanges();

                                var changedDataOrder = context.Orders.Find(numberIdOrderSelect);
                                if (context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect).ToList().Count != 0)
                                {
                                    changedDataOrder.SumOrder = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect).
                                        Sum(od => od.CountBook * od.Price);
                                    changedDataOrder.CountBooks = context.OrderDetails.Where(od => od.OrderId == numberIdOrderSelect).
                                        Sum(od => od.CountBook);
                                }
                                else
                                {
                                    changedDataOrder.SumOrder = 0;
                                    changedDataOrder.CountBooks = 0;
                                }
                                context.SaveChanges();
                                DgvOrdersRefresh(context, dgvOrders.CurrentCell.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show("Для удаления позиции отмените оплату!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Для удаления позиций отмените отгрузку!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DgvOrderDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Context.ToString());
        }
        #endregion

        //выгрузка списка заказов в Excel
        private void exportExcelToolStripButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelListOrders = new Microsoft.Office.Interop.Excel.Application();
            excelListOrders.Workbooks.Add();
            Worksheet worksheet = (Worksheet)excelListOrders.ActiveSheet;
            (worksheet.Cells as Range).Font.Name = "Arial";
            (worksheet.Cells as Range).Font.Size = 9;

            for (int i = 0; i < dgvOrders.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = dgvOrders.Columns[i].HeaderText;
                for (int j = 0; j < dgvOrders.RowCount; j++)
                {
                    worksheet.Cells[j + 2, i + 1] = dgvOrders[i, j].Value;
                }
            }
            //excelListOrders.Cells[1, 1].AutoFilter();
            excelListOrders.Columns.AutoFit();

            excelListOrders.Visible = true;
        }
    }
}
