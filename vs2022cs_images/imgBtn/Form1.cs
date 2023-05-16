using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace imgBtn
{
  public partial class Form1 : Form
  {
    // CustomImageButton 클래스`
    public class CustomImageButton : PictureBox
    {
      public Bitmap Image_01 { get; set; }
      public Bitmap Image_02 { get; set; }

      public CustomImageButton()
      {
        this.MouseDown += new MouseEventHandler(key_MouseDown);
      }

      private void key_MouseDown(object sender, MouseEventArgs e)
      {
        string s = this.Name.Substring(3, 2);
        int b = Convert.ToByte(s);
        //staTxd.Text = " " + b.ToString();
      }


    }

    public struct clpbf
    {
      public static PictureBox[] keyOf;
      public static PictureBox[] keyOn;
    }

    public struct ccubf
    {
      public static CustomImageButton[] keyOf;
    }



    private readonly Panel panel1;

    public Form1()
    {
      InitializeComponent();

      // Panel 생성
      panel1 = new Panel();
      panel1.Location = new Point(10, 10);
      panel1.Size = new Size(800, 500);
      panel1.BackColor = SystemColors.Window;
      panel1.AutoScroll = true;
      this.Controls.Add(panel1);


      Bitmap bitmap, bitTmp;


      using (bitmap = Properties.Resources.radbtn_2ea_b)
      {
        // 첫번째 이미지 분리
        bitTmp = bitmap.Clone(new Rectangle(0, 0, 40, 40), PixelFormat.Format24bppRgb);
        // 각 이미지에 대해 이미지 버튼을 만듭니다.
        Button button1 = new Button();
        button1.Image = bitTmp;
        button1.Size = new System.Drawing.Size(40, 40);
        button1.Location = new Point(10, 10);
        button1.FlatStyle = FlatStyle.Standard;
        button1.BackColor = SystemColors.Window;
        button1.ForeColor = SystemColors.ControlText; // 텍스트 색상 변경
        panel1.Controls.Add(button1);

        //bitTmp.Dispose(); // bitTmp를 Dispose합니다.

        bitTmp = bitmap.Clone(new Rectangle(40, 0, 40, 40), PixelFormat.Format24bppRgb);
        Button button2 = new Button();
        button2.Image = bitTmp;
        button2.Size = new System.Drawing.Size(40, 40);
        button2.Location = new Point(100, 10);
        button2.FlatStyle = FlatStyle.Standard;
        button2.BackColor = System.Drawing.Color.Transparent;
        button2.ForeColor = SystemColors.ControlText; // 텍스트 색상 변경
        panel1.Controls.Add(button2);

        //bitTmp.Dispose(); // bitTmp를 Dispose합니다.
      }


      PictureBox picture_box = new PictureBox();
      picture_box.Image = bitTmp;
      picture_box.Size = new System.Drawing.Size(40, 40);
      picture_box.Location = new Point(10, 50);
      panel1.Controls.Add(picture_box);
      //Key_ini();


    }



    private void Key_ini()
    {
      string path = System.IO.Path.GetDirectoryName( // 실행파일 경로
         System.Reflection.Assembly.GetExecutingAssembly().Location);

      Bitmap bitmap, bitTmp;

      clpbf.keyOf = new PictureBox[1];
      clpbf.keyOn = new PictureBox[1];

      // 1X2 이미지 
      bitmap = Properties.Resources.radbtn_2ea_b;

      // 첫번째 이미지 분리
      bitTmp = bitmap.Clone(new Rectangle(0, 0, 40, 40), PixelFormat.Format24bppRgb);
      clpbf.keyOf[0] = new PictureBox();
      clpbf.keyOf[0].Image = Image.FromHbitmap(bitTmp.GetHbitmap());
      bitTmp.Save(path + "\\" + "0xOn.bmp", ImageFormat.Bmp);

      // 두번째 이미지 분리, 40px shift
      bitTmp = bitmap.Clone(new Rectangle(40, 0, 40, 40), PixelFormat.Format24bppRgb);
      clpbf.keyOn[0] = new PictureBox();
      clpbf.keyOn[0].Image = Image.FromHbitmap(bitTmp.GetHbitmap());
      bitTmp.Save(path + "\\" + "0xOff.bmp", ImageFormat.Bmp);
      ccubf.keyOf = new CustomImageButton[1];
      ccubf.keyOf[0] = new CustomImageButton();


      ccubf.keyOf[0].Location = new System.Drawing.Point(50, 50);
      ccubf.keyOf[0].Name = "key" + "00";
      ccubf.keyOf[0].Size = new System.Drawing.Size(40, 40);
      ccubf.keyOf[0].Image_01 = (Bitmap)clpbf.keyOf[0].Image;
      ccubf.keyOf[0].Image_02 = (Bitmap)clpbf.keyOn[0].Image;
      ccubf.keyOf[0].BackColor = Color.FromArgb(255, 255, 192);
      ccubf.keyOf[0].Cursor = Cursors.Hand;
      ccubf.keyOf[0].MouseDown += new System.Windows.Forms.MouseEventHandler(Key_MouseDown);
      ccubf.keyOf[0].MouseEnter += new EventHandler(Key_MouseEnter);
      ccubf.keyOf[0].MouseLeave += new EventHandler(Key_MouseLeave);
      panel1.Controls.Add(ccubf.keyOf[0]);



      //Button button[] = new Button();

    }

    private void Key_MouseEnter(object sender, EventArgs e)
    {
      ((CustomImageButton)sender).BackColor = Color.FromArgb(128, 128, 128);
    }

    private void Key_MouseLeave(object sender, EventArgs e) => ((CustomImageButton)sender).BackColor = Color.FromArgb(255, 255, 192);

    // key_MouseDown 메소드 내부에서 주석 처리된 코드 수정
    private void Key_MouseDown(object sender, MouseEventArgs e)
    {
      string s = (((CustomImageButton)sender).Name).Substring(3, 2);
      int b = Convert.ToByte(s);

      staTxd.Text = " " + b.ToString(); // 수정된 부분
    }
  }

}



#if false

 //  버튼 생성
      Button button = new Button();
      button.Text = "click me";
      button.Location = new Point(50, 50);
      //button.Click += new EventHandler(button_Click);

      // panel1 버튼 추가
      //panel1.Controls.Add(button);

     // btn_ini();



    private void btn_ini()
    {
      Bitmap bitmap, bitTmp;
      int x, y = 0, n = 0, w;
      clpbf.keyOf = new PictureBox[2];
      clpbf.keyOn = new PictureBox[2];
      bitmap = Properties.Resources.radbtn_2ea_b;

      bitTmp = bitmap.Clone(new Rectangle(0, 0, 40, 40), PixelFormat.Format24bppRgb);
      clpbf.keyOf[0] = new PictureBox();
      clpbf.keyOf[0].Image = Image.FromHbitmap(bitTmp.GetHbitmap());
      clpbf.keyOn[0] = new PictureBox();
      clpbf.keyOn[0].Image = Image.FromHbitmap(bitTmp.GetHbitmap());

      bitTmp = bitmap.Clone(new Rectangle(40, 0, 40, 40), PixelFormat.Format24bppRgb);
      clpbf.keyOf[1] = new PictureBox();
      clpbf.keyOf[1].Image = Image.FromHbitmap(bitTmp.GetHbitmap());
      clpbf.keyOn[1] = new PictureBox();
      clpbf.keyOn[1].Image = Image.FromHbitmap(bitTmp.GetHbitmap());

      if (panel1.Visible)
      {

      }
    }

#endif