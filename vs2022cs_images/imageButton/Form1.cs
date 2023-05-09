using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageButton
{ 

  public partial class Form1 : Form
  {

    public struct clpbf
    {
      public static PictureBox[] keyOf;
      public static PictureBox[] keyOn;
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


    public Form1()
    {
      InitializeComponent();


      btn_ini();

      key_ini();

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //image_split_save();

#if false
      // 버튼 생성
      Button button = new Button();
      button.Text = "Click Me";
      button.Location = new Point(50, 50);
      button.Click += new EventHandler(button_Click);
      // Form1에 버튼 추가
      this.Controls.Add(button);
#endif

      // 이미지 단추 생성
      CustomImageButton.ImageButton imageButton = new CustomImageButton.ImageButton();
      imageButton.Image_01 = (Bitmap)clpbf.keyOf[0].Image;
      imageButton.Image_02 = (Bitmap)clpbf.keyOn[0].Image;
      imageButton.Location = new Point(10, 10); // 위치 수정
      imageButton.MouseDown += new MouseEventHandler(key_MouseDown);
      // pictureBox1.Controls.Add(imageButton); // 삭제
      this.Controls.Add(imageButton); // 추가
    }

    private void button_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Button Clicked!");
    }

    private void image_split_save()
    {
      string path = System.IO.Path.GetDirectoryName( // 실행파일 경로
         System.Reflection.Assembly.GetExecutingAssembly().Location);
      Bitmap tmp, bmp = new Bitmap(pictureBox1.Image); // 그림선택

      int x, y = 0, n = 0; // 좌표 설정
      for (int i = 0; i < 4; i++)
      { // 세로 8회 반복
        x = 0; // 왼쪽 시작
        for (int j = 0; j < 10; j++)
        { // 가로 16회 반복
          tmp = bmp.Clone(new System.Drawing.Rectangle(x, y, 50, 50), // 그림크기
                        System.Drawing.Imaging.PixelFormat.Format24bppRgb);
          string str = "0x" + n.ToString("X2") + ".bmp"; // 파일이름 설정
          tmp.Save(path + "\\" + str, ImageFormat.Bmp); // xxx.bmp 파일로 저장
          x += 50; n++; // 36픽셀 오른쪽으로 이동 & 번호증가
        }
        y += 50; // 64픽셀 아래로 이동
      }
    }



    private void key_ini()
    { // 키보드 단추 초기화 함수
      int[] tbx = new int[] { 11, 10, 9, 9 }; // y 측 반복 갯수
      ccubf.keyOf = new CustomImageButton.ImageButton[40]; // 전체 메모리 할당
      int x = 190, tx = 190, y = 280, n = 0, w;
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
          ccubf.keyOf[n].MouseDown += // 마우스 다운 이벤트
              new System.Windows.Forms.MouseEventHandler(key_MouseDown);
          pictureBox1.Controls.Add(ccubf.keyOf[n]); x += 55; n++; // 우측으로 55픽셀 이동
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
      clpbf.keyOf = new PictureBox[40]; // 전체 메모리 할당
      bitmap = Properties.Resources.custom_key_off_b;
      for (int i = 0; i < 4; i++)
      {
        x = 0; // 세로 4회 반복
        for (int j = 0; j < 10; j++)
        { // 가로 10회 반복
          if (n == 38) w = 100; // for Enter button
          else w = 50; // plain button
          bitTmp = bitmap.Clone(new System.Drawing.Rectangle(x, y, w, 50),
            System.Drawing.Imaging.PixelFormat.Format24bppRgb);
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

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
  }
}
