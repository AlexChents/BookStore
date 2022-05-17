﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AddPublishingForm : Form
    {
        public AddPublishingForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNamePublishing.Text))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.None;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
