using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    internal class Chap02_Datatype_데이터타입
    {
        // 변수
        // 값을 담아주는 그릇의 개념
        // 하나의 데이터 값을 가질 수 있으며, 한 번 정해진 값이 고정되는게 아니라
        // 특정한 상황에 따라 계속해서 변하는 데이터 타입

        // 1. 정수 형 데이터 타입과 변수
        //  - 정수형 데이터를 정수형 변수에 담는다

        // int : integer 정수형 데이터 타입

        // 1-1. 정수형 데이터 타입을 담을 그릇을 만들기
        //		그릇의 이름을 iValue로 설정
        //		10 이라는 정수를 iValue 라는 그릇에 담기
        int iValue = 10;

        // 정수형 그릇 iValue2를 만들기
        int iValue2;

        public Chap02_Datatype_데이터타입()
        {
            // iValue2에 특정 정수 데이터 담기
            iValue2 = 20;

            // 2. 실수형 데이터 타입과 변수
                    // double 형태의 데이터를 담는 그릇(자료형 구조)은 int 형태의 그릇의 크기 보단 형태이므로
                    // 정수형 데이터와 실수형 데이터 모두 double형태의 그릇에 담을 수 있ㄷ.
            iValue = iValue2;   
            // 실수형 데이터 타입과 변수
            double dValue = 10;
            dValue = 115.5;
            // int는 정수라서 소수 안댐
            // 그럼에도 int를 쓰는 이유는 메모리 효율성 때문에
            // 요즘은 컴터가 좋아서 별차이없음

            // 데이터의 크기가 큰 내역은 작은 데이터 타입의 그릇에 담을 수 없다
            //iValue2 = 115.5

            // 3. 문자형 데이터 타입과 변수
            string sValue; // 문자를 담을 수 있는 그릇 생성

            sValue = "안녕하세요";

            // 4. 논리형 데이터 타입과 변수
            // 논리? 참과 거짓을 구분 지을 수 있는 데이터 타입

            bool bValue; // bValue라는 변수를 Bool 데이터 타입으로 생성

            bValue = true; // bValue에 참을 등록
            bValue = !true; // true를 스위칭 하여(false) bValue에 대입
            bValue = false; // bvalue에 false인 상태를 등록
            bValue = !false; // false를 스위칭하여 bValue에 대입

            // 데이터 타입이 맞지 않는 데이터를 대입 시 오류가 발생
            // bValue = 1;
            // bValue = "참";

            // 주석 
            // 개발자가 프로그램 작성 시 로직에 대한 코멘트(생각 또는 설명) 을
            // 첨가 하여 작성해 두는 방법
            // 프로그램 실행에는 영향을 미치지 않는다
            // 선택 영역 주석 컨트롤 k c

            // 빌드 (컨트롤 b , 프로젝트 - 빌드) 솔루션 빌드 - 쉬프트 컨트롤 b
            // 개발자가 코딩한 포르그램 내용을 컴퓨터가 알아들을 수 있도록 포장
            // 중간 단계의 언어

            // 포르그램 오류 검증의 종류
            // 1. 컴파일 할 때 개발자에게 오류 내역을 즉각 알려주는 에러타입
            //  - 컴파일 타입의 에러 검출 위해
            // 2. 프로그램을 실행 시켜야만 오류 내역을 확인할 수 있는 방식
            //  - 런타임 에러 검출 유형


            // 5. 그 외의 데이터 타입
            // 5-1. 케릭터 형식 '' 홑따옴표로 문자 1자리를 담는다
            char cValue = 'A';
            string sValue3 = "ABCDE";

            // 5-2 unit
            uint uiValue = 1; // 양의 정수만 다루는 데이터 형식
                              // uiValue = -1 안대

            // 5-3 var 형식
            // 특정 데이터를 담을 형식을 미리 정해 두지 않고 가변적으로 데이터를 관리할 경우 사용

            var vValue = 10; // 정수형 데이터 등록 가능

            var vValue2 = "안녕하세요"; // 문자도 가능

            var vValue3 = false; // 논리도 가능

            // vValue = "11"; // 정수형 데이터를 대입하고 난 다음에는 문자형 데이터를 대입 할 수 없다

            // 어떠한 그릇에 데이터를 최초 대입하다 : 데이터를 초기화 하다


            // object 형식
            // 모든 데이터 타입의 조상, 시초
            // var와 다르게 데이터 타입 다르게도 가능
            // 실무에서는 바뀌는게 안좋기 때문에 너무 마니 사용하면 안댐
            object oValue = 10;
            oValue = "10";
            oValue = "false";

            // var, object
            // 가변적으로 데이터를 관리 할 수 있는 유용한 자료형 구조 이지만
            // 대규모 프로젝트에서 타 개발자가 만든 특정 로작으로 인한 데이터 타입이 일치하지 않는
            // 오류가 발생할 수 있으므로 사용을 추천하지 않는다
            // 아마 조건문 같은거에서 문제가 있지 안으까??


        }
    }
}
