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
    public partial class Chap12_IF_Test_T : Form
    {
        int iButtonClickCont = 0;
        public Chap12_IF_Test_T()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            // 3. 버튼을 총 클릭한 횟수
            ++iButtonClickCont;
            txtBtnClickCount.Text = iButtonClickCont.ToString();

            // 변수 지정
            string sValue = txtInputValue.Text;
            int iValue = 0;
            bool bCheck = false;

            // 밸리데이션 체크
            bCheck = int.TryParse(sValue, out iValue);
            if (!bCheck) 
            {
                MessageBox.Show(" 숫자만 입력하세요.");
                return;
            }

            // 1번
            // 메세지 박스를 한 번만 나오게??
            string sMessage = string.Empty; // 분기에 따른 메세지 변수
            if (iValue % 2 == 0 && iValue % 5 == 0)
            {
                sMessage = ("2, 5의 공배수입니다.");
            }
            else
            {
                sMessage = ("2, 5의 공배수가 아닙니다.");
            }
            MessageBox.Show(sMessage);

            // 2번
            if (iValue % 8 == 0)
            {
                txtEMultiValue.Text = Convert.ToString(iValue * 8);
            }
            else
            {
                txtEMultiValue.Text = "";
            }


        }
    }
    }
