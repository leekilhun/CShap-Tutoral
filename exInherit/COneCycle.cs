using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace exInherit
{
    /// <summary>
    /// CBase를 상속 받은 외발 자전거 클래스
    /// </summary>
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1;  // 바퀴1
        public Rectangle _rtSquare1;  // 몸통1

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="sName"></param>
        public COneCycle(string sName)
        {
            strName = sName;  // 클래스를 생성 할 때 이름을 가져와서 strName에 넣어 줌
            _Pen = new Pen(Color.WhiteSmoke, 3);  // 펜에 대한 색상과 굵기를 설정

            _rtCircle1 = new Rectangle(120, 150, 120, 120);  // 바퀴1에 대한 위치 및 크기를 설정
            _rtSquare1 = new Rectangle(150, 30, 60, 120);  // 몸통1에 대한 위치 및 크기를 설정
        }

        /// <summary>
        /// 설정 되어 있는 Pen에 대한 정보를 반환
        /// </summary>
        /// <returns></returns>
        public Pen fPenInfo()
        {
            //_Pen = new Pen(Color.White, 3);
            return _Pen;
        }

        /// <summary>
        /// 외부에서 그림의 위치를 이동시키는 함수를 호출
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSquare1Move(iMove);
        }

        /// <summary>
        /// 바퀴1의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle1Move(int iMove)
        {
            Point oPoint = _rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle1.Location = oPoint;
        }

        /// <summary>
        /// 몸통1의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fSquare1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare1.Location = oPoint;
        }
    }
}
