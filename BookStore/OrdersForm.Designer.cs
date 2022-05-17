namespace BookStore
{
    partial class OrdersForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.scOrders = new System.Windows.Forms.SplitContainer();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.toolStripOrders = new System.Windows.Forms.ToolStrip();
            this.AddOrderToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.EditOrderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteOrderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshOrderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintOrderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exportExcelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PayOrderStripButton = new System.Windows.Forms.ToolStripButton();
            this.CancelPaymentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ShipmentOrderStripButton = new System.Windows.Forms.ToolStripButton();
            this.CancelShippedToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.toolStripOrderDetails = new System.Windows.Forms.ToolStrip();
            this.AddNewPositionOrderDetailsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditPositionOrderDetailsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeletePositionOrderDetailsToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.scOrders)).BeginInit();
            this.scOrders.Panel1.SuspendLayout();
            this.scOrders.Panel2.SuspendLayout();
            this.scOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.toolStripOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.toolStripOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // scOrders
            // 
            this.scOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOrders.Location = new System.Drawing.Point(0, 0);
            this.scOrders.Name = "scOrders";
            this.scOrders.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scOrders.Panel1
            // 
            this.scOrders.Panel1.Controls.Add(this.dgvOrders);
            this.scOrders.Panel1.Controls.Add(this.toolStripOrders);
            // 
            // scOrders.Panel2
            // 
            this.scOrders.Panel2.Controls.Add(this.dgvOrderDetails);
            this.scOrders.Panel2.Controls.Add(this.toolStripOrderDetails);
            this.scOrders.Size = new System.Drawing.Size(1184, 662);
            this.scOrders.SplitterDistance = 283;
            this.scOrders.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 39);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1184, 244);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrders_CellDoubleClick);
            this.dgvOrders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvOrders_DataError);
            this.dgvOrders.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrders_RowEnter);
            // 
            // toolStripOrders
            // 
            this.toolStripOrders.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOrderToolStripBtn,
            this.EditOrderToolStripButton,
            this.DeleteOrderToolStripButton,
            this.toolStripSeparator1,
            this.RefreshOrderToolStripButton,
            this.toolStripSeparator2,
            this.PrintOrderToolStripButton,
            this.exportExcelToolStripButton,
            this.toolStripSeparator3,
            this.PayOrderStripButton,
            this.CancelPaymentToolStripButton,
            this.toolStripSeparator4,
            this.ShipmentOrderStripButton,
            this.CancelShippedToolStripButton});
            this.toolStripOrders.Location = new System.Drawing.Point(0, 0);
            this.toolStripOrders.Name = "toolStripOrders";
            this.toolStripOrders.Size = new System.Drawing.Size(1184, 39);
            this.toolStripOrders.TabIndex = 1;
            this.toolStripOrders.Text = "toolStrip1";
            // 
            // AddOrderToolStripBtn
            // 
            this.AddOrderToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddOrderToolStripBtn.Image = global::BookStore.Properties.Resources.documentnew;
            this.AddOrderToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddOrderToolStripBtn.Name = "AddOrderToolStripBtn";
            this.AddOrderToolStripBtn.Size = new System.Drawing.Size(36, 36);
            this.AddOrderToolStripBtn.Text = "Добавить заказ";
            this.AddOrderToolStripBtn.Click += new System.EventHandler(this.AddOrderToolStripBtn_Click);
            // 
            // EditOrderToolStripButton
            // 
            this.EditOrderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditOrderToolStripButton.Image = global::BookStore.Properties.Resources.documentedit;
            this.EditOrderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditOrderToolStripButton.Name = "EditOrderToolStripButton";
            this.EditOrderToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.EditOrderToolStripButton.Text = "Редактировать заказ";
            this.EditOrderToolStripButton.Click += new System.EventHandler(this.EditOrderToolStripButton_Click);
            // 
            // DeleteOrderToolStripButton
            // 
            this.DeleteOrderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteOrderToolStripButton.Image = global::BookStore.Properties.Resources.documentdelete;
            this.DeleteOrderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteOrderToolStripButton.Name = "DeleteOrderToolStripButton";
            this.DeleteOrderToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.DeleteOrderToolStripButton.Text = "Удалить заказ";
            this.DeleteOrderToolStripButton.Click += new System.EventHandler(this.DeleteOrderToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // RefreshOrderToolStripButton
            // 
            this.RefreshOrderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshOrderToolStripButton.Image = global::BookStore.Properties.Resources.refresh;
            this.RefreshOrderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshOrderToolStripButton.Name = "RefreshOrderToolStripButton";
            this.RefreshOrderToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.RefreshOrderToolStripButton.Text = "Обновить";
            this.RefreshOrderToolStripButton.Click += new System.EventHandler(this.RefreshOrderToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // PrintOrderToolStripButton
            // 
            this.PrintOrderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintOrderToolStripButton.Image = global::BookStore.Properties.Resources.gnomecupsmanager;
            this.PrintOrderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintOrderToolStripButton.Name = "PrintOrderToolStripButton";
            this.PrintOrderToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.PrintOrderToolStripButton.Text = "Распечатать заказ";
            //this.PrintOrderToolStripButton.Click += new System.EventHandler(this.PrintOrderToolStripButton_Click);
            // 
            // exportExcelToolStripButton
            // 
            this.exportExcelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportExcelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exportExcelToolStripButton.Image")));
            this.exportExcelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportExcelToolStripButton.Name = "exportExcelToolStripButton";
            this.exportExcelToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.exportExcelToolStripButton.Text = "Выгрузить список заказов в Excel";
            this.exportExcelToolStripButton.Click += new System.EventHandler(this.exportExcelToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // PayOrderStripButton
            // 
            this.PayOrderStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PayOrderStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PayOrderStripButton.Image")));
            this.PayOrderStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PayOrderStripButton.Name = "PayOrderStripButton";
            this.PayOrderStripButton.Size = new System.Drawing.Size(36, 36);
            this.PayOrderStripButton.Text = "Провести оплату";
            this.PayOrderStripButton.Click += new System.EventHandler(this.PayOrderStripButton_Click);
            // 
            // CancelPaymentToolStripButton
            // 
            this.CancelPaymentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelPaymentToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelPaymentToolStripButton.Image")));
            this.CancelPaymentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelPaymentToolStripButton.Name = "CancelPaymentToolStripButton";
            this.CancelPaymentToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.CancelPaymentToolStripButton.Text = "Отмена оплаты";
            this.CancelPaymentToolStripButton.Click += new System.EventHandler(this.CancelPaymentToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // ShipmentOrderStripButton
            // 
            this.ShipmentOrderStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShipmentOrderStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ShipmentOrderStripButton.Image")));
            this.ShipmentOrderStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShipmentOrderStripButton.Name = "ShipmentOrderStripButton";
            this.ShipmentOrderStripButton.Size = new System.Drawing.Size(36, 36);
            this.ShipmentOrderStripButton.Text = "Отгрузить заказ";
            this.ShipmentOrderStripButton.Click += new System.EventHandler(this.ShipmentOrderStripButton_Click);
            // 
            // CancelShippedToolStripButton
            // 
            this.CancelShippedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelShippedToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelShippedToolStripButton.Image")));
            this.CancelShippedToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelShippedToolStripButton.Name = "CancelShippedToolStripButton";
            this.CancelShippedToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.CancelShippedToolStripButton.Text = "Отмена отгрузки";
            this.CancelShippedToolStripButton.Click += new System.EventHandler(this.CancelShippedToolStripButton_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 39);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(1184, 336);
            this.dgvOrderDetails.TabIndex = 1;
            this.dgvOrderDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvOrderDetails_DataError);
            // 
            // toolStripOrderDetails
            // 
            this.toolStripOrderDetails.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripOrderDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewPositionOrderDetailsToolStripButton,
            this.EditPositionOrderDetailsToolStripButton,
            this.DeletePositionOrderDetailsToolStripButton});
            this.toolStripOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.toolStripOrderDetails.Name = "toolStripOrderDetails";
            this.toolStripOrderDetails.Size = new System.Drawing.Size(1184, 39);
            this.toolStripOrderDetails.TabIndex = 0;
            this.toolStripOrderDetails.Text = "toolStrip1";
            // 
            // AddNewPositionOrderDetailsToolStripButton
            // 
            this.AddNewPositionOrderDetailsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNewPositionOrderDetailsToolStripButton.Image = global::BookStore.Properties.Resources.documentnew;
            this.AddNewPositionOrderDetailsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNewPositionOrderDetailsToolStripButton.Name = "AddNewPositionOrderDetailsToolStripButton";
            this.AddNewPositionOrderDetailsToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.AddNewPositionOrderDetailsToolStripButton.ToolTipText = "Добавить позицию";
            this.AddNewPositionOrderDetailsToolStripButton.Click += new System.EventHandler(this.AddNewPositionOrderDetailsToolStripButton_Click);
            // 
            // EditPositionOrderDetailsToolStripButton
            // 
            this.EditPositionOrderDetailsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditPositionOrderDetailsToolStripButton.Image = global::BookStore.Properties.Resources.documentedit;
            this.EditPositionOrderDetailsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditPositionOrderDetailsToolStripButton.Name = "EditPositionOrderDetailsToolStripButton";
            this.EditPositionOrderDetailsToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.EditPositionOrderDetailsToolStripButton.ToolTipText = "Редактировать позицию";
            this.EditPositionOrderDetailsToolStripButton.Click += new System.EventHandler(this.EditPositionOrderDetailsToolStripButton_Click);
            // 
            // DeletePositionOrderDetailsToolStripButton
            // 
            this.DeletePositionOrderDetailsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeletePositionOrderDetailsToolStripButton.Image = global::BookStore.Properties.Resources.documentdelete;
            this.DeletePositionOrderDetailsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeletePositionOrderDetailsToolStripButton.Name = "DeletePositionOrderDetailsToolStripButton";
            this.DeletePositionOrderDetailsToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.DeletePositionOrderDetailsToolStripButton.ToolTipText = "Удалить позицию";
            this.DeletePositionOrderDetailsToolStripButton.Click += new System.EventHandler(this.DeletePositionOrderDetailsToolStripButton_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.scOrders);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Заказы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.scOrders.Panel1.ResumeLayout(false);
            this.scOrders.Panel1.PerformLayout();
            this.scOrders.Panel2.ResumeLayout(false);
            this.scOrders.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scOrders)).EndInit();
            this.scOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.toolStripOrders.ResumeLayout(false);
            this.toolStripOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.toolStripOrderDetails.ResumeLayout(false);
            this.toolStripOrderDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scOrders;
        private System.Windows.Forms.ToolStrip toolStripOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ToolStripButton AddOrderToolStripBtn;
        private System.Windows.Forms.ToolStrip toolStripOrderDetails;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.ToolStripButton AddNewPositionOrderDetailsToolStripButton;
        private System.Windows.Forms.ToolStripButton EditPositionOrderDetailsToolStripButton;
        private System.Windows.Forms.ToolStripButton DeletePositionOrderDetailsToolStripButton;
        private System.Windows.Forms.ToolStripButton EditOrderToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteOrderToolStripButton;
        private System.Windows.Forms.ToolStripButton RefreshOrderToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton PrintOrderToolStripButton;
        private System.Windows.Forms.ToolStripButton PayOrderStripButton;
        private System.Windows.Forms.ToolStripButton ShipmentOrderStripButton;
        private System.Windows.Forms.ToolStripButton CancelPaymentToolStripButton;
        private System.Windows.Forms.ToolStripButton CancelShippedToolStripButton;
        private System.Windows.Forms.ToolStripButton exportExcelToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

