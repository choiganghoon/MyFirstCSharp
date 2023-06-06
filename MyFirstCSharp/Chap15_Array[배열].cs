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
    public partial class Chap15_Array : Form
    {
        // 배열 (참조형식, 배열의 이름은 STack에 값은 Heap 저장)
        // -- 같은 데이터 타입의 여러 데이터가 하나의 배열
        // 변수 이름으로 나열된 데이터 형식

        // - C#에서 배열은 반드시 방의 개수를 지정 하여 생성하거나 (EX. new int[5])
        // 배열에 나열될 값들의 개수가 명시 되어야 한다 (EX. Split('/'))
        public Chap15_Array()
        {
            InitializeComponent();
        }

        private void btnArrayF_Click(object sender, EventArgs e)
        {
            // 1. 여러가지 배열의 초기화(배열을 생성하고 값을 대입)

            // 배열의 방의 개수를 지정하여 생성
            int[] iValues = new int[6];

            // 배열의 방의 개수와 값을 바로 등록
            int[] iValues2 = new int[3] {0, 1, 2};

            // 배열의 개수 지정 없이 값을 바로 등록
            int[] iValues3 = new int[] {10, 20, 30};

            // new int[] 키워드 없이 값을 바로 등록
            int[] iValues4 = {10, 20, 30};

            // 반환 형태가 배열인 기능(메서드)를 이용하여 배열을 등록
            string[] sValues = "ABCDE-FGHI".Split('-');

            // 기존에 생성되어 있는 배열의 방 갯수 만큼 빈 새로운 배열 만들기
            string[] sValues5 = new string[sValues.Length];



            // 2. C#에서 배열을 관리할 때 사용되는 주요 기능

            //샘플 배열           0  1   2   3   4
            int[] iExamArray = { 10, 30, 60, 50, 20 };

            // 배열의 정렬(오름차순)
            Array.Sort(iExamArray); // 10, 20, 30, 50, 60

            // 배열의 정렬(내림차순)
            Array.Reverse(iExamArray);

            // 배열의 값을 하나의 문자열로 표현
            // string.Join(배열 사이에 끼울 문자, 변환할 배열)
            string sExamValue = string.Empty;
            sExamValue = string.Join("/", iExamArray);
            MessageBox.Show(sExamValue);

            // 배열의 데이터를 삭제(방은 두고 데이터만 삭제)
            // Array.Clear(삭제할배열, 삭제시작주소, 삭제데이터 수)
            Array.Clear(iExamArray, 0, 2); // 0번째부터 2개를 지워라

            // 배열의 목사
            // () : 캐스팅 - 강제로 형변환을 하는 기능
            //               변환되어야 되는 대상이 명확할 경우에 사용
            object oValue = iExamArray.Clone(); // object는 제일 상위 클래스(문자, 정수 다 가능)

            int[] iBackUps = (int[])oValue; // object는 배열을 복사할 수 있지만 배열에 object를 담을 수 없다
            // object 형식 -> 특정데이터 형식 형변환 unBoxing
            // 어떤 데이터 형식 -> object 형식 형변환 Boxing

            // 위에서 iExamArray가 문자열로 변환했기 때문에 다시 (int[]) 사용해서배열로 형변환
            // int[] iBackUps = (int[])iExamArray.Clone();

        }

        private void btnArrayCopy_Click(object sender, EventArgs e)
        {
            // 값 형식과 참조 형식의 복사


            #region <값 형식의 복사 방법>
            int iValue = 10;
            int iValue2 = iValue;
            // iValue = 10, iValue2 = 10;

            MessageBox.Show(iValue.ToString()); // 10
            iValue2 = 20;
            MessageBox.Show(iValue.ToString()); // 10

            // int 데이터타입은 값 형식으로
            // 복사를 할 경우 해당 값을 직접 복사하여 전달
            #endregion

            #region<참조 형식의 복사>
            // 배열의 복사
            int[] iValues1 = { 10, 20, 30, 40, 50 };
            int[] iValues2 = iValues1;

            MessageBox.Show(iValues1[0].ToString()); // 10
            iValues2[0] = 333;
            MessageBox.Show(iValues1[0].ToString()); // 333

            // 얕은 복사
            // 참조형식의 데이터를 복사할 때
            // 값이 저장된 위치 정보만 전달해 주는 복사 방법
            #endregion
        }
    }
}
