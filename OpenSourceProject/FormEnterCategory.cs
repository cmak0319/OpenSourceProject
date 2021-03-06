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
    public partial class FormEnterCategory : Form
    {

        public object[] data { get; set; }

        public FormEnterCategory(int remainingPercent)
        {
            InitializeComponent();
            data = new object[2];
            numericUpDownPercent.Maximum = remainingPercent;
        }

        private void buttonResult(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "Ok")
            {
                this.DialogResult = DialogResult.OK;
                data[0] = textBoxCategoryName.Text;
                data[1] = numericUpDownPercent.Value;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void numericUpDownPercent_Enter(object sender, EventArgs e)
        {
            numericUpDownPercent.Select(0, numericUpDownPercent.Text.Length);
        }
    }
}