using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap16_Loop_For : Form
    {
        public Chap16_Loop_For()
        {
            InitializeComponent();
        }

        private void btnForSum_Click(object sender, EventArgs e)
        {
            // 1부터 100까지 합하는 로직

            // 1. 누적 갑싱 저장되는 변수
            int iSumValue = 0;

            // 1부터 100까지 반복
            // i : 반복 하면서 조건을 만족 시킬 변수
            //     반복문을 종료 할 수 있는 변수
            // int i = 0   = int 형 변수 i가 0이라는 값을 가지고 시작
            // ; i <= 100  = 참인 조건 인지 판단하는 구문
            // ; i++       = 후위 증가 연산자
            //               다음 조건을 비교하기 위하여 증가 하는 구문
            for (int i = 0; i <= 100; i++)
            {
                iSumValue += i;
            }
            MessageBox.Show(iSumValue.ToString());
        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            // 1. 임의의 배열의 값 등록(배열에 포함된 데이터의 갯수 및 값을 모른다고 가정)
            int[] iValues = { 10, 20, 30, 40, 50, 50, 20 };
            //                 0,  1,  2,  3,  4,  5,  6

            // 2. for 문을 통하여 iValues 배열에 있는 모든 값을 더하기

            int iSumValue = 0; // 배열의 모든 값을 더해서 누적 시킬 변수

            // int i : 배열의 주소 값으로 사용될 i
            for (int i = 0; i < iValues.Length; i++)
            {
                if (iValues[i] >= 40)
                {
                    if (iValues[i] == 50)
                    {
                        break;
                    }
                    continue;
                }
                iSumValue += iValues[i];
            }
            MessageBox.Show(iSumValue.ToString()); // 60

        }

        private void btnGUGU_Click(object sender, EventArgs e)
        {
            // 구구단 만들기
            string sResult = "";
            for (int i = 2; i < 100; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    sResult += $"{i} * {j} = {i * j}\r\n";
                }
            }
            txtGUGU.Text = sResult;
        }

        private void btnIm_Click(object sender, EventArgs e)
        {
            // 값형식의 타입
            // Immuatable Type (string)과 Mutable Type(int)
            // Immuatable 타입은 저장되는 번지수만 늘어나서 데이터가 증가하는 방식
            //2 * 1 = 2   //2 * 1 = 2  //2 * 1 = 2
            //2 * 2 = 4  //2 * 2 = 4
            //2 * 3 = 6 
            // 데이터가 누적 될 때 불필요한 메모리 공간이 많이 소비되므로 비효율적인 코딩이 될 수 있다
            // StringBuilder를 사용할 것을 권장

            StringBuilder sBuilder = new StringBuilder();
            // 123...100
            for (int i = 1; i <= 100; i++)
            {
                sBuilder.Append(i.ToString());
            }
            MessageBox.Show(sBuilder.ToString());
            // sBuilder.Clear(); // 내용 삭제


        }
    }
}
