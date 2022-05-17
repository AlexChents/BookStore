namespace BookStore
{
    partial class AddUserForm
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
            this.lblFirstNameUser = new System.Windows.Forms.Label();
            this.lblLastNameUser = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblLevelAccess = new System.Windows.Forms.Label();
            this.txtBoxLevelAccess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstNameUser
            // 
            this.lblFirstNameUser.AutoSize = true;
            this.lblFirstNameUser.Location = new System.Drawing.Point(54, 16);
            this.lblFirstNameUser.Name = "lblFirstNameUser";
            this.lblFirstNameUser.Size = new System.Drawing.Size(103, 13);
            this.lblFirstNameUser.TabIndex = 0;
            this.lblFirstNameUser.Text = "Имя пользователя";
            // 
            // lblLastNameUser
            // 
            this.lblLastNameUser.AutoSize = true;
            this.lblLastNameUser.Location = new System.Drawing.Point(54, 41);
            this.lblLastNameUser.Name = "lblLastNameUser";
            this.lblLastNameUser.Size = new System.Drawing.Size(130, 13);
            this.lblLastNameUser.TabIndex = 1;
            this.lblLastNameUser.Text = "Фамилия пользователя";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(54, 68);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(54, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(212, 11);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(227, 20);
            this.txtBoxFirstName.TabIndex = 4;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(212, 37);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(227, 20);
            this.txtBoxLastName.TabIndex = 5;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(212, 65);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(227, 20);
            this.txtBoxLogin.TabIndex = 6;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(212, 91);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(227, 20);
            this.txtBoxPassword.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(364, 157);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblLevelAccess
            // 
            this.lblLevelAccess.AutoSize = true;
            this.lblLevelAccess.Location = new System.Drawing.Point(54, 124);
            this.lblLevelAccess.Name = "lblLevelAccess";
            this.lblLevelAccess.Size = new System.Drawing.Size(94, 13);
            this.lblLevelAccess.TabIndex = 10;
            this.lblLevelAccess.Text = "Уровень доступа";
            // 
            // txtBoxLevelAccess
            // 
            this.txtBoxLevelAccess.Location = new System.Drawing.Point(212, 121);
            this.txtBoxLevelAccess.Name = "txtBoxLevelAccess";
            this.txtBoxLevelAccess.Size = new System.Drawing.Size(52, 20);
            this.txtBoxLevelAccess.TabIndex = 8;
            this.txtBoxLevelAccess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxLevelAccess_KeyPress);
            // 
            // AddUserForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 189);
            this.Controls.Add(this.txtBoxLevelAccess);
            this.Controls.Add(this.lblLevelAccess);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblLastNameUser);
            this.Controls.Add(this.lblFirstNameUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserForm";
            this.Text = "Добавить пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNameUser;
        private System.Windows.Forms.Label lblLastNameUser;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblLevelAccess;
        public System.Windows.Forms.TextBox txtBoxFirstName;
        public System.Windows.Forms.TextBox txtBoxLastName;
        public System.Windows.Forms.TextBox txtBoxLogin;
        public System.Windows.Forms.TextBox txtBoxPassword;
        public System.Windows.Forms.TextBox txtBoxLevelAccess;
    }
}