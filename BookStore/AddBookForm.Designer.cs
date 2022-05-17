namespace BookStore
{
    partial class AddBookForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublishing = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbPublishing = new System.Windows.Forms.ComboBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnAddPublishing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(59, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(59, 75);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(37, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Автор";
            // 
            // lblPublishing
            // 
            this.lblPublishing.AutoSize = true;
            this.lblPublishing.Location = new System.Drawing.Point(59, 109);
            this.lblPublishing.Name = "lblPublishing";
            this.lblPublishing.Size = new System.Drawing.Size(79, 13);
            this.lblPublishing.TabIndex = 2;
            this.lblPublishing.Text = "Издательство";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(59, 142);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Цена";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(59, 178);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(66, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Количество";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(181, 37);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(270, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(181, 139);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(181, 175);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 9;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(181, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(332, 217);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbAuthor
            // 
            this.cbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(181, 72);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(270, 21);
            this.cbAuthor.TabIndex = 12;
            // 
            // cbPublishing
            // 
            this.cbPublishing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPublishing.FormattingEnabled = true;
            this.cbPublishing.Location = new System.Drawing.Point(181, 106);
            this.cbPublishing.Name = "cbPublishing";
            this.cbPublishing.Size = new System.Drawing.Size(270, 21);
            this.cbPublishing.TabIndex = 13;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(483, 72);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 14;
            this.btnAddAuthor.Text = "Добавить";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddPublishing
            // 
            this.btnAddPublishing.Location = new System.Drawing.Point(483, 106);
            this.btnAddPublishing.Name = "btnAddPublishing";
            this.btnAddPublishing.Size = new System.Drawing.Size(75, 23);
            this.btnAddPublishing.TabIndex = 15;
            this.btnAddPublishing.Text = "Добавить";
            this.btnAddPublishing.UseVisualStyleBackColor = true;
            this.btnAddPublishing.Click += new System.EventHandler(this.btnAddPublishing_Click);
            // 
            // AddBookForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.btnAddPublishing);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.cbPublishing);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPublishing);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddBookForm";
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublishing;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtCount;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.ComboBox cbAuthor;
        public System.Windows.Forms.ComboBox cbPublishing;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddPublishing;
    }
}