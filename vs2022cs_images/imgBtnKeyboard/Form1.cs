using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgBtnKeyboard
{
  public partial class Form1 : Form
  {
    // CustomImageButton 클래스
    public class CustomImageButton : PictureBox
    {
      public Bitmap ImgOn { get; set; }
      public Bitmap ImgOff { get; set; }


      public CustomImageButton()
      {
        this.MouseDown += new MouseEventHandler(key_MouseDown);
        this.MouseUp += new MouseEventHandler(key_MouseUp);
        this.Image = ImgOn;
        this.BackColor = Color.Yellow; // 배경색을 투명하게 설정
      }

      private void key_MouseDown(object sender, MouseEventArgs e)
      {
        this.Image = ImgOn;
      }

      private void key_MouseUp(object sender, MouseEventArgs e)
      {
        this.Image = ImgOff;
      }
    }

    public Form1()
    {
      InitializeComponent();


      key_init();
    }



    private void key_init()
    {
      // 단추 초기화
      Bitmap bitmap, bitTmp; // 비트맵 변수 초기화
      int x, y = 0, n = 0, w; // 변수 초기화
      CustomImageButton[] ciBtn = new CustomImageButton[40];
      bitmap = Properties.Resources.custom_key_on_b;

      for (int i = 0; i < 4; i++)
      {
        x = 0; // 세로 4회 반복
        for (int j = 0; j < 10; j++)
        { // 가로 10회 반복
          if (n == 38) w = 100; // for Enter button
          else w = 50;          // plain button

          bitTmp = bitmap.Clone(new Rectangle(x, y, w, 50), PixelFormat.Format24bppRgb);
          ciBtn[n] = new CustomImageButton(); // 객체 생성
          ciBtn[n].ImgOn = bitTmp; // 이미지 할당
          ciBtn[n].Location = new Point(j * 50, i * 50); // 위치 지정
          this.Controls.Add(ciBtn[n]); // 폼에 추가
          n++; // 인덱스 증가
          x += 50; // 우측으로 50픽셀 이동
        }
        y += 50; // 아래로 50픽셀 이동
      }

    }
  }
}


#if false



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

      //btn_rad_init();


          private void btn_rad_init()
    {
      Bitmap bitmap = Properties.Resources.radbtn_2ea_b;
      if (bitmap == null) { return; }

      CustomImageButton ciBtn = new CustomImageButton();
      // 원본 이미지 분리
      Bitmap bitTmp = bitmap.Clone(new Rectangle(0, 0, 40, 40), PixelFormat.Format24bppRgb);
      ciBtn.ImgOn = bitTmp;

      bitTmp = bitmap.Clone(new Rectangle(40, 0, 40, 40), PixelFormat.Format24bppRgb);
      ciBtn.ImgOff = bitTmp;

      ciBtn.Location = new Point(10, 10);
      ciBtn.Size = new Size(40, 40);

      this.Controls.Add(ciBtn);
    }





public class CustomImageButton : PictureBox
    {
      public Bitmap ImgOn { get; set; }
      public Bitmap ImgOff { get; set; }


      public CustomImageButton()
      {
        this.MouseDown += new MouseEventHandler(key_MouseDown);
        this.MouseUp += new MouseEventHandler(key_MouseUp);
        this.BackColor = Color.Yellow; // 배경색을 투명하게 설정
      }

      private void key_MouseDown(object sender, MouseEventArgs e)
      {
          this.Image = ImgOn;        
      }

      private void key_MouseUp(object sender, MouseEventArgs e)
      {
          this.Image = ImgOff;        
      }
    }

    public Form1()
    {
      InitializeComponent();

      Bitmap bitmap = Properties.Resources.radbtn_2ea_b;
      if (bitmap == null) { return; }
      
      CustomImageButton ciBtn = new CustomImageButton();
      // 원본 이미지 분리
      Bitmap bitTmp = bitmap.Clone(new Rectangle(0, 0, 40, 40), PixelFormat.Format24bppRgb);
      ciBtn.ImgOn = bitTmp;

      bitTmp = bitmap.Clone(new Rectangle(40, 0, 40, 40), PixelFormat.Format24bppRgb);
      ciBtn.ImgOff = bitTmp;

      ciBtn.Location = new Point(10, 10);
      ciBtn.Size = new Size(40, 40);

      this.Controls.Add(ciBtn);
    }






























public class CustomImageButton : PictureBox
    {
      public Bitmap ImgOn { get; set; }
      public Bitmap ImgOff { get; set; }

      public Button Btn { get; set; }

      public CustomImageButton(Button button)
      {
        Btn = button;
        Btn.MouseDown += new MouseEventHandler(key_MouseDown);
        Btn.MouseUp += new MouseEventHandler(key_MouseUp);
        Btn.BackColor = Color.Yellow; // 배경색을 투명하게 설정
      }

      private void key_MouseDown(object sender, MouseEventArgs e)
      {
        if (Btn != null)
        {
          Btn.Image = ImgOn;
        }
      }

      private void key_MouseUp(object sender, MouseEventArgs e)
      {
        if (Btn != null)
        {
          Btn.Image = ImgOff;
        }
      }
    }








 {
        string path = System.IO.Path.GetDirectoryName( // 실행파일 경로
         System.Reflection.Assembly.GetExecutingAssembly().Location);


        if (bitmap == null) { return; }

        CustomImageButton ciBtn = new CustomImageButton();

        // 원본 이미지 분리
        Bitmap bitTmp = bitmap.Clone(new Rectangle(0, 0, 40, 40), PixelFormat.Format24bppRgb);
        ciBtn.ImgOn = bitTmp;
        //bitTmp.Save(path + "\\" + "0xOn.bmp", ImageFormat.Bmp);

        bitTmp = bitmap.Clone(new Rectangle(40, 0, 40, 40), PixelFormat.Format24bppRgb);
        ciBtn.ImgOff = bitTmp;
        //bitTmp.Save(path + "\\" + "0xOff.bmp", ImageFormat.Bmp);

        ciBtn.Location = new Point(10, 10);
        ciBtn.Size = new Size(40, 40);

        Button button1 = new Button();
        button1.Location = new Point(100, 10);
        button1.Size = new Size(40, 40);
        this.Controls.Add(button1);
        CustomImageButton.Btn = button1;

        this.Controls.Add(ciBtn);
      }
#endif