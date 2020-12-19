using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exLambda
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 프로그램 진입점
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        Action _aStepCheck = null;  // 다음 step에 대한 내용을 표시해 줄 Text를 Action으로 선언

        /// <summary>
        /// Form이 Load 되는 시점에 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            _aStepCheck = () => lblStepCheck.Text = string.Format(" - 다음 Step은 {0}.{1}", iNowStep, ((enumLambdaCase)iNowStep).ToString());  // 람다식으로 등록
            _aStepCheck();  // 다음 Step을 표시하기 위해 Action을 호출

            ButtonColorChange();   // Button 색상을 변경 하는 예제
        }

        /// <summary>
        /// Form Load 시점에 Button Event를 등록 해줌
        /// </summary>
        private void ButtonColorChange()
        {
            // Button Event 함수에서 Button 색상 변경
            btnColorChange_1.Click += BtnColorChange_1_Click;


            // 무명 메서드를 사용해서 Button 색상 변경
            btnColorChange_2.Click += delegate (object sender, EventArgs e)
            {
                btnColorChange_2.BackColor = Color.Brown;
            };


            // 람다식을 사용해서 Button 색상 변경
            btnColorChange_3.Click += (sender, e) => btnColorChange_3.BackColor = Color.Coral;

        }

        /// <summary>
        /// Button Event 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnColorChange_1_Click(object sender, EventArgs e)
        {
            btnColorChange_1.BackColor = Color.Aqua;
        }


        int iNowStep = 0;
        delegate int delIntFunc(int a, int b);
        delegate string delStringFunc();

        /// <summary>
        /// Button Next를 Click 했을 경우 Case에 맞는 내용을 진행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            Lambda(iNowStep); // 람다식 예제를 Switch 형식으로 정리
            iNowStep++;
            _aStepCheck();    // 다음 Step을 표시하기 위해 Action을 호출
        }


        private void Lambda(int iCase)
        {
            switch (iCase)
            {
                case (int)enumLambdaCase.식형식_람다식:
                    // 식형식 람다식 
                    delIntFunc dint = (a, b) => a * b;
                    int iRet = dint(4, 5);
                    lboxResult.Items.Add(iRet.ToString());

                    delStringFunc dString = () => string.Format("Lambda Sample 식형식");
                    string strRet = dString();
                    lboxResult.Items.Add(strRet.ToString());

                    break;
                case (int)enumLambdaCase.문형식_람다식:
                    // 문형식 람다식
                    delStringFunc dstrSeqment = () =>
                    {
                        return string.Format("Lambda Sample 문형식");
                    };
                    string strSeqRet = dstrSeqment();
                    lboxResult.Items.Add(strSeqRet.ToString());

                    break;
                case (int)enumLambdaCase.제네릭_형태의_무명메서드_Func:
                    // 제네릭 형태의 무명 메서드
                    // Func : 반환 값이 있는 형태
                    Func<int, int, int> fInt = (a, b) => a * b;
                    int fIntRet = fInt(4, 5);
                    lboxResult.Items.Add(fIntRet.ToString());

                    break;
                case (int)enumLambdaCase.제네릭_형태의_무명메서드_Action:
                    // 제네릭 형태의 무명 메서드
                    // Action : 반환값이 없는 형태
                    Action<string, string> aString = (a, b) =>
                    {
                        string strText = String.Format("인자 값 {0}와 {1}을 받았습니다.", a, b);
                        lboxResult.Items.Add(strText.ToString());
                    };
                    aString("시간", "금");

                    break;
                case (int)enumLambdaCase.제네릭_형태의인자__반환_예제:
                    // 배열의 sum 함수의 경우 인자 값이 func<> 형태로 되어있음)

                    int[] iGroup = { 1, 3, 5, 7, 9 };
                    int iNumSum = iGroup.Sum(x => x);
                    lboxResult.Items.Add(iNumSum.ToString());

                    string[] strGroup = { "XXX", "TTTT", "YYY" };
                    int ilengthSum = strGroup.Sum(x => x.Length);
                    lboxResult.Items.Add(ilengthSum.ToString());

                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// case의 형태 진행 상태를 정리하기 위한 enum 정의
        /// </summary>
        enum enumLambdaCase
        {
            식형식_람다식 = 0,
            문형식_람다식 = 1,
            제네릭_형태의_무명메서드_Func = 2,
            제네릭_형태의_무명메서드_Action = 3,
            제네릭_형태의인자__반환_예제 = 4,
        }

    }
}
