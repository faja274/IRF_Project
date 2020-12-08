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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchedListBox = new System.Windows.Forms.ListBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which book are they looking for?";
            // 
            // searchedListBox
            // 
            this.searchedListBox.FormattingEnabled = true;
            this.searchedListBox.Location = new System.Drawing.Point(42, 86);
            this.searchedListBox.Name = "searchedListBox";
            this.searchedListBox.Size = new System.Drawing.Size(222, 134);
            this.searchedListBox.TabIndex = 2;
            this.searchedListBox.SelectedIndexChanged += new System.EventHandler(this.searchedListBox_SelectedIndexChanged);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(39, 233);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(180, 13);
            this.amountLbl.TabIndex = 3;
            this.amountLbl.Text = "How many do we have of this book?";
            // 
            // SalesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
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
    }
}
