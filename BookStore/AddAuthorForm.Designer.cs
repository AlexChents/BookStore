namespace BookStore
{
    partial class AddAuthorForm
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
            this.lblNameAuthor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstNameAuthor = new System.Windows.Forms.TextBox();
            this.txtLastNameAuthor = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameAuthor
            // 
            this.lblNameAuthor.AutoSize = true;
            this.lblNameAuthor.Location = new System.Drawing.Point(37, 12);
            this.lblNameAuthor.Name = "lblNameAuthor";
            this.lblNameAuthor.Size = new System.Drawing.Size(67, 13);
            this.lblNameAuthor.TabIndex = 0;
            this.lblNameAuthor.Text = "Имя автора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия автора";
            // 
            // txtFirstNameAuthor
            // 
            this.txtFirstNameAuthor.Location = new System.Drawing.Point(146, 5);
            this.txtFirstNameAuthor.Name = "txtFirstNameAuthor";
            this.txtFirstNameAuthor.Size = new System.Drawing.Size(175, 20);
            this.txtFirstNameAuthor.TabIndex = 2;
            // 
            // txtLastNameAuthor
            // 
            this.txtLastNameAuthor.Location = new System.Drawing.Point(146, 40);
            this.txtLastNameAuthor.Name = "txtLastNameAuthor";
            this.txtLastNameAuthor.Size = new System.Drawing.Size(175, 20);
            this.txtLastNameAuthor.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(146, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(246, 66);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // AddAuthorForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(345, 101);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLastNameAuthor);
            this.Controls.Add(this.txtFirstNameAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameAuthor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAuthorForm";
            this.Text = "Добавить автора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.TextBox txtFirstNameAuthor;
        public System.Windows.Forms.TextBox txtLastNameAuthor;
    }
}