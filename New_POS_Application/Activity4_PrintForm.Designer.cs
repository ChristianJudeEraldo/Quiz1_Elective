namespace New_POS_Application
{
    partial class Activity4_PrintForm
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
            this.printListForm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // printListForm
            // 
            this.printListForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printListForm.FormattingEnabled = true;
            this.printListForm.Location = new System.Drawing.Point(31, 22);
            this.printListForm.Name = "printListForm";
            this.printListForm.Size = new System.Drawing.Size(490, 394);
            this.printListForm.TabIndex = 0;
            // 
            // Activity4_PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.printListForm);
            this.Name = "Activity4_PrintForm";
            this.Text = "Activity4_namin";
            this.Load += new System.EventHandler(this.Activity4_PrintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox printListForm;
    }
}