﻿namespace beadando_dwmk81
{
    partial class Form1
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
            this.saleBtn = new System.Windows.Forms.Button();
            this.statsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.dayCloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saleBtn
            // 
            this.saleBtn.Location = new System.Drawing.Point(4, 13);
            this.saleBtn.Name = "saleBtn";
            this.saleBtn.Size = new System.Drawing.Size(84, 23);
            this.saleBtn.TabIndex = 0;
            this.saleBtn.Text = "Sale";
            this.saleBtn.UseVisualStyleBackColor = true;
            this.saleBtn.Click += new System.EventHandler(this.saleBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(4, 58);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(84, 23);
            this.statsBtn.TabIndex = 1;
            this.statsBtn.Text = "Stats";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(94, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 456);
            this.panel1.TabIndex = 2;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(4, 102);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(84, 23);
            this.uploadBtn.TabIndex = 3;
            this.uploadBtn.Text = "Store Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // dayCloseBtn
            // 
            this.dayCloseBtn.Location = new System.Drawing.Point(4, 189);
            this.dayCloseBtn.Name = "dayCloseBtn";
            this.dayCloseBtn.Size = new System.Drawing.Size(84, 23);
            this.dayCloseBtn.TabIndex = 4;
            this.dayCloseBtn.Text = "Close Day";
            this.dayCloseBtn.UseVisualStyleBackColor = true;
            this.dayCloseBtn.Click += new System.EventHandler(this.dayCloseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dayCloseBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.saleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saleBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button dayCloseBtn;
    }
}

