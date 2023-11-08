//<- {}↗ world namespace (global using glabal::System 등 기본으로 들어가있음)

namespace ProgramCS
{
    #region C#기본
    //접근 지정자 class 이름
    //public,protected,private


    //자료형
    //Object 자료형                ↓
    //      값 타입←-(UnBoxing)-------(Boxing)-→참조 타입        (서로 다르지만 넣을 수 있음)
    //Object 자료형: 둘다 받을 수 있지만, 타입 자체는 참조타입 (참조타입이 큼)
    //값 타입: bool,byte,char,short,int,long,float,double,struct,decimal,long long 등...
    //참조 타입 : class, string, delegate, array(배열), dynamic, object, interface 등...

    //값 타입 예)
    //int data = 100; -> 스택에 data 4byte 들어감
    //메모리가 해제되는건 메인 함수가 끝났을 때.

    //참조타입 예)
    //int a[5]; -> 스택에 buffer함수 하나 들어감
    //실질적인 메모리를 만드려면 int [] buffer = new int[5];
    //buffer 안의 a는 heap이라는 메모리 영역에 메모리 5개가 잡힘


    //가비지 컬렉터
    //세대 기반 가비지 컬렉션 (compact압축 기능 O)
    //함수가 종료되면 참조변수(포인터변수)가 해제됨.
    //연결이 끊어져 아무도 참조하지 않는 것을 가비지라고 함
    //그것을 가비지 컬렉터가 호출되면 삭제
    //메모리가 생성되어 있는데 40byte중에 4, 6을 지우고 8을 넣으려고 하면 들어 갈 수 없다.
    //([4][4][6][8][8][10]) -> ([][4][][8][8][10])
    //10byte라는 메모리가 비어있지만 크기가 맞지 않아 들어갈 수 없음
    //세대 기반 가비지 컬렉션은 비어있는 메모리를 앞에서 압축해서 넣을 수 있음
    //([][4][][8][8][10]) -> ([][4][8][8][10]) -> ([8][4][8][8][10])
    //여기서 메모리를 초과해 들어가면 40이 플랫폼에 따라 배수가 늘어난다(1.5x 60 ,2x 80)

    //비세대 기반 가비지 컬렉션 (compact압축 기능X)
    #endregion

    internal class Program
    {

        static void Main(string[] args)
        {
            //static은 생성되기전에는 위의 함수들의 존재를 모름
            //Function2();


            #region 자료형
            //아래는 초기화를 안하면 0이 들어감(다른 언어는 쓰레기값)
            //byte stream = 1;
            //bool boolean = false;
            //char character = 'A';
            //short data = 200;
            //int integer = 100;
            //long longData = 300;

            //float[] buffer = new float[3];
            //buffer[0] = 1.15f;
            //buffer[1] = 1.25f;
            //buffer[2] = 1.35f;

            //double pi = 3.14;
            //decimal decimalData = 0.1m;

            //Console.WriteLine() : 문자열을 출력하는 함수
            //Console.WriteLine("stream : " + stream);
            //Console.WriteLine("boolean : " + boolean);
            //Console.WriteLine("decimal : " + decimalData);
            #endregion

            #region 박싱(Boxing)
            //값 형식의 데이터를 찹조 형식으로 변환하는 과정
            int data = 5;

            object obj = data;

            Console.WriteLine(obj);
            Console.WriteLine(data);

            #endregion

            #region 언박싱(UnBoxing)
            //참조 타입의 데이터를 값 타입으로 변환하는 과정
            int count = 10;

            Object obj1 = count;

            int result = (int)obj1;

            #endregion
        }
    }
}

