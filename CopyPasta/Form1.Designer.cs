namespace CopyPasta
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
            this.CopyList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CopyList
            // 
            this.CopyList.FormattingEnabled = true;
            this.CopyList.ItemHeight = 16;
            this.CopyList.Items.AddRange(new object[] {
            "test1",
            "test2",
            "Dylan is mad at me"});
            this.CopyList.Location = new System.Drawing.Point(12, 21);
            this.CopyList.Name = "CopyList";
            this.CopyList.ScrollAlwaysVisible = true;
            this.CopyList.Size = new System.Drawing.Size(233, 340);
            this.CopyList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(257, 386);
            this.Controls.Add(this.CopyList);
            this.Name = "Form1";
            this.Text = "CopyPasta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CopyList;
    }
}

