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
    public partial class Chap04_DataType_ConvTest : Form
    {
        public Chap04_DataType_ConvTest()
        {
            InitializeComponent();
        }


        private void btnSum_Click(object sender, EventArgs e)
        {
            // 텍스트 박스두 수의 합 구해서 메세지로 표현

            // 1. 텍스트 박스에 입력되어 있는 값을 가져오기

            // 왼쪽 텍스트 박스에 있는 값을 변수에 저장
            string sFirstValue;
            sFirstValue = txtFirtValue.Text;

            // 오른쪽 텍스트 박스에 있는 값을 변수에 저장
            string sSecondValue;
            sSecondValue = txtSecValue.Text;

            // 2. 두 수를 합치는 로직

            // 왼쪽 텍스트 박스의 값을 정수로 담은 int 변수 만들기
            int iFirstValue = 0;
            int.TryParse(sFirstValue, out iFirstValue);

            // 왼쪽 텍스트 박스의 값을 정수로 담은 int 변수 만들기
            int iSecondValue = 0;
            int.TryParse(sSecondValue, out iSecondValue);

            // 3. 두 수 더하기
            int iResult = 0; // 더하기의 결과를 담을 변수
            iResult = iFirstValue + iSecondValue;

            // 4. 더하기 결과 표현하기
            // MessageBox.Show(iResult); // Show는 문자열이 들어가야해서 오류

            string sResult; // 더하기 값을 문자로 담을 변수
            sResult = Convert.ToString(iResult);
            MessageBox.Show(sResult);

            // 4의 내용은 아래의 한줄로 표현할 수 있음
            // MessageBox.Show(Convert.ToString(sResult));
        }
    }
}
