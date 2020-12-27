
namespace workFrame.form
{
    partial class formData
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
            this.panelData = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataInput = new System.Windows.Forms.DataGridView();
            this.inIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataOutput = new System.Windows.Forms.DataGridView();
            this.outIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataFlag = new System.Windows.Forms.DataGridView();
            this.flagIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagOnOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelData.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInput)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFlag)).BeginInit();
            this.panelBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.tabControl);
            this.panelData.Location = new System.Drawing.Point(12, 12);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(523, 601);
            this.panelData.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(62, 30);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(523, 601);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " file Read ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(509, 557);
            this.dataGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "구분";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "주소";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "이름";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "비고";
            this.Column4.Name = "Column4";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " enum input ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataInput
            // 
            this.dataInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inIndex,
            this.inAddr,
            this.inDesc});
            this.dataInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataInput.Location = new System.Drawing.Point(3, 3);
            this.dataInput.Name = "dataInput";
            this.dataInput.RowTemplate.Height = 25;
            this.dataInput.Size = new System.Drawing.Size(509, 557);
            this.dataInput.TabIndex = 0;
            // 
            // inIndex
            // 
            this.inIndex.HeaderText = "Index";
            this.inIndex.Name = "inIndex";
            // 
            // inAddr
            // 
            this.inAddr.HeaderText = "Address";
            this.inAddr.Name = "inAddr";
            // 
            // inDesc
            // 
            this.inDesc.HeaderText = "Description";
            this.inDesc.Name = "inDesc";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataOutput);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(515, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " enum output ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataOutput
            // 
            this.dataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outIndex,
            this.outAddr,
            this.outDesc});
            this.dataOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOutput.Location = new System.Drawing.Point(3, 3);
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.RowTemplate.Height = 25;
            this.dataOutput.Size = new System.Drawing.Size(509, 557);
            this.dataOutput.TabIndex = 1;
            // 
            // outIndex
            // 
            this.outIndex.HeaderText = "Index";
            this.outIndex.Name = "outIndex";
            // 
            // outAddr
            // 
            this.outAddr.HeaderText = "Address";
            this.outAddr.Name = "outAddr";
            // 
            // outDesc
            // 
            this.outDesc.HeaderText = "Description";
            this.outDesc.Name = "outDesc";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataFlag);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(515, 563);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "enum flag";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataFlag
            // 
            this.dataFlag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFlag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flagIndex,
            this.flagAddr,
            this.flagOnOff,
            this.flagDesc});
            this.dataFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFlag.Location = new System.Drawing.Point(3, 3);
            this.dataFlag.Name = "dataFlag";
            this.dataFlag.RowTemplate.Height = 25;
            this.dataFlag.Size = new System.Drawing.Size(509, 557);
            this.dataFlag.TabIndex = 1;
            // 
            // flagIndex
            // 
            this.flagIndex.HeaderText = "Index";
            this.flagIndex.Name = "flagIndex";
            // 
            // flagAddr
            // 
            this.flagAddr.HeaderText = "Address";
            this.flagAddr.Name = "flagAddr";
            // 
            // flagOnOff
            // 
            this.flagOnOff.HeaderText = "Status";
            this.flagOnOff.Name = "flagOnOff";
            // 
            // flagDesc
            // 
            this.flagDesc.HeaderText = "Description";
            this.flagDesc.Name = "flagDesc";
            // 
            // panelBtns
            // 
            this.panelBtns.Controls.Add(this.button1);
            this.panelBtns.Controls.Add(this.button2);
            this.panelBtns.Location = new System.Drawing.Point(548, 12);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(210, 597);
            this.panelBtns.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Beige;
            this.button2.Location = new System.Drawing.Point(22, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 5);
            this.panel1.TabIndex = 4;
            // 
            // timer
            // 
            // 
            // formData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBtns);
            this.Controls.Add(this.panelData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formData";
            this.Text = "Manual";
            this.Load += new System.EventHandler(this.formData_Load);
            this.panelData.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataInput)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFlag)).EndInit();
            this.panelBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.Panel Bo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataInput;
        private System.Windows.Forms.DataGridView dataOutput;
        private System.Windows.Forms.DataGridView dataFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn inIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn inAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn inDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn outIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn outAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn outDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagOnOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDesc;
        private System.Windows.Forms.Timer timer;
    }
}

