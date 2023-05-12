using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_btn
{
  public partial class Form1 : Form
  {
    public struct clpbf
    {
      public static PictureBox[] keyOf = new PictureBox[40];
      public static PictureBox[] keyOn = new PictureBox[40];
    }

    // CustomImageButton 클래스
    public class CustomImageButton
    {
      public class ImageButton : PictureBox
      {
        public Bitmap Image_01 { get; set; }
        public Bitmap Image_02 { get; set; }

        public ImageButton()
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
    }

    public struct ccubf
    {
      public static CustomImageButton.ImageButton[] keyOf; // 일반 이미지 버튼 배열
    }

    private System.Windows.Forms.Panel panel1;

    public Form1()
    {
      InitializeComponent();

      // Panel 생성
      panel1 = new Panel();
      panel1.Location = new Point(10, 10); // 위치 지정
      panel1.Size = new Size(800, 600); // 크기 지정
      panel1.AutoScroll = true; // 스크롤 기능 활성화
      this.Controls.Add(panel1); // Form1에 Panel 추가

      btn_ini();

      key_ini();
    }

    private void button_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Button Clicked!");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Button button = new Button();
      button.Text = "click me";
      button.Location = new Point(50, 50);
      button.Click += new EventHandler(button_Click);
      // Form1에 버튼 추가
      this.Controls.Add(button);
    }


    private void key_ini()
    {
      int[] tbx = new int[] { 11, 10, 9, 9 }; // y 측 반복 갯수
      ccubf.keyOf = new CustomImageButton.ImageButton[40]; // 전체 메모리 할당
      int x = 0, tx = 0, y = 0, n = 0, w;
      for (int i = 0; i < 4; i++)
      { // 아래로 4회 반복
        for (int j = 0; j < tbx[i]; j++)
        { // 우측으로 n회 반복
          if (n == 38) w = 100; // for Enter button
          else w = 50; // plain button
          ccubf.keyOf[n] = new CustomImageButton.ImageButton(); // 개별 메모리 할당
          ccubf.keyOf[n].Location = new System.Drawing.Point(x, y);
          ccubf.keyOf[n].Name = "key" + n.ToString("00"); // "key00"
          ccubf.keyOf[n].Size = new System.Drawing.Size(w, 50); // sizing
          ccubf.keyOf[n].Image_01 = (Bitmap)clpbf.keyOf[n].Image; // normal picture
          ccubf.keyOf[n].Image_02 = (Bitmap)clpbf.keyOn[n].Image; // picture on click


          ccubf.keyOf[n].Image_01 = Properties.Resources.custom_key_off_b.Clone(new Rectangle(x, y, w, 50), PixelFormat.Format24bppRgb);
          ccubf.keyOf[n].Image_02 = Properties.Resources.custom_key_on_b.Clone(new Rectangle(x, y, w, 50), PixelFormat.Format24bppRgb);

          ccubf.keyOf[n].MouseDown += // 마우스 다운 이벤트
          new System.Windows.Forms.MouseEventHandler(key_MouseDown);
          panel1.Controls.Add(ccubf.keyOf[n]); x += 55; n++; // 우측으로 55픽셀 이동
        }
        tx += 25; x = tx; y += 55; // 아래로 55픽셀 이동
      }


    }

    private void key_MouseDown(object sender, MouseEventArgs e)
    { // 마우스 다운
      string s = (((CustomImageButton.ImageButton)sender).Name).Substring(3, 2); //"key00"
      int b = Convert.ToByte(s); // change to number

      //staTxd.Text = " " + b.ToString(); // button number
    }




    public void btn_ini()
    {

      // 단추 초기화
      Bitmap bitmap, bitTmp; // 비트맵 변수 초기화
      int x, y = 0, n = 0, w; // 변수 초기화
      clpbf.keyOf = new PictureBox[2]; // 전체 메모리 할당
      bitmap = Properties.Resources.custom_key_off_b;
      for (int i = 0; i < 4; i++)
      {
        x = 0; // 세로 4회 반복
        for (int j = 0; j < 10; j++)
        { // 가로 10회 반복
          if (n == 38) w = 100; // for Enter button
          else w = 50; // plain button
          bitTmp = bitmap.Clone(new System.Drawing.Rectangle(x, y, w, 50),System.Drawing.Imaging.PixelFormat.Format24bppRgb);
          clpbf.keyOf[n] = new PictureBox(); // 개별 메모리 할당
          clpbf.keyOf[n].Image = Image.FromHbitmap(bitTmp.GetHbitmap());
          x += 50; n++; // 우측으로 50픽셀 이동
        }
        y += 50; // 아래로 50픽셀 이동
      }
      y = 0; n = 0;
      clpbf.keyOn = new PictureBox[44]; // 전체 메모리 할당
      bitmap = Properties.Resources.custom_key_off_b;
      for (int i = 0; i < 4; i++)
      {
        x = 0; // 세로 4ea
        for (int j = 0; j < 10; j++)
        { // 가로 10ea
          if (n == 38) w = 100; // for Enter button
          else w = 50; // plain button
          bitTmp = bitmap.Clone(new System.Drawing.Rectangle(x, y, w, 50),
            System.Drawing.Imaging.PixelFormat.Format24bppRgb);
          clpbf.keyOn[n] = new PictureBox(); // 개별 메모리 할당
          clpbf.keyOn[n++].Image = Image.FromHbitmap(bitTmp.GetHbitmap()); // 이미지복사
          x += 50; // 우측으로 50픽셀 이동
        }
        y += 50; // 아래로 50픽셀 이동
      }

    }
  }
}
