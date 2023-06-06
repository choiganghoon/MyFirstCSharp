using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap03_DataTypeConversion : Form
    {
        // 데이터 타입의 형 변환 (숫자 -> 문자)
        // 문자열로 데이터 타입을 변경 : .ToString, Convert.ToString()

        // 데이터 타입의 형 변환 (문자 -> 숫자)
        // 숫자형으로 데이터타입을 변경 : .Parse(), Convert.ToInt32()

        // 명시적 형변환
        // 변경할 데이터 타입을 지정 후 변환
        // .ToString()
        public Chap03_DataTypeConversion()
        {
            InitializeComponent();
        }

        private void btnItoS_Click(object sender, EventArgs e)
        {
            // 디버깅
            // 프로그램 개발 시 오류 내역을 검출 하거나 프로그램의 로직이 실행되는 각 단위 
            // 결과를 확인할 수 있도록 하는 프로그래밍 방법
            // 브레이크 포인트 : 로직이 실행 될 때 멈춰서 디버깅이 시작 되는 시점(왼쪽 음영색 라인 클릭, f9)

            // 숫자를 문자로 변환하기 기능

            // 1. 변환될 대상 숫자를 담을 변수 생성 및 초기화
            int iValue = 10;
            // int iValue = 20 이건 안대고 아래꺼는 댐 
            // iValue = 20;
            int iValue2 = 20;

            double dValue = 10.1;
            double dValue2 = 20.5;

            // 2. 변형된 데이터 타입이 담길 문자 변수
            string sValue1;
            string sValue2;

            // 3. iValue의 데이터 타입 int의 기능 중, ToSring() 이라는 기능을 사용하여
            // 숫자를 문자로 변형 후 sValue(string)에 대입한다
            sValue1 = iValue.ToString();

            // 4. 메세지 박스로 변행된 문자형 숫자를 표현
            MessageBox.Show(sValue1);

            // sValue2에 dValue2를 대입해 보세요
            sValue2 = dValue2.ToString();

            // 문자열로 변환하는 기능 2번째
            sValue2 = Convert.ToString(dValue2);

            // Convert.ToString()의 기능은 결과적으로는 .ToString()가 같은 결과를 생성 하지만
            // Null 처리의 오류 반환 때문에 .ToString 보다는 Convert 쓰는 것을 추천

            // 문자 열의 합
            // // sValue1 : "10" , sValue2 : "20.5"
            string sValue3 = sValue1 + sValue2;

            MessageBox.Show(sValue3); // 1020.5
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 문자 -> 숫자로 바꾸는 버튼 클릭시 실행되는 로직

            // 1. 숫자로 바꿀 문자열 변수 생성
            string sValue1 = "안녕하세요";
            string sValue2 = "10";
            string sValue3 = "10.1";

            // 2. .parse() 기능을 통한 변환
            int iResult = 0; // 변환 결과를 담을 인트 변수

            // 안녕하세요 문자를 숫자로 바구려 했으나 변환 실패를 통한 런타임 오류
            // iResult = int.Parse(sValue1);

            // 숫자로 변환할 수 있는 문자일 경우 오류 없이 변환이 완료
            iResult = int.Parse(sValue2);

            // 3. Convert.ToInt32()
            // 문자 -> 숫자
            // 숫자로 바꿀 수 없는 문자일 경우 시스템 오류 발생
            iResult = Convert.ToInt32(sValue1); // "안녕하세요" 가 숫자로 바뀔 수 없으므로 오류 반환

            // 4. 숫자로 변환할 수 있는 문자인지 검증하는 기능 .TryPares()

            // 숫자형 데이터 형변환 실패
            // bResult : false
            // bResult : 0
            bool bResult = int.TryParse(sValue1, out iResult);

            // 숫자형 데이터 형변환 (소수 데이터를 형변환)
            double dResult = 0; // 소수 형변환 결과를 받을 변수


            // 소수형 실수 문자열을 실수 데이터 타입으로 형변환 및 결과 검출
            bResult = double.TryParse(sValue3, out dResult); // 소수 형변환 결과를 받을 변수


            // 소수 형 실수 문자열을 실수 데이터 타입으로 형변환 및 결과 검출
            // sValue3 : "10.1"
            // dResult : 10.1
            // bResult : true
            bResult = double.TryParse(sValue3, out dResult);

            // 정수형 문자열을 실수 데이터 타입으로 형변환 하는 경우
            // sValue2 : "10.1"
            // dResult : 
            // bResult : 
            bResult = double.TryParse(sValue2, out dResult);

            // 문자를 숫자로 형변환 할 경우 .Parse() 와 Convert.ToInt32()를 사용할 수 있지만
            // 변환 할 수 없는 유형의 문자인 경우 런타임 오류가 발생 하므로
            // 데이터타입.TryParse() 기능을 사용하여 형변환 하는것을 추천
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            // 다중 주석 처리 문 /* */
            /* 
              Null 상태의 변환 처리
            - Convert.ToString() 구문을 사용 시 Null 처리된 값이 있을 경우 빈값을 반환

            - Null?
                데이터의 용량(메모리)가 할당되지 않은 상태
                ""은 아무런 값이 없는 값이 할당된 상태

                숫자형 데이터 타입은 ? 키워드를 추가하여 null상태로 만들 수 있다
            */

            string sValue = null;
            // MessageBox.Show(sValue.ToString()); // sValue가 null 처리 되었으므로 오류가 발생(런타임 오류)
            MessageBox.Show(Convert.ToString(sValue));
            string sValue2 = "";

            // 숫자 데이터를 null 처리 하는 방법
            int? iValue = null;
            MessageBox.Show(iValue.ToString());
        }

        private void btnSUM_Click(object sender, EventArgs e)
        {
            // 문자열의 합과 숫자의 합
            string sValue1 = "ABC";
            string sValue2 = "DEF";

            string sValue3 = sValue1 + sValue2;
            MessageBox.Show(sValue3); // ABCDEF


        }
    }
}