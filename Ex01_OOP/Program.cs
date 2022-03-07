using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    /*
    클래스 == 설계도 == 데이터 타입
    is ~ a      : 상속
    has ~ a     : 포함
    상속
    1. 단일 상속 (계층적 상속)
    2. 사용자가 만드는 모든 클래스는 기본적으로 Object (root) 상속하고 있다.
    */

namespace Ex01_OOP
{
    sealed class aaa
    {
         //봉인된... 상속할 수 없는 클래스...
    }
    //다형성  : overloading (하나의 이름으로 여러 가지 기능) >> 함수 (생성자 함수, 일반함수)
    //함수의 parameter [개수]와 [타입]을 다르게 하여 만드는 방법 + 순서 구분 O
    //목적    : 개발자의 편리성 = 성능 향상 X
    //상속과 무관... 

    class Test
    {
        public void method()
        {
            Console.WriteLine("일반 함수");
        }
        //오버로딩
        public void method(int i)
        { 
            Console.WriteLine("i: {0}", i);
        }
        public void method(string i)
        {
            Console.WriteLine("i: {0}", i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
