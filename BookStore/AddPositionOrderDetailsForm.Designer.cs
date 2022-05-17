namespace BookStore
{
    partial class AddPositionOrderDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.lblCountFree = new System.Windows.Forms.Label();
            this.txtBoxCountBookFree = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.brnOk = new System.Windows.Forms.Button();
            this.cbNameBook = new System.Windows.Forms.ComboBox();
            this.txtBoxCountBook = new System.Windows.Forms.TextBox();
            this.lblCountBook = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Location = new System.Drawing.Point(15, 27);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(83, 13);
            this.lblNameBook.TabIndex = 0;
            this.lblNameBook.Text = "Наименование";
            // 
            // lblCountFree
            // 
            this.lblCountFree.AutoSize = true;
            this.lblCountFree.Location = new System.Drawing.Point(15, 66);
            this.lblCountFree.Name = "lblCountFree";
            this.lblCountFree.Size = new System.Drawing.Size(107, 13);
            this.lblCountFree.TabIndex = 1;
            this.lblCountFree.Text = "Свободный остаток";
            // 
            // txtBoxCountBookFree
            // 
            this.txtBoxCountBookFree.Enabled = false;
            this.txtBoxCountBookFree.Location = new System.Drawing.Point(138, 63);
            this.txtBoxCountBookFree.Name = "txtBoxCountBookFree";
            this.txtBoxCountBookFree.Size = new System.Drawing.Size(75, 20);
            this.txtBoxCountBookFree.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(142, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // brnOk
            // 
            this.brnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.brnOk.Location = new System.Drawing.Point(260, 127);
            this.brnOk.Name = "brnOk";
            this.brnOk.Size = new System.Drawing.Size(75, 23);
            this.brnOk.TabIndex = 5;
            this.brnOk.Text = "ОК";
            this.brnOk.UseVisualStyleBackColor = true;
            this.brnOk.Click += new System.EventHandler(this.brnOk_Click);
            // 
            // cbNameBook
            // 
            this.cbNameBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameBook.FormattingEnabled = true;
            this.cbNameBook.Location = new System.Drawing.Point(138, 24);
            this.cbNameBook.Name = "cbNameBook";
            this.cbNameBook.Size = new System.Drawing.Size(204, 21);
            this.cbNameBook.TabIndex = 6;
            this.cbNameBook.TextChanged += new System.EventHandler(this.cbNameBook_TextChanged);
            // 
            // txtBoxCountBook
            // 
            this.txtBoxCountBook.Location = new System.Drawing.Point(138, 93);
            this.txtBoxCountBook.Name = "txtBoxCountBook";
            this.txtBoxCountBook.Size = new System.Drawing.Size(75, 20);
            this.txtBoxCountBook.TabIndex = 8;
            this.txtBoxCountBook.TextChanged += new System.EventHandler(this.txtBoxCountBook_TextChanged);
            this.txtBoxCountBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCountBook_KeyPress);
            this.txtBoxCountBook.Leave += new System.EventHandler(this.txtBoxCountBook_Leave);
            // 
            // lblCountBook
            // 
            this.lblCountBook.AutoSize = true;
            this.lblCountBook.Location = new System.Drawing.Point(15, 96);
            this.lblCountBook.Name = "lblCountBook";
            this.lblCountBook.Size = new System.Drawing.Size(66, 13);
            this.lblCountBook.TabIndex = 7;
            this.lblCountBook.Text = "Количество";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddPositionOrderDetailsForm
            // 
            this.AcceptButton = this.brnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(358, 162);
            this.Controls.Add(this.txtBoxCountBook);
            this.Controls.Add(this.lblCountBook);
            this.Controls.Add(this.cbNameBook);
            this.Controls.Add(this.brnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxCountBookFree);
            this.Controls.Add(this.lblCountFree);
            this.Controls.Add(this.lblNameBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPositionOrderDetailsForm";
            this.Text = "Добавить позицию";
            this.Load += new System.EventHandler(this.AddPositionOrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.Label lblCountFree;
        private System.Windows.Forms.TextBox txtBoxCountBookFree;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button brnOk;
        private System.Windows.Forms.Label lblCountBook;
        public System.Windows.Forms.ComboBox cbNameBook;
        public System.Windows.Forms.TextBox txtBoxCountBook;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}