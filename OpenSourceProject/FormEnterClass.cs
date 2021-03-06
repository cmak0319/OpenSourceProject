﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSourceProject
{
    public partial class FormEnterClass : Form
    {

        public string name { get; set; }

        public FormEnterClass()
        {
            InitializeComponent();
        }

        private void buttonResult(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "Ok")
            {
                this.DialogResult = DialogResult.OK;
                name = textBoxClassName.Text;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
