
namespace exListBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbWeeks = new System.Windows.Forms.ListBox();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWeeks
            // 
            this.lbWeeks.FormattingEnabled = true;
            this.lbWeeks.ItemHeight = 15;
            this.lbWeeks.Location = new System.Drawing.Point(12, 25);
            this.lbWeeks.Name = "lbWeeks";
            this.lbWeeks.Size = new System.Drawing.Size(135, 229);
            this.lbWeeks.TabIndex = 0;
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(13, 274);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(285, 23);
            this.tboxResult.TabIndex = 1;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(259, 35);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(140, 41);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "button1";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 413);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.lbWeeks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWeeks;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Button btnResult;
    }
}

