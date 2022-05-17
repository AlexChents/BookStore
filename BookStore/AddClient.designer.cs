namespace BookStore
{
    partial class AddClient
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
            this.lblNameClient = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBoxNameClient = new System.Windows.Forms.TextBox();
            this.mTxtBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameClient
            // 
            this.lblNameClient.AutoSize = true;
            this.lblNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameClient.Location = new System.Drawing.Point(87, 31);
            this.lblNameClient.Name = "lblNameClient";
            this.lblNameClient.Size = new System.Drawing.Size(83, 15);
            this.lblNameClient.TabIndex = 0;
            this.lblNameClient.Text = "Имя клиента";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(87, 64);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 15);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Телефон";
            // 
            // txtBoxNameClient
            // 
            this.txtBoxNameClient.Location = new System.Drawing.Point(182, 28);
            this.txtBoxNameClient.Name = "txtBoxNameClient";
            this.txtBoxNameClient.Size = new System.Drawing.Size(219, 20);
            this.txtBoxNameClient.TabIndex = 3;
            this.txtBoxNameClient.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxNameClient_Validating);
            // 
            // mTxtBoxPhone
            // 
            this.mTxtBoxPhone.Location = new System.Drawing.Point(182, 61);
            this.mTxtBoxPhone.Mask = "(999) 000-0000";
            this.mTxtBoxPhone.Name = "mTxtBoxPhone";
            this.mTxtBoxPhone.Size = new System.Drawing.Size(219, 20);
            this.mTxtBoxPhone.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(113, 145);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddClient
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(470, 192);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.mTxtBoxPhone);
            this.Controls.Add(this.txtBoxNameClient);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblNameClient);
            this.Name = "AddClient";
            this.Text = "Добавление клиента";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameClient;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtBoxNameClient;
        public System.Windows.Forms.MaskedTextBox mTxtBoxPhone;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}