namespace beadando_dwmk81
{
    partial class SalesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesUserControl));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchedListBox = new System.Windows.Forms.ListBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.kocka1 = new System.Windows.Forms.Button();
            this.kocka2 = new System.Windows.Forms.Button();
            this.kocka3 = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.dayCloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which book are they looking for?";
            // 
            // searchedListBox
            // 
            this.searchedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedListBox.FormattingEnabled = true;
            this.searchedListBox.ItemHeight = 15;
            this.searchedListBox.Location = new System.Drawing.Point(42, 118);
            this.searchedListBox.Name = "searchedListBox";
            this.searchedListBox.Size = new System.Drawing.Size(222, 124);
            this.searchedListBox.TabIndex = 2;
            this.searchedListBox.SelectedIndexChanged += new System.EventHandler(this.searchedListBox_SelectedIndexChanged);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.BackColor = System.Drawing.Color.Transparent;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.ForeColor = System.Drawing.Color.White;
            this.amountLbl.Location = new System.Drawing.Point(39, 265);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(202, 15);
            this.amountLbl.TabIndex = 3;
            this.amountLbl.Text = "How many do we have of this book?";
            // 
            // kocka1
            // 
            this.kocka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kocka1.Location = new System.Drawing.Point(404, 182);
            this.kocka1.Name = "kocka1";
            this.kocka1.Size = new System.Drawing.Size(60, 60);
            this.kocka1.TabIndex = 4;
            this.kocka1.Text = "1";
            this.kocka1.UseVisualStyleBackColor = true;
            // 
            // kocka2
            // 
            this.kocka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kocka2.Location = new System.Drawing.Point(482, 182);
            this.kocka2.Name = "kocka2";
            this.kocka2.Size = new System.Drawing.Size(60, 60);
            this.kocka2.TabIndex = 5;
            this.kocka2.Text = "1";
            this.kocka2.UseVisualStyleBackColor = true;
            // 
            // kocka3
            // 
            this.kocka3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kocka3.Location = new System.Drawing.Point(561, 182);
            this.kocka3.Name = "kocka3";
            this.kocka3.Size = new System.Drawing.Size(60, 60);
            this.kocka3.TabIndex = 6;
            this.kocka3.Text = "1";
            this.kocka3.UseVisualStyleBackColor = true;
            // 
            // salesBtn
            // 
            this.salesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBtn.Location = new System.Drawing.Point(404, 141);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(75, 23);
            this.salesBtn.TabIndex = 7;
            this.salesBtn.Text = "Sell";
            this.salesBtn.UseVisualStyleBackColor = true;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.incomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLbl.ForeColor = System.Drawing.Color.White;
            this.incomeLbl.Location = new System.Drawing.Point(366, 329);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(81, 15);
            this.incomeLbl.TabIndex = 8;
            this.incomeLbl.Text = "Daily income:";
            // 
            // dayCloseBtn
            // 
            this.dayCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCloseBtn.Location = new System.Drawing.Point(601, 321);
            this.dayCloseBtn.Name = "dayCloseBtn";
            this.dayCloseBtn.Size = new System.Drawing.Size(75, 23);
            this.dayCloseBtn.TabIndex = 9;
            this.dayCloseBtn.Text = "Close day";
            this.dayCloseBtn.UseVisualStyleBackColor = true;
            this.dayCloseBtn.Click += new System.EventHandler(this.dayCloseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(289, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sales Center";
            // 
            // SalesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayCloseBtn);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.salesBtn);
            this.Controls.Add(this.kocka3);
            this.Controls.Add(this.kocka2);
            this.Controls.Add(this.kocka1);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.searchedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "SalesUserControl";
            this.Size = new System.Drawing.Size(708, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox searchedListBox;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Button kocka1;
        private System.Windows.Forms.Button kocka2;
        private System.Windows.Forms.Button kocka3;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Button dayCloseBtn;
        private System.Windows.Forms.Label label2;
    }
}
