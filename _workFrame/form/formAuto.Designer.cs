
namespace workFrame.form
{
    partial class formAuto
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnSimulationAsync = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pDoor2 = new System.Windows.Forms.Panel();
            this.pDoor1 = new System.Windows.Forms.Panel();
            this.pRobot = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnInit);
            this.groupBox2.Controls.Add(this.btnSimulationAsync);
            this.groupBox2.Location = new System.Drawing.Point(424, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(170, 289);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "전체 동작";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "m/s";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "100";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "동작 Delay : ";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(6, 25);
            this.btnInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(156, 39);
            this.btnInit.TabIndex = 10;
            this.btnInit.Text = "초기 화면 표시";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnSimulationAsync
            // 
            this.btnSimulationAsync.Location = new System.Drawing.Point(5, 125);
            this.btnSimulationAsync.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimulationAsync.Name = "btnSimulationAsync";
            this.btnSimulationAsync.Size = new System.Drawing.Size(156, 39);
            this.btnSimulationAsync.TabIndex = 9;
            this.btnSimulationAsync.Text = "비동기 동작 진행";
            this.btnSimulationAsync.UseVisualStyleBackColor = true;
            this.btnSimulationAsync.Click += new System.EventHandler(this.btnSimulationAsync_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pDoor2);
            this.groupBox1.Controls.Add(this.pDoor1);
            this.groupBox1.Controls.Add(this.pRobot);
            this.groupBox1.Location = new System.Drawing.Point(112, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(306, 289);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // pDoor2
            // 
            this.pDoor2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pDoor2.Location = new System.Drawing.Point(255, 25);
            this.pDoor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDoor2.Name = "pDoor2";
            this.pDoor2.Size = new System.Drawing.Size(40, 250);
            this.pDoor2.TabIndex = 3;
            // 
            // pDoor1
            // 
            this.pDoor1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pDoor1.Location = new System.Drawing.Point(11, 25);
            this.pDoor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDoor1.Name = "pDoor1";
            this.pDoor1.Size = new System.Drawing.Size(40, 250);
            this.pDoor1.TabIndex = 2;
            // 
            // pRobot
            // 
            this.pRobot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pRobot.Location = new System.Drawing.Point(53, 25);
            this.pRobot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pRobot.Name = "pRobot";
            this.pRobot.Size = new System.Drawing.Size(200, 250);
            this.pRobot.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 5);
            this.panel1.TabIndex = 15;
            // 
            // formAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formAuto";
            this.Text = "Auto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAuto_FormClosing);
            this.Load += new System.EventHandler(this.formAuto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnSimulationAsync;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pDoor2;
        private System.Windows.Forms.Panel pDoor1;
        private System.Windows.Forms.Panel pRobot;
        private System.Windows.Forms.Panel panel1;
    }
}

