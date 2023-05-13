namespace imgBtn
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
      this.staTxd = new System.Windows.Forms.TextBox();
      this.btn1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // staTxd
      // 
      this.staTxd.Location = new System.Drawing.Point(835, 12);
      this.staTxd.Name = "staTxd";
      this.staTxd.Size = new System.Drawing.Size(56, 21);
      this.staTxd.TabIndex = 0;
      // 
      // btn1
      // 
      this.btn1.BackColor = System.Drawing.Color.Transparent;
      this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn1.ForeColor = System.Drawing.Color.Transparent;
      this.btn1.Location = new System.Drawing.Point(835, 54);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(56, 45);
      this.btn1.TabIndex = 1;
      this.btn1.Text = "button1";
      this.btn1.UseVisualStyleBackColor = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(903, 532);
      this.Controls.Add(this.btn1);
      this.Controls.Add(this.staTxd);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox staTxd;
    private System.Windows.Forms.Button btn1;
  }
}

