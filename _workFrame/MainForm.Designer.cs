
namespace workFrame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSc1 = new System.Windows.Forms.Button();
            this.BtnSc2 = new System.Windows.Forms.Button();
            this.BtnSc3 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lboxLog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 664);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lboxLog
            // 
            this.lboxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 15;
            this.lboxLog.Location = new System.Drawing.Point(3, 4);
            this.lboxLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(794, 92);
            this.lboxLog.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.BtnSc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSc2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSc3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnExit, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 606);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnSc1
            // 
            this.BtnSc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSc1.Location = new System.Drawing.Point(3, 4);
            this.BtnSc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSc1.Name = "BtnSc1";
            this.BtnSc1.Size = new System.Drawing.Size(74, 46);
            this.BtnSc1.TabIndex = 0;
            this.BtnSc1.Text = "Input";
            this.BtnSc1.UseVisualStyleBackColor = true;
            this.BtnSc1.Click += new System.EventHandler(this.button_Click);
            // 
            // BtnSc2
            // 
            this.BtnSc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSc2.Location = new System.Drawing.Point(83, 4);
            this.BtnSc2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSc2.Name = "BtnSc2";
            this.BtnSc2.Size = new System.Drawing.Size(74, 46);
            this.BtnSc2.TabIndex = 1;
            this.BtnSc2.Text = "Chart";
            this.BtnSc2.UseVisualStyleBackColor = true;
            this.BtnSc2.Click += new System.EventHandler(this.button_Click);
            // 
            // BtnSc3
            // 
            this.BtnSc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSc3.Location = new System.Drawing.Point(163, 4);
            this.BtnSc3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSc3.Name = "BtnSc3";
            this.BtnSc3.Size = new System.Drawing.Size(74, 46);
            this.BtnSc3.TabIndex = 2;
            this.BtnSc3.Text = "Config";
            this.BtnSc3.UseVisualStyleBackColor = true;
            this.BtnSc3.Click += new System.EventHandler(this.button_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Location = new System.Drawing.Point(717, 4);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(74, 46);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button_Click);
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(3, 104);
            this.pMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(794, 494);
            this.pMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnSc1;
        private System.Windows.Forms.Button BtnSc2;
        private System.Windows.Forms.Button BtnSc3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel pMain;
    }
}

