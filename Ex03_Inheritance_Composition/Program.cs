using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Inheritance_Composition
{
    /*
    개발환경에서 업무가 복잡하다
    쇼핑몰
    회원관리, 주문, 상품 등 각각의 업무 독립적인 것 보다는 관계를 가지고 있다.

    여러 개의 설계도는 관계를 가져야 한다.

    1. 상속(is ~ a) 은 ~ 이다. 명제가 성립되면 90% 상속... (원은 도형이다, 강아지는 동물이다)
    2. 포함(has ~ a) 은 ~ 가지고 있다. >> (자동차는 엔진을 가지고 있다, 경찰은 권총을 가지고 있다)
    
    도형 : 추상화, 일반화 : 그리다, 색상 >> 공통자원
    class Shape {색상, 그리다} >> 부모
    class Point {좌표값} >> 부품 >> 포함

    class Circle : Shape { Point    나머지는 특수하고 구체화 된 것 구현}

     */
    class Shape {  //공통속성, 공통함수
        public string color = "gold";
        public void draw()
        {
            Console.WriteLine("도형을 그리다");
        }
    }
    class Point
    {
        int x;
        int y;

        public Point() //기본 점, 할당 2번이라 좋지 않은 코드, 이후 this() 생성자 호출 할당을 통해 1개로 줄이기
        {
            x = 1;
            y = 1;
        }

        public Point(int x, int y) //원하는 점
        {
            this.x = x;
            this.y = y;
        }
    }
    //문제 
    //원을 만드세요 (원의 정의 : 원은 한점과 반지름을 가지고 있다)
    //1. 원은 도형이다 
    //2. 원은 점을 가지고 있다
    //3. 원은 반지름을 가지고 있다(특수성)
    //3.1 원의 반지름은 초기값 10을 가지고 있다
    //3.2 점의 좌표는 초기값 (10,15) 가지고 있다
    //기본 (초기값)을 설정하지 않으면 반지름과 점의 값을 입력받을 수 있다 (원이 만들어 질때)

    class Circle : Shape { //상속
        Point point; //포함 (다른 클래스 타입을 member field 로 가지는 것)
        private int r; //특수화

        public Circle()
        {
            this.r = 10;
            this.point = new Point(10, 15);
        }
        public Circle(int r, Point point)
        {
            this.r = r;
            this.point = point;
        }
    }
    //문제2)
    //삼각형 클래스 만들기
    //삼각형 정의: [3개의 점]과 색상과 그리다 는 기능을 가짐
    //Shape, Point 클래스는 제공을 받는다.
    //default 값으로 삼각형을 그릴 수 있고, 3개의 좌표값 모두 입력 받아서 삼각형을 그릴 수 있다.

    class Triangle : Shape
    {
        Point[] pointarray;

        public Triangle()
        {
            pointarray = new Point[3]; { new Point(1,2), new Point(3,4), new Point(5,6)};
        }
        public Triangle(Point[] pointarray)
        {
            this.pointarray = pointarray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.draw();

            Triangle t = new Triangle();
        }
    }
}
