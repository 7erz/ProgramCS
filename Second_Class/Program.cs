namespace Second_Class
{
    public class Item
    {
        private int price;
        public string name;

        //멤버함수도 접근지정자 설정해야 함
        public void View()
        {
            Console.WriteLine("Name : " + name);

            Console.WriteLine("Price : " + price);

        }
    }

    public class Vector3
    {
        //ref : 하나의 변수에 서로 다른 이름으로 사용할 수 있는 키워드
        public void Distance(ref int x)
        {
            x = 100;
        }

        //in : 참조타입, ref의 기능을 가지면서 const ref (읽기 전용),참조로 전달하는 키워드
        public void Lerp(in int x)
        {
            Console.WriteLine("x의 값 : " + x);
        }

        //out : 출력용 매개 변수로 함수 내에서 값을 반드시 초기화해야함
        public void MoveTowards(out int x, out bool check)
        {
            x = 199;
            check = true;
        }

        public void Normalize(params object[] list)
        {
            object sum;
            for (int i = 0; i < list.Length; i++)
            {

                sum = list[i];

                Console.WriteLine(sum + " ");
            }

            Console.WriteLine("");
            //foreach(int number in list)
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 가비지 컬렉터
            //동적으로 할당된 메모리 영역 가운데 더 이상 사용할 수 없게 된 
            //영역을 탐지하여 자동으로 해제하는 기법

            //CLR
            //관리되는 힙(managed heap)

            //root 는 참조변수가 들어감
            //memory에는 특정한 크기만큼 포인터에 들어감
            //참조변수는 메모리의 특정한 크기에 연결
            //포인터는 새로 만들어질 빈 공간으로 이동

            //C#에서는 세대별 가비지 컬렉션이 있음
            //0세대, 1세대, 2세대
            //0세대: 가장 빈번하게 생성 삭제됨
            //1세대: 0세대 가비지 컬렉터 실행후 살아있는 메모리
            //2세대: 1세대 가비지 컬렉터 실행후 살아있는 메모리

            //0세대 임계치에 도달하면 자동으로 실행 됨
            //ABCD중 B만 남아있다면 1세대는 B
            //BEFG중 0세대는 EFG. 그 중 E G를 정리하면 B F만 남음
            //FULL GC
            //자주 삭제하는 것을 줄이는 것이 좋음(오브젝트 풀링)

            //오브젝트를 for문으로 생성하다가 destroy하게 되면 프레임 드랍이 걸림
            //가비지 컬렉터가 수행하는 시간 동안 대기가 걸림
            //Item item = new Item();
            #region 설명
            //item은 참조타입, 스택에 item 생성 (자동으로 null값이 들어감)
            //null에서 view값을 호출 하는것은 오류
            //new 라는 키워드를 이용해 힙 메모리 공간에 item이라는 클래스를 직접 만듦 (인스턴스)
            //멤버에 접근을 해 변수 호출, 사용 가능
            //delete사용 안하고 끝냈음(가비지 컬렉터)
            #endregion
            //item.View();


            //Item potion = new Item();
            #endregion

            #region 매개변수 한정자
            Vector3 vector3 = new Vector3();
            int x;
            bool die = false;

            //ref
            /*
            

            
            vector3.Distance(ref x);        //ref로 해야함 (

            Console.WriteLine("x의 값 : " + x);       //ref 가 없다면 0


            */

            //in
            /*
            vector3.Lerp(x);
            */

            //out
            /*
            Console.WriteLine("die의 현재 상태 : " + die);
            vector3.MoveTowards(out x,out die);

            Console.WriteLine("x의 값 : " + x);
            Console.WriteLine("die의 현재 상태 : " + die);*/

            //params
            /*
            vector3.Normalize(1, 2, 3, 4, 5, 6, "A", "B", "C", 7);*/

            #endregion

        }



    }
}