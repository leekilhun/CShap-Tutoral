﻿
namespace exLockCritical
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRoom1 = new System.Windows.Forms.Button();
            this.lboxRoom1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lboxRoom2 = new System.Windows.Forms.ListBox();
            this.btnRoom2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLockStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lboxRoom1);
            this.groupBox1.Controls.Add(this.btnRoom1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "No 1. Room";
            // 
            // btnRoom1
            // 
            this.btnRoom1.Location = new System.Drawing.Point(6, 20);
            this.btnRoom1.Name = "btnRoom1";
            this.btnRoom1.Size = new System.Drawing.Size(50, 100);
            this.btnRoom1.TabIndex = 0;
            this.btnRoom1.Text = "예약";
            this.btnRoom1.UseVisualStyleBackColor = true;
            this.btnRoom1.Click += new System.EventHandler(this.btnRoom1_Click);
            // 
            // lboxRoom1
            // 
            this.lboxRoom1.FormattingEnabled = true;
            this.lboxRoom1.ItemHeight = 12;
            this.lboxRoom1.Location = new System.Drawing.Point(62, 20);
            this.lboxRoom1.Name = "lboxRoom1";
            this.lboxRoom1.Size = new System.Drawing.Size(70, 100);
            this.lboxRoom1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboxRoom2);
            this.groupBox2.Controls.Add(this.btnRoom2);
            this.groupBox2.Location = new System.Drawing.Point(160, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 131);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "No 2. Room";
            // 
            // lboxRoom2
            // 
            this.lboxRoom2.FormattingEnabled = true;
            this.lboxRoom2.ItemHeight = 12;
            this.lboxRoom2.Location = new System.Drawing.Point(62, 20);
            this.lboxRoom2.Name = "lboxRoom2";
            this.lboxRoom2.Size = new System.Drawing.Size(70, 100);
            this.lboxRoom2.TabIndex = 1;
            // 
            // btnRoom2
            // 
            this.btnRoom2.Location = new System.Drawing.Point(6, 20);
            this.btnRoom2.Name = "btnRoom2";
            this.btnRoom2.Size = new System.Drawing.Size(50, 100);
            this.btnRoom2.TabIndex = 0;
            this.btnRoom2.Text = "예약";
            this.btnRoom2.UseVisualStyleBackColor = true;
            this.btnRoom2.Click += new System.EventHandler(this.btnRoom2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "사용 현황";
            // 
            // lblLockStatus
            // 
            this.lblLockStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLockStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLockStatus.Location = new System.Drawing.Point(12, 178);
            this.lblLockStatus.Name = "lblLockStatus";
            this.lblLockStatus.Size = new System.Drawing.Size(290, 29);
            this.lblLockStatus.TabIndex = 1;
            this.lblLockStatus.Text = "None";
            this.lblLockStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "이력";
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.ItemHeight = 12;
            this.lboxResult.Location = new System.Drawing.Point(12, 255);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(290, 256);
            this.lboxResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 531);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.lblLockStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lboxRoom1;
        private System.Windows.Forms.Button btnRoom1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lboxRoom2;
        private System.Windows.Forms.Button btnRoom2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLockStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxResult;
    }
}

