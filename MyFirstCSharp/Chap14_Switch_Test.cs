using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap14_Switch_Test : Form
    {
        // 1. 사과는 2000원 고정, 참외는 2500원, 수박은 18000원 고정
        string AValue;
        string MValue;
        string WValue;
        int ACount = 0;
        int MCount = 0;
        int WCount = 0;
        public Chap14_Switch_Test()
        {
            InitializeComponent();
            AValue = lblApple.Text;
            MValue = lblMelon.Text;
            WValue = lblWM.Text;
        }

        private void btnApplelOrder_Click(object sender, EventArgs e)
        {
            // 2. 사과, 참외, 수박 주문 버튼을 클릭할 경우
            // - 각 과일의 금액은 총 누적 결제 금액으로 합산
            // - 각 과일의 재고 수량은 - 1씩 차감 된다
            // - 재고는 0개 이하로 떨어질 수 없다
            // - 재고가 0개인 과일을 주문 버튼 클릭 시 "주문 할 수 없습니다." 밸리데이션



            // - 각 과일의 재고 수량은 - 1씩 차감 된다
            string sAValue = lblAppleCnt.Text;
            int ACValue = 0;
            int.TryParse(sAValue, out ACValue);
            --ACValue;
            lblAppleCnt.Text = Convert.ToString(ACValue);

            // - 재고는 0개 이하로 떨어질 수 없다
            if(lblAppleCnt.Text == "-1")
            {
                lblAppleCnt.Text = "0";
            }

            // - 재고가 0개인 과일을 주문 버튼 클릭 시 "주문 할 수 없습니다." 밸리데이션
            bool bFlag = false;
            bFlag = (lblAppleCnt.Text == "0");
            if(bFlag)
            {
                MessageBox.Show("주문 할 수 없습니다.");
                return;
            }

            // -각 과일의 금액은 총 누적 결제 금액으로 합산
            ++ACount;
        }

        private void btnMelonOrder_Click(object sender, EventArgs e)
        {
            string sMValue = lblMelonCnt.Text;
            int MCValue = 0;
            int.TryParse(sMValue, out MCValue);
            --MCValue;
            lblMelonCnt.Text = Convert.ToString(MCValue);

            if (lblMelonCnt.Text == "-1")
            {
                lblMelonCnt.Text = "0";
            }

            bool bFlag = false;
            bFlag = (lblMelonCnt.Text == "0");
            if (bFlag)
            {
                MessageBox.Show("주문 할 수 없습니다.");
                return;
            }

            ++MCount;
        }



        private void btnWMOrder_Click(object sender, EventArgs e)
        {
            string sWValue = lblWMCnt.Text;
            int WCValue = 0;
            int.TryParse(sWValue, out WCValue);
            --WCValue;
            lblWMCnt.Text = Convert.ToString(WCValue);

            if (lblWMCnt.Text == "-1")
            {
                lblWMCnt.Text = "0";
            }

            bool bFlag = false;
            bFlag = (lblWMCnt.Text == "0");
            if (bFlag)
            {
                MessageBox.Show("주문 할 수 없습니다.");
                return;
            }

            ++WCount;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            // -각 과일의 금액은 총 누적 결제 금액으로 합산
            MessageBox.Show($"총 누적 결제 금액: {(ACount*2000) + (MCount*2500) + (WCount*18000)}");
        }
    }
}
