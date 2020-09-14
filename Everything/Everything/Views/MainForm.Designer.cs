﻿namespace Everything.Views
{
    partial class MainForm
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
            this.CBDrives = new System.Windows.Forms.ComboBox();
            this.BTFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBLastUsn = new System.Windows.Forms.TextBox();
            this.TBResult = new System.Windows.Forms.TextBox();
            this.TBLastFrn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTLine = new System.Windows.Forms.Button();
            this.BTCreateUSN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBDrives
            // 
            this.CBDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDrives.FormattingEnabled = true;
            this.CBDrives.Location = new System.Drawing.Point(158, 16);
            this.CBDrives.Name = "CBDrives";
            this.CBDrives.Size = new System.Drawing.Size(129, 21);
            this.CBDrives.TabIndex = 0;
            // 
            // BTFind
            // 
            this.BTFind.Location = new System.Drawing.Point(364, 16);
            this.BTFind.Name = "BTFind";
            this.BTFind.Size = new System.Drawing.Size(109, 60);
            this.BTFind.TabIndex = 1;
            this.BTFind.Text = "Find [○-]";
            this.BTFind.UseVisualStyleBackColor = true;
            this.BTFind.Click += new System.EventHandler(this.BTFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Disk：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last USN value：";
            // 
            // TBLastUsn
            // 
            this.TBLastUsn.Location = new System.Drawing.Point(158, 53);
            this.TBLastUsn.Name = "TBLastUsn";
            this.TBLastUsn.Size = new System.Drawing.Size(129, 20);
            this.TBLastUsn.TabIndex = 4;
            this.TBLastUsn.Text = "0";
            this.TBLastUsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBLastUsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBLastUsn_KeyPress);
            // 
            // TBResult
            // 
            this.TBResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBResult.Location = new System.Drawing.Point(14, 128);
            this.TBResult.Multiline = true;
            this.TBResult.Name = "TBResult";
            this.TBResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBResult.Size = new System.Drawing.Size(597, 462);
            this.TBResult.TabIndex = 5;
            // 
            // TBLastFrn
            // 
            this.TBLastFrn.Location = new System.Drawing.Point(158, 90);
            this.TBLastFrn.Name = "TBLastFrn";
            this.TBLastFrn.Size = new System.Drawing.Size(129, 20);
            this.TBLastFrn.TabIndex = 7;
            this.TBLastFrn.Text = "0";
            this.TBLastFrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBLastFrn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBLastFrn_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last File Number：";
            // 
            // BTLine
            // 
            this.BTLine.Location = new System.Drawing.Point(502, 16);
            this.BTLine.Name = "BTLine";
            this.BTLine.Size = new System.Drawing.Size(109, 60);
            this.BTLine.TabIndex = 8;
            this.BTLine.Text = "Dividing Line [---]";
            this.BTLine.UseVisualStyleBackColor = true;
            this.BTLine.Click += new System.EventHandler(this.BTLine_Click);
            // 
            // BTCreateUSN
            // 
            this.BTCreateUSN.Location = new System.Drawing.Point(364, 87);
            this.BTCreateUSN.Name = "BTCreateUSN";
            this.BTCreateUSN.Size = new System.Drawing.Size(109, 25);
            this.BTCreateUSN.TabIndex = 9;
            this.BTCreateUSN.Text = "Create USN";
            this.BTCreateUSN.UseVisualStyleBackColor = true;
            this.BTCreateUSN.Click += new System.EventHandler(this.BTCreateUSN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 603);
            this.Controls.Add(this.BTCreateUSN);
            this.Controls.Add(this.BTLine);
            this.Controls.Add(this.TBLastFrn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBResult);
            this.Controls.Add(this.TBLastUsn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTFind);
            this.Controls.Add(this.CBDrives);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBDrives;
        private System.Windows.Forms.Button BTFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBLastUsn;
        private System.Windows.Forms.TextBox TBResult;
        private System.Windows.Forms.TextBox TBLastFrn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTLine;
        private System.Windows.Forms.Button BTCreateUSN;
    }
}