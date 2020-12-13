using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exDelegateUse
{
    public partial class Form1 : Form
    {
        public delegate int delFuncDow_Edge(int i);
        public delegate int delFuncTopping(string strOrder, int Ea);
        
        public delegate T delFunc<T>(T i);  // 함수 명 뒤에 <일반화 변수명 - 형식 매개 변수> 을 사용 할 경우 일반화 함수를 지정 할수 있음 (인자 값 Type에 신경 쓰지 않는 형태)
        public delegate A delTest<A>(A i);  // 문자 종류는 상관 없음 일반화 함수를 Delegate에도 적용할 수 있다는 점 (확장개념 일반화 delegate를 delegate의 특징이라고 보기는 어렵지 않을지)

        public delegate object delFuncO(object i); // var, object
        
        int _iTotalPrice = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 주문하기 Button을 Click 했을 때 발생 하는 Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dPizzaOrder = new Dictionary<string, int>();  // Pizza 주문을 담을 그릇 (Key : 주문 종류, value : 개수)

            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);

            delFuncTopping delTopping = null;


            int iDowOrder = 0;
            int iEdgeOrder = 0;

            // 선택 도우 확인
            if (rdoDow1.Checked)
            {
                iDowOrder = 1;
                dPizzaOrder.Add("오리지널", 1);
            }
            else if (rdoDow2.Checked)
            {
                iDowOrder = 2;
                dPizzaOrder.Add("씬", 1);
            }

            //delDow(iDowOrder);

            // 선택 엣지 확인
            if (rdoEdge1.Checked)
            {
                iEdgeOrder = 1;
                dPizzaOrder.Add("리치골드", 1);
            }
            else if (rdoEdge2.Checked)
            {
                iEdgeOrder = 2;
                dPizzaOrder.Add("치즈크러스터", 1);
            }

            //delEdge(iEdgeOrder);

            fCallBackDelegate(iDowOrder, delDow);
            fCallBackDelegate(iEdgeOrder, delEdge);


            // 토핑 선택 확인
            if (cboxTopping1.Checked)
            {
                //delTopping = new delFuncTopping(fTopping1);
                delTopping += fTopping1;
                dPizzaOrder.Add("소세지", (int)numEa.Value);
            }

            if (cboxTopping2.Checked)
            {
                delTopping += fTopping2;
                dPizzaOrder.Add("감자", (int)numEa.Value);
            }

            if (cboxTopping3.Checked)
            {
                delTopping += fTopping3;
                dPizzaOrder.Add("치즈", (int)numEa.Value);
            }

            delTopping("토핑", (int)numEa.Value);

            flboxOrderRed("----------------------------------");
            flboxOrderRed(string.Format("전체 주문 가격은 {0}원 입니다.", _iTotalPrice));


            frmLoadling(dPizzaOrder);
        }
        

        #region Function

        /// <summary>
        /// O : 선택안함, 1 : 오리지널, 2 : 씬
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("도우는 오리지널을 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우는 씬을 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else
            {
                strOrder = "도우를 선택하지 않았습니다.";
            }

            flboxOrderRed(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }

        /// <summary>
        /// O : 선택안함, 1 : 리치골드, 2 : 치즈크러스터
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("엣지는 리치골드를 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("엣지는 치즈크러스터를 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else
            {
                strOrder = "엣지는 선택하지 않았습니다.";
            }

            flboxOrderRed(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }

        public int fCallBackDelegate(int i, delFuncDow_Edge dFunction)
        {
            return dFunction(i);
        }


        private int fTopping1(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 500;

            strOrder = string.Format("소세지 {0} {1} 개를 선택 하였습니다. : ({2}원 (1ea 500원)", Order, iEa, iPrice);

            flboxOrderRed(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }

        private int fTopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 200;

            strOrder = string.Format("감자 {0} {1} 개를 선택 하였습니다. : ({2}원 (1ea 200원)", Order, iEa, iPrice);

            flboxOrderRed(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }

        private int fTopping3(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 300;

            strOrder = string.Format("치즈 {0} {1} 개를 선택 하였습니다. : ({2}원 (1ea 300원)", Order, iEa, iPrice);

            flboxOrderRed(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }


        private void flboxOrderRed(string strOrder)
        {
            lboxOrder.Items.Add(strOrder);
        }

        #endregion

        #region event 예제 

        frmPizza fPizza;

        /// <summary>
        /// 자식 form을 호출 하는 Logic (함수로 만들어 놓음)
        /// </summary>
        /// <param name="dPizzaOrder"></param>
        private void frmLoadling(Dictionary<string, int> dPizzaOrder)
        {
            if (fPizza != null)
            {
                fPizza.Dispose();
                fPizza = null;
            }

            fPizza = new frmPizza();
            fPizza.eventdelPizzaComplete += FPizza_eventdelPizzaComplete;
            fPizza.Show();


            fPizza.fPizzrCheck(dPizzaOrder);


            // Timer로 자식 Form의 진행 상황을 체크 하기 위한 Logic 1

            //_timer = new Timer();
            //_timer.Interval = 1000;
            //_timer.Tick += _timer_Tick;
            //_timer.Start();

        }

        // Timer로 자식 Form의 진행 상황을 체크 하기 위한 Logic 2

        //Timer _timer;
        //private void _timer_Tick(object sender, EventArgs e)
        //{
        //    if (fPizza.BOrderComplete)
        //    {
        //        flboxOrderRed("주문 완료 확인");
        //    }
        //}


        /// <summary>
        /// 자식 form에 대한 delegate event 함수 호출
        /// </summary>
        /// <param name="strResult"></param>
        /// <param name="iTime"></param>
        /// <returns></returns>
        private int FPizza_eventdelPizzaComplete(string strResult, int iTime)
        {
            flboxOrderRed("----------------------------------");
            flboxOrderRed(string.Format("{0} / 걸린 시간 : {1}", strResult, iTime));

            // 결과 값을 자식 form으로 return 해주기 위해 사용
            // 시간 계산을 해서 5분이 넘어 가면 -1
            if (iTime > 4000)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        #endregion


    }
}
