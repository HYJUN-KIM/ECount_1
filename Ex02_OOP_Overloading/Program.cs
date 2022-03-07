using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_OOP_Overloading
{
    class Test
    {
        public Test() {  } //기본 생성자 (default constructor)
        public Test(String name) {  } //오버로딩 생성자
        public Test(String name, int age) {  } //오버로딩 생성자

        //오버로딩이 많다는 의미 = 옵션이 많다
        //ex) 자동차 대리점... 기본형, 옵션 1, 옵션 2, 옵션 3... 변수의 초기화를 통해서 설정
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
