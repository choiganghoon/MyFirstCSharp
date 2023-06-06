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
    public partial class Chap03_DataTypeConversion : Form
    {

        //데이터 타입의 형 변환 (숫자 -> 문자)
        //문자열로 데이터 타입 을 변경: .ToString(), Convert.ToString()

        //데이터 타입의 형 변환 (문자 -> 숫자)
        //문자열로 데이터 타입 을 변경: .Parse(), Convert.ToInt32()


        /* 명시적 형변환
         * 변경할 데이터 타입을 지정후 변환
         * .ToString(), Convert.ToString()
         * .Parse(), Convert.ToInt32()
         */

        public Chap03_DataTypeConversion()
        {
            InitializeComponent();
        }

        private void btnItoS_Click(object sender, EventArgs e)
        {

        //디버깅
            // 프로그램 개발 시 오류 내역을 검출 하거나 프로그램의 로직이 실행되는 각 단위 별로 결과를 확인할 수 있도록 하는 프로그래밍 방법.
            // 브레이크 포인트: 로직이 실행될 떄 멈춰서 디버깅을 시작 되는 시점 (왼쪽 음영색 라인 클릭, F9)
        
        // 숫자를 문자로 변환하기 기능

        // 1. 변환될 대상 숫자를 담을 변수 생성 및 초기화

            //초기화 할때 또는 대입할 때 대입되는 대상을 리터럴 이라고 부른다.
            int iValue = 10;
            int iValue2 = 20;

            double dValue = 10.1;
            double dValue2 = 20.5;

        // 2. 변형된 데이터 타입이 담길 문자 변수
            string sValue1;
            string sValue2;

        // 3. iValue 의 데이터 타입인 int의 기능중 ToString()이라는 가능을 사용하여 숫자를 문자로 변형 후 sValue (String)에 대입했다.
            sValue1 = iValue.ToString();    //iValue 지역변수에 ToString 기능을 사용한다
            //쎄쎄쎄 명시적으로 형변환했다

        // 4. 메세지 박스로 변형된 문자형 숫자를 표현한다.
            MessageBox.Show(sValue1);
            


        //QUIZ. sValue2 에 dValue2 을 대입해 보세요오

            sValue2 = dValue2.ToString();


        // 5. 문자열로 변환하는 두번째 기능 ||  실무에서 많이 사용되니까 이것을 많이 사용하자 현욱아

            sValue2 = Convert.ToString(dValue2);    //Convert 에서 ToString기능을 가져온다

            //null 상태에서도 오류가 안난데, 그러니까 이걸로 사용하는게 정답

            /* Convert.ToString()의 기능은 결과적으로 .ToString() 가 같은 결과를 생성하지만
             * Null 처리의 오류 반환 떄문에 .ToString() 보다는 Convert.ToString() 형식을 사용하는것은 강추
             */

        // 6. 문자열의 합
            //연관되는 문자열을 이어서 표현한다고 알겠지 알겠어?
            // sValue = "10" , sValue2 = "20.5"
            string sValue3 = sValue1 + sValue2;

            MessageBox.Show(sValue3); // 1020.5 가 표시된다 한번 확인해보자...오 진짜 그렇게 나왔어




        }
        //데이터 타입의 형 변환 (문자 -> 숫자)

        //문자를 숫자로 바꾸는 버튼 클릭시 실행되는 로직


        private void btnStoI_Click(object sender, EventArgs e)
        {
        // 1. 숫자로 바꿀 문자열 변수 생성
            string sValue1 = "안녕하세여";
            string sValue2 = "10";
            string sValue3 = "10.1";    //소수를 포함한 실수


        // 2. .Parse() 기능을 통한 변환
            int iResult = 0;    //변환 결과를 담을 int 변수

            //안녕하세요 문자열을 숫자로 바꾸려고 했으나 변환 실패로 통한 런타임 오류 발생 오류 발생 
            //iResult = int.Parse(sValue1);   //문법상으로는 문제가 없지만, 문자를 숫자로 바꿀수 없다 | 따라서 런타임 오류가 Happen
            //위에 확인한것 처럼 Parse의 단점은 runtime 오류가 발생할 수 있다 따라서 TryParse을 사용하는것은 강추 (강사추천)
            
            //숫자로 변환할 수 있는 문자일 경우 오류 없이 변환이 완료 굿굿
            iResult = int.Parse(sValue2);

        // 3. Convert.ToInt32()
            // 문자를 숫자로 변환하고 숫자로 바꿀 수 없는 경우 시스템 오류 발생

            // iResult = Convert.ToInt32(sValue1);     //문자열 "안녕하세여" 가 숫자로 바뀔수 없으므로 오류로 반환

            //이것도 내가 혼자해봤는데 가능
            iResult = Convert.ToInt32(sValue2);


        // 4. .TryParse() : 숫자로 변환 할 수 있는 문자인지 검증하는 기능

            //숫자형 데이터 형변환 실패의 경우 (문자형을 정수형으로 변형하려 할때 실패)
            //sValue1 = "안녕하세여",bResult = false, iResult = 0

            bool bResult = int.TryParse(sValue1, out iResult);

            //숫자형 데이터 형변환 실패의 경우 (실수형 데이터 (소수포함)를 정수로 변형하려 할때 실패)
            //sValue3 = "10.1", bResult = false, iResult = 0

            bResult = int.TryParse(sValue3, out iResult);

            //숫자형 데이터 형변환 성공의 경우 (실수형 데이터 (소수포함)를 정수로 변형하려 할때 성공)
            //소수형 실수 문자열을 실수 테이터 타입으로 형변환 및 결과 검출
            //sValue3 = "10.1", bResult = true, dResult = 10.1
            
            double dResult = 0;
            bResult = double.TryParse(sValue3, out dResult);

            //정수형 문자열을 실수 테이터 타입으로 형변환 성공의 경우          작은수 (정수int) 가 큰 숫자(실수double)로 들어갈수 있어서 OK OK
            //sValue2 = "10", bResult = true, dResult = 10
            
            bResult = double.TryParse(sValue2, out dResult);



            // 정리 한번 합시다

            /*문자를 숫자로 형변환 할 경우. .Parse()와 Convert.ToInt32를 사용할 수 있지만
             * 변환 할 수 없는 유형의 문자인 경우 런타임 오류가 발생 할 수 있으니까
             * 테이터 타입 .TryParse() 기능을 사용하여 형변환 하는 것을 강추 강추
             */




        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            //Null 상태의 변환 처리

            // 다중 주석처리 기능 /* */

            /*
             Null 상태의 변환 처리
            - Convert.ToString() 구문을 사용 시 Null 처리된 값이 있을 경우 빈값을 반환한다

            - Null 이란?
                - 데이터의 용량 (메모리)가 할당되지 않은 상태
                - ""은 아무런 값이 없는 값이 할당된 상태
                - 아래 두개는 완전 다른 상태이다.

                -숫자형 데이터 타입은 ? 키워드를 추가하여 null상태로 만들 수 있다.
              
             */

            string sValue = null;
            //MessageBox.Show(sValue.ToString()); 잠시 주석처리     //sValue가 null 처리 되었으니까 오류가 발생. 무슨 오류? 런타임 오류
            MessageBox.Show(Convert.ToString(sValue));      //sValue가 null 처리되었어도 아무것도 없는 값으로 치환하여 반환

            // string sValue = "";


            //? 사용해서 숫자 데이터를 null처리하는 방법
            int? iValue = null;    //?가 없으면 에러가 뜨는데 ?가 있으면 null처리가 가능하다.
            
            //Convert.ToString() 과 .ToString() 형식으로 Null을 변환 할 수 있다.
            
            //MessageBox.Show(iValue.ToString()); 이거는 안돼!! 에러뜬다고 그래서
            MessageBox.Show(Convert.ToString(iValue)); // Convert.ToString 을 사용하면 된다구


        }

        private void btnSUM_Click(object sender, EventArgs e)
        {
            // 문자열의 합과 숫자의 합
            string sValue1 = "ABC";
            string sValue2 = "DEF";

            string sValue3 = sValue1+sValue2;

            MessageBox.Show(sValue3);       //ABCDEF 가 표현이 되어야 한다

            int iValue1 = 50;
            int iValue2 = 30;

            int iValue3 = iValue1+iValue2;
            MessageBox.Show(Convert.ToString(iValue3));     //String으로 변환을 해야지 메시지로 보여줄 수 있어 답은 80
        }
    }
}
