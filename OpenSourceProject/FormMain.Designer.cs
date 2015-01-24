﻿namespace OpenSourceProject
{
    partial class FormMain
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptsPoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxTotals = new System.Windows.Forms.GroupBox();
            this.divider2 = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelPtsPoss = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxGrade = new System.Windows.Forms.GroupBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelLetterGrade = new System.Windows.Forms.Label();
            this.divider3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.editCategory.SuspendLayout();
            this.groupBoxTotals.SuspendLayout();
            this.groupBoxGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.multiplier,
            this.ptsPoss,
            this.score,
            this.percent});
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(24, 85);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(573, 150);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnEndCellEdit);
            this.dataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.OnDeleteRow);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // multiplier
            // 
            this.multiplier.HeaderText = "Multiplier";
            this.multiplier.Name = "multiplier";
            // 
            // ptsPoss
            // 
            this.ptsPoss.HeaderText = "PtsPoss";
            this.ptsPoss.Name = "ptsPoss";
            // 
            // score
            // 
            this.score.HeaderText = "Score";
            this.score.Name = "score";
            // 
            // percent
            // 
            this.percent.HeaderText = "Percent";
            this.percent.Name = "percent";
            this.percent.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.calculateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateToolStripMenuItem.Text = "Calculate";
            // 
            // editCategory
            // 
            this.editCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.editCategory.Name = "editCategory";
            this.editCategory.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // groupBoxTotals
            // 
            this.groupBoxTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTotals.Controls.Add(this.divider2);
            this.groupBoxTotals.Controls.Add(this.divider1);
            this.groupBoxTotals.Controls.Add(this.labelScore);
            this.groupBoxTotals.Controls.Add(this.labelPtsPoss);
            this.groupBoxTotals.Controls.Add(this.labelPercent);
            this.groupBoxTotals.Location = new System.Drawing.Point(298, 244);
            this.groupBoxTotals.Name = "groupBoxTotals";
            this.groupBoxTotals.Size = new System.Drawing.Size(299, 39);
            this.groupBoxTotals.TabIndex = 3;
            this.groupBoxTotals.TabStop = false;
            this.groupBoxTotals.Text = "Category Totals (%)";
            // 
            // divider2
            // 
            this.divider2.AutoSize = true;
            this.divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider2.Location = new System.Drawing.Point(197, 16);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(2, 15);
            this.divider2.TabIndex = 3;
            // 
            // divider1
            // 
            this.divider1.AutoSize = true;
            this.divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider1.Location = new System.Drawing.Point(101, 16);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(2, 15);
            this.divider1.TabIndex = 4;
            // 
            // labelScore
            // 
            this.labelScore.Location = new System.Drawing.Point(101, 16);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(98, 13);
            this.labelScore.TabIndex = 1;
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPtsPoss
            // 
            this.labelPtsPoss.Location = new System.Drawing.Point(6, 16);
            this.labelPtsPoss.Name = "labelPtsPoss";
            this.labelPtsPoss.Size = new System.Drawing.Size(89, 13);
            this.labelPtsPoss.TabIndex = 0;
            this.labelPtsPoss.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPercent
            // 
            this.labelPercent.Location = new System.Drawing.Point(197, 16);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(96, 13);
            this.labelPercent.TabIndex = 2;
            this.labelPercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Create new category"});
            this.comboBoxCategory.Location = new System.Drawing.Point(75, 256);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 4;
            this.comboBoxCategory.SelectionChangeCommitted += new System.EventHandler(this.OnCategoryChange);
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(21, 260);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Category";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(37, 46);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(32, 13);
            this.labelClass.TabIndex = 6;
            this.labelClass.Text = "Class";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // groupBoxGrade
            // 
            this.groupBoxGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGrade.Controls.Add(this.labelGrade);
            this.groupBoxGrade.Controls.Add(this.labelLetterGrade);
            this.groupBoxGrade.Controls.Add(this.divider3);
            this.groupBoxGrade.Location = new System.Drawing.Point(399, 33);
            this.groupBoxGrade.Name = "groupBoxGrade";
            this.groupBoxGrade.Size = new System.Drawing.Size(192, 39);
            this.groupBoxGrade.TabIndex = 9;
            this.groupBoxGrade.TabStop = false;
            this.groupBoxGrade.Text = "Class Grade";
            // 
            // labelGrade
            // 
            this.labelGrade.Location = new System.Drawing.Point(102, 18);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(84, 13);
            this.labelGrade.TabIndex = 11;
            this.labelGrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLetterGrade
            // 
            this.labelLetterGrade.Location = new System.Drawing.Point(6, 18);
            this.labelLetterGrade.Name = "labelLetterGrade";
            this.labelLetterGrade.Size = new System.Drawing.Size(84, 13);
            this.labelLetterGrade.TabIndex = 10;
            this.labelLetterGrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // divider3
            // 
            this.divider3.AutoSize = true;
            this.divider3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider3.Location = new System.Drawing.Point(96, 16);
            this.divider3.Name = "divider3";
            this.divider3.Size = new System.Drawing.Size(2, 15);
            this.divider3.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 298);
            this.Controls.Add(this.groupBoxGrade);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.groupBoxTotals);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(636, 337);
            this.Name = "FormMain";
            this.Text = "Grade Calculator";
            this.Click += new System.EventHandler(this.OnClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.editCategory.ResumeLayout(false);
            this.groupBoxTotals.ResumeLayout(false);
            this.groupBoxTotals.PerformLayout();
            this.groupBoxGrade.ResumeLayout(false);
            this.groupBoxGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip editCategory;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTotals;
        private System.Windows.Forms.Label divider2;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelPtsPoss;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptsPoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn percent;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxGrade;
        private System.Windows.Forms.Label divider3;
        private System.Windows.Forms.Label labelLetterGrade;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
    }
}

