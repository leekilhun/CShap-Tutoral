
namespace exUser32DLLKeyboardHook
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
            this.components = new System.ComponentModel.Container();
            this.lboxTextSave = new System.Windows.Forms.ListBox();
            this.CMStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.공백제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.모두삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.프로그램정보ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cboxactivation = new System.Windows.Forms.CheckBox();
            this.lblactivation = new System.Windows.Forms.Label();
            this.pLowPanel = new System.Windows.Forms.Panel();
            this.btnlbtextadd = new System.Windows.Forms.Button();
            this.txtlbtextadd = new System.Windows.Forms.TextBox();
            this.TBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMStrip.SuspendLayout();
            this.pLowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxTextSave
            // 
            this.lboxTextSave.ContextMenuStrip = this.CMStrip;
            this.lboxTextSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTextSave.FormattingEnabled = true;
            this.lboxTextSave.ItemHeight = 15;
            this.lboxTextSave.Location = new System.Drawing.Point(3, 54);
            this.lboxTextSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxTextSave.Name = "lboxTextSave";
            this.lboxTextSave.Size = new System.Drawing.Size(297, 136);
            this.lboxTextSave.TabIndex = 0;
            this.lboxTextSave.SelectedIndexChanged += new System.EventHandler(this.LboxTestSave_SelectedIndexChanged);
            this.lboxTextSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lboxKeyDown);
            // 
            // CMStrip
            // 
            this.CMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공백제거ToolStripMenuItem,
            this.프로ToolStripMenuItem,
            this.모두삭제ToolStripMenuItem1,
            this.toolStripSeparator2,
            this.프로그램정보ToolStripMenuItem1});
            this.CMStrip.Name = "CMStrip";
            this.CMStrip.Size = new System.Drawing.Size(151, 98);
            // 
            // 공백제거ToolStripMenuItem
            // 
            this.공백제거ToolStripMenuItem.Name = "공백제거ToolStripMenuItem";
            this.공백제거ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.공백제거ToolStripMenuItem.Text = "공백제거";
            this.공백제거ToolStripMenuItem.Click += new System.EventHandler(this.공백제거ToolStripMenuItem_Click);
            // 
            // 프로ToolStripMenuItem
            // 
            this.프로ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem1,
            this.불러오기ToolStripMenuItem1});
            this.프로ToolStripMenuItem.Name = "프로ToolStripMenuItem";
            this.프로ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.프로ToolStripMenuItem.Text = "클립보드";
            // 
            // 저장하기ToolStripMenuItem1
            // 
            this.저장하기ToolStripMenuItem1.Name = "저장하기ToolStripMenuItem1";
            this.저장하기ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.저장하기ToolStripMenuItem1.Text = "저장하기";
            this.저장하기ToolStripMenuItem1.Click += new System.EventHandler(this.저장하기ToolStripMenuItem1_Click);
            // 
            // 불러오기ToolStripMenuItem1
            // 
            this.불러오기ToolStripMenuItem1.Name = "불러오기ToolStripMenuItem1";
            this.불러오기ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.불러오기ToolStripMenuItem1.Text = "불러오기";
            this.불러오기ToolStripMenuItem1.Click += new System.EventHandler(this.불러오기ToolStripMenuItem1_Click);
            // 
            // 모두삭제ToolStripMenuItem1
            // 
            this.모두삭제ToolStripMenuItem1.Name = "모두삭제ToolStripMenuItem1";
            this.모두삭제ToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.모두삭제ToolStripMenuItem1.Text = "모두삭제";
            this.모두삭제ToolStripMenuItem1.Click += new System.EventHandler(this.모두삭제ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // 프로그램정보ToolStripMenuItem1
            // 
            this.프로그램정보ToolStripMenuItem1.Name = "프로그램정보ToolStripMenuItem1";
            this.프로그램정보ToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.프로그램정보ToolStripMenuItem1.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem1.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem1_Click);
            // 
            // cboxactivation
            // 
            this.cboxactivation.AutoSize = true;
            this.cboxactivation.Checked = true;
            this.cboxactivation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxactivation.Location = new System.Drawing.Point(7, 11);
            this.cboxactivation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxactivation.Name = "cboxactivation";
            this.cboxactivation.Size = new System.Drawing.Size(80, 19);
            this.cboxactivation.TabIndex = 1;
            this.cboxactivation.Text = "Activation";
            this.cboxactivation.UseVisualStyleBackColor = true;
            this.cboxactivation.CheckedChanged += new System.EventHandler(this.cboxChange);
            // 
            // lblactivation
            // 
            this.lblactivation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblactivation.Location = new System.Drawing.Point(121, 11);
            this.lblactivation.Name = "lblactivation";
            this.lblactivation.Size = new System.Drawing.Size(174, 22);
            this.lblactivation.TabIndex = 5;
            this.lblactivation.Text = "활성화 상태(Ctrl + C 가능)";
            this.lblactivation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pLowPanel
            // 
            this.pLowPanel.Controls.Add(this.btnlbtextadd);
            this.pLowPanel.Controls.Add(this.txtlbtextadd);
            this.pLowPanel.Controls.Add(this.TBar);
            this.pLowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLowPanel.Location = new System.Drawing.Point(3, 198);
            this.pLowPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pLowPanel.Name = "pLowPanel";
            this.pLowPanel.Size = new System.Drawing.Size(297, 42);
            this.pLowPanel.TabIndex = 6;
            // 
            // btnlbtextadd
            // 
            this.btnlbtextadd.Location = new System.Drawing.Point(151, 6);
            this.btnlbtextadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlbtextadd.Name = "btnlbtextadd";
            this.btnlbtextadd.Size = new System.Drawing.Size(58, 26);
            this.btnlbtextadd.TabIndex = 3;
            this.btnlbtextadd.Text = "등록";
            this.btnlbtextadd.UseVisualStyleBackColor = true;
            this.btnlbtextadd.Click += new System.EventHandler(this.btn_AddClick);
            // 
            // txtlbtextadd
            // 
            this.txtlbtextadd.Location = new System.Drawing.Point(12, 6);
            this.txtlbtextadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlbtextadd.Name = "txtlbtextadd";
            this.txtlbtextadd.Size = new System.Drawing.Size(133, 23);
            this.txtlbtextadd.TabIndex = 2;
            this.txtlbtextadd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlbtextadd_KeyDown);
            // 
            // TBar
            // 
            this.TBar.Location = new System.Drawing.Point(228, -1);
            this.TBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBar.Minimum = 2;
            this.TBar.Name = "TBar";
            this.TBar.Size = new System.Drawing.Size(65, 45);
            this.TBar.TabIndex = 1;
            this.TBar.Value = 10;
            this.TBar.Scroll += new System.EventHandler(this.Scroll_Change);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.tableLayoutPanel1.Controls.Add(this.lboxTextSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pLowPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 244);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxactivation);
            this.panel1.Controls.Add(this.lblactivation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 42);
            this.panel1.TabIndex = 7;
            // 
            // MStrip
            // 
            this.MStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.도구ToolStripMenuItem,
            this.프로그램정보ToolStripMenuItem});
            this.MStrip.Location = new System.Drawing.Point(0, 0);
            this.MStrip.Name = "MStrip";
            this.MStrip.Size = new System.Drawing.Size(303, 30);
            this.MStrip.TabIndex = 6;
            this.MStrip.Text = "menuStrip1";
            this.MStrip.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem,
            this.불러오기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 26);
            this.fileToolStripMenuItem.Text = "파일";
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.저장하기ToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "종료";
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프ToolStripMenuItem,
            this.모두삭제ToolStripMenuItem});
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(43, 26);
            this.도구ToolStripMenuItem.Text = "편집";
            // 
            // 프ToolStripMenuItem
            // 
            this.프ToolStripMenuItem.Name = "프ToolStripMenuItem";
            this.프ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.프ToolStripMenuItem.Text = "공백제거";
            this.프ToolStripMenuItem.Click += new System.EventHandler(this.프ToolStripMenuItem_Click);
            // 
            // 모두삭제ToolStripMenuItem
            // 
            this.모두삭제ToolStripMenuItem.Name = "모두삭제ToolStripMenuItem";
            this.모두삭제ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.모두삭제ToolStripMenuItem.Text = "모두삭제";
            this.모두삭제ToolStripMenuItem.Click += new System.EventHandler(this.모두삭제ToolStripMenuItem_Click);
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 244);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MStrip);
            this.MainMenuStrip = this.MStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CMStrip.ResumeLayout(false);
            this.pLowPanel.ResumeLayout(false);
            this.pLowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MStrip.ResumeLayout(false);
            this.MStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxTextSave;
        private System.Windows.Forms.CheckBox cboxactivation;
        private System.Windows.Forms.Label lblactivation;
        private System.Windows.Forms.Panel pLowPanel;
        private System.Windows.Forms.Button btnlbtextadd;
        private System.Windows.Forms.TextBox txtlbtextadd;
        private System.Windows.Forms.TrackBar TBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip MStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMStrip;
        private System.Windows.Forms.ToolStripMenuItem 공백제거ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 모두삭제ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem1;
    }
}

