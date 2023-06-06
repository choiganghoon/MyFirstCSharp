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
    public partial class Chap10_NullManage : Form
    {
        public Chap10_NullManage()
        {
            InitializeComponent();
        }

        private void btnHasValue_Click(object sender, EventArgs e)
        {
            // HasValue : 데이터의 값이 Null 인지 판단하는 기능
            int? iValue = null; // 정수형 데이터 타입에 null 처리

            // 값이 있을 경우 true / null 일 경우 false
            bool bFlag = iValue.HasValue;

            MessageBox.Show(bFlag.ToString());

            // 문자열의 null 처리 여부 판단
            string sValue = null;
            // bFlag = sValue.HasValue
            // 문자 열의 경우 null 상태를 허용하는 데이터 타입이므로
            // 굳이 null 상태인지 체크하는 기능이 필요없다.
        }

        private void btnNullable_Click(object sender, EventArgs e)
        {
            // Null 병합 연산자 '??' ? -> 엘비스 기호(안중요)
            // 데이터 타입의 유형이 null처리 된 상태인지 판단하는 키워드

            // A ?? B : 만약에 A가 null 상태이면 B를 표현하고, null상태가 아니면 A를 그대로 표현

            int? iValue = null;

            // iValue가 null이면 -1, 아니면 iValue를 iResult에 대입
            int iResult = iValue ?? -1;

            MessageBox.Show(iResult.ToString());

            // string 타입에 null 값 여부 판단
            string sValue = null;
            MessageBox.Show(sValue ?? "변수가 null 상태 입니다.");
        }
    }
}
