using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class chap07_StringFind : Form
    {
        public chap07_StringFind()
        {
            InitializeComponent();
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // Index Of(): 문자열 내에서 찾고자 하는 문자 위치 찾기

            // 타이틀 변수에 담기
            string sTitle = lbTitle.Text;

            // 사용자가 입력한 문자열 변수에 담기
            string sValue = txtIndexOf.Text;

            // 사용자가 지정한 문자 열의 위치 찾아 담을 변수
            int iIndex = 0;
            iIndex = sTitle.IndexOf(sValue);

            MessageBox.Show(sValue + " 가 있는 위치는 " + iIndex + " 입니다.");

            // 암시적 형변환
            // 데이터 타입을 명시하지 않아도 데이터 타입이 큰 유형으로 자동 변환
            // 컴파일러가 컴파일 시 자동으로 변환해 주는 타입
        }

        private void btbLastIndex_Click(object sender, EventArgs e)
        {
            // Last Index Of: 문자열의 뒤에서 찾아 몇 번째 인덱스에 있는지 리턴
            
            string sTitle = lbTitle.Text;  
            string sValue = txtLastIndexOf.Text;

            int iLastIndex = 0;
            iLastIndex = sTitle.LastIndexOf(sValue);

            MessageBox.Show(sValue + " 가 있는 위치는 " + iLastIndex + " 입니다.");

            // LastIndexOf 는 뒤쪽에서 가장 처음 찾은 문자의 위치 정보를 반환
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            // StartsWirh: 해당 문자열로 시작 하는지 판단

            string sTitle = lbTitle.Text;
            string sValue = txtStartWith.Text;

            bool bFlag = sTitle.StartsWith(sValue); // 플래그는 개발자들이 bool 쓸 때 많이 사용

            MessageBox.Show("판단 결과 : " + bFlag + " 입니다.");
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            // EndsWith: 문자열이 지정한 문자로 끝나는지 판단

            //string sTitle = lbTitle.Text;
            //string sValue = txtEndWith.Text;

            //bool bFlag = sTitle.EndsWith(sValue);

            //MessageBox.Show("판단 결과 : " + bFlag + " 입니다.");

            // 위 로직을 아래 처럼 한줄로 줄일 수 있음
            // 변수를 재사용 할 가능성이 있다면 위에처럼 변수에 저장하고 쓰는게 좋음
            // 재사용 안한다면 변수에 저장 안하고 바로 바로 쓰는게 좋음
            MessageBox.Show("판단 결과 : " + lbTitle.Text.EndsWith(txtEndWith.Text) + " 입니다.");


        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            // Contains(): 지정한 문자열을 포함하고 있는지 결과를 반환

            string sTitle = lbTitle.Text;
            string sValue = txtContains.Text;

            // 문자열을 포함하고 있는지 판단
            bool bFlag = sTitle.Contains(sValue);

            MessageBox.Show("판단 결과 : " + bFlag + " 입니다.");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // 문자열을 원하는 문자열로 치환
            string sTitle = lbTitle.Text;

            // 변경 전 사용자가 입력한 문자열 받아오기
            string sBeforeWord = txtBefore.Text;
            
            // 변경 후 문자열 받아오기
            string sAfterWord = txtAfter.Text;

            // 변경을 완료 후 문자열이 담길 변수
            string sResult = sTitle.Replace(sBeforeWord, sAfterWord);

            MessageBox.Show(sResult);

        }
    }
}
