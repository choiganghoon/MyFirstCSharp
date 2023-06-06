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
    public partial class Chap12_IF_Test : Form
    {
        int btnCount = 0;
        public Chap12_IF_Test()
        {
            InitializeComponent();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            // 1. 입력 받을 값의 텍스트 박스에 입력한 값을 대상으로
            // 2와 5의 공배수 값인지 확인 후 메세지 박스로
            // "2, 5 공배수입니다." 혹은 "2, 5 공배수가 아닙니다"로 표현하고,
            // *입력 받은 값은 숫자만 입력할 수 있도록 밸리데이션 

            string sValue = txt1.Text;
            int iValue = 0;
            bool bFlag = false;
            // 밸리데이션 체크
            bFlag = int.TryParse(sValue, out iValue);
            if (!bFlag) 
            {
                MessageBox.Show("숫자만 입력하세요.");
                btnCount++;
                txt3.Text = btnCount.ToString();
                return;
            }
            if (iValue % 2 == 0 && iValue % 5 == 0)
            {
                MessageBox.Show("2, 5 공배수입니다.");
            }
            else 
            {
                MessageBox.Show("2, 5 공배수가 아닙니다.");
            }

            // 2.입력한 값이 8의 배수일 경우
            // 값과의 곱 텍스트 박스에 입력한 값에 8을 곱하여 표현
            if (iValue % 8 == 0)
            {
                string ssValue = "";
                iValue *= 8;
                ssValue = Convert.ToString(iValue);
                txt2.Text = ssValue;
            }

            // 3. 버튼을 클릭한 총 횟수 텍스트 박스에는 
            // 버튼 클릭 총 횟수를 숫자로 표현
            // * 버튼을 클릭한 총 횟수는 확인 및 검증 여부와는 관계없는 순수 총 클릭 횟수

            btnCount++;
            txt3.Text = btnCount.ToString();

        }


    }
    }
