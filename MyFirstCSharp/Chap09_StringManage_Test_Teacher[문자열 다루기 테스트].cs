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
    public partial class Chap09_StringManage_Test_T : Form
    {
        // 되돌리기 위한원본 문자열얼 지정 및 담을 변수
        // 클래스의 전역 변수, 클래스의 필드 멤버
        string sTitle;

        // 클래스가 객체화 될 때 실행되는 멤버(생성자 멤버)

        public Chap09_StringManage_Test_T()
        {
            // 클래스가 최초 호출 될 때 디자인을 세팅하는 함수
            InitializeComponent();
            sTitle = LbTitle.Text;
        }

        private void btnNameChange_Click(object sender, EventArgs e)
        {
            //1.
            LbTitle.Text = LbTitle.Text.Replace("OOO", "최강훈");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 2.
            MessageBox.Show($"S/W 글귀의 위치는 {LbTitle.Text.IndexOf("S/W")} 입니다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 3.
            string sTitle = LbTitle.Text;
            MessageBox.Show($"시작 문자 : {sTitle[0]} , 종료 문자 : {sTitle[sTitle.Length - 1]}");
        }

        private void Chap09_StringManage_Test_T_Load(object sender, EventArgs e)
        {
            // 4.
            LbTitle.Text = $"-DT-{LbTitle.Text} -DT-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 5.
            string sValue = "DIGITALTRANING";
            LbTitle.Text = LbTitle.Text.Replace(sValue,sValue.ToLower());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 6.
            LbTitle.Text = LbTitle.Text.Replace(" ", "");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 7.
            // sTitle에 있는 원본 문자열 LbTitle.Text 에 대입
            LbTitle.Text = sTitle;
           
        }
    }
}
