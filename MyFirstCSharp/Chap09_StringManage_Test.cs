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
    public partial class Chap09_StringManage_Test : Form
    {
        public Chap09_StringManage_Test()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // 1. OOO -> 본인 이름으로 변경 *라벨 Text에 직접 표현
            LbTitle.Text = LbTitle.Text.Replace("OOO", "최강훈");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // 2. "S/W" 의 위치 찾고 메세지박스 *구현은  in Line으로

            MessageBox.Show($"S/W의 위치는 {LbTitle.Text.IndexOf("S/W")}");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // 3. 시작 단어와 마지막 단어 각각 1자씩 메세지로 표현
            MessageBox.Show($"시작 단어: {LbTitle.Text[0]} 마지막 단어: {LbTitle.Text[LbTitle.Text.Length - 1]}");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // 4. 타이틀 문자열의 앞, "-DT-" 문자열 삽입 *라벨 Text에 직접 표현

            LbTitle.Text = LbTitle.Text.Insert(0, "-DT-");
            LbTitle.Text = LbTitle.Text.Insert(LbTitle.Text.Length, "-DT-");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // 5. DIGITALTRAING만 소문자로 변경 *DIGITALTRAING 문자는 고정 *라벨 Text에 직접 표현

            LbTitle.Text = LbTitle.Text.Replace("DIGITALTRANING","digitaltraning");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // 6. 타이틀 문자열의 모든 공백 *라벨 Text에 직접 표현
            LbTitle.Text = LbTitle.Text.Replace(" ", "");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // 7. 원본 문자열 되돌리기
        }
    }
}
