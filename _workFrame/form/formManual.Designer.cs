
namespace workFrame.form
{
    partial class formManual
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnD1Open = new System.Windows.Forms.Button();
            this.btnD1Close = new System.Windows.Forms.Button();
            this.btnD2Open = new System.Windows.Forms.Button();
            this.btnRobotE = new System.Windows.Forms.Button();
            this.btnRobotR = new System.Windows.Forms.Button();
            this.btnD2Close = new System.Windows.Forms.Button();
            this.btnRobotRotate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnD1Open);
            this.groupBox3.Controls.Add(this.btnD1Close);
            this.groupBox3.Controls.Add(this.btnD2Open);
            this.groupBox3.Controls.Add(this.btnRobotE);
            this.groupBox3.Controls.Add(this.btnRobotR);
            this.groupBox3.Controls.Add(this.btnD2Close);
            this.groupBox3.Controls.Add(this.btnRobotRotate);
            this.groupBox3.Location = new System.Drawing.Point(249, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(262, 289);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "단위 동작";
            // 
            // btnD1Open
            // 
            this.btnD1Open.Location = new System.Drawing.Point(6, 25);
            this.btnD1Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD1Open.Name = "btnD1Open";
            this.btnD1Open.Size = new System.Drawing.Size(121, 50);
            this.btnD1Open.TabIndex = 5;
            this.btnD1Open.Text = "Door1 Open";
            this.btnD1Open.UseVisualStyleBackColor = true;
            // 
            // btnD1Close
            // 
            this.btnD1Close.Location = new System.Drawing.Point(6, 80);
            this.btnD1Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD1Close.Name = "btnD1Close";
            this.btnD1Close.Size = new System.Drawing.Size(121, 50);
            this.btnD1Close.TabIndex = 6;
            this.btnD1Close.Text = "Door1 Close";
            this.btnD1Close.UseVisualStyleBackColor = true;
            // 
            // btnD2Open
            // 
            this.btnD2Open.Location = new System.Drawing.Point(133, 25);
            this.btnD2Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD2Open.Name = "btnD2Open";
            this.btnD2Open.Size = new System.Drawing.Size(121, 50);
            this.btnD2Open.TabIndex = 7;
            this.btnD2Open.Text = "Door2 Open";
            this.btnD2Open.UseVisualStyleBackColor = true;
            // 
            // btnRobotE
            // 
            this.btnRobotE.Location = new System.Drawing.Point(6, 136);
            this.btnRobotE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRobotE.Name = "btnRobotE";
            this.btnRobotE.Size = new System.Drawing.Size(248, 44);
            this.btnRobotE.TabIndex = 4;
            this.btnRobotE.Text = "Robot Arm Extend";
            this.btnRobotE.UseVisualStyleBackColor = true;
            // 
            // btnRobotR
            // 
            this.btnRobotR.Location = new System.Drawing.Point(6, 184);
            this.btnRobotR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRobotR.Name = "btnRobotR";
            this.btnRobotR.Size = new System.Drawing.Size(248, 44);
            this.btnRobotR.TabIndex = 3;
            this.btnRobotR.Text = "Robot Arm Retract";
            this.btnRobotR.UseVisualStyleBackColor = true;
            // 
            // btnD2Close
            // 
            this.btnD2Close.Location = new System.Drawing.Point(133, 80);
            this.btnD2Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD2Close.Name = "btnD2Close";
            this.btnD2Close.Size = new System.Drawing.Size(121, 50);
            this.btnD2Close.TabIndex = 8;
            this.btnD2Close.Text = "Door2 Close";
            this.btnD2Close.UseVisualStyleBackColor = true;
            // 
            // btnRobotRotate
            // 
            this.btnRobotRotate.Location = new System.Drawing.Point(6, 231);
            this.btnRobotRotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRobotRotate.Name = "btnRobotRotate";
            this.btnRobotRotate.Size = new System.Drawing.Size(248, 44);
            this.btnRobotRotate.TabIndex = 2;
            this.btnRobotRotate.Text = "Robot Rotate";
            this.btnRobotRotate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 5);
            this.panel1.TabIndex = 15;
            // 
            // formManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formManual";
            this.Text = "Manual";
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnD1Open;
        private System.Windows.Forms.Button btnD1Close;
        private System.Windows.Forms.Button btnD2Open;
        private System.Windows.Forms.Button btnRobotE;
        private System.Windows.Forms.Button btnRobotR;
        private System.Windows.Forms.Button btnD2Close;
        private System.Windows.Forms.Button btnRobotRotate;
        private System.Windows.Forms.Panel panel1;
    }
}

