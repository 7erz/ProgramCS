namespace Class_7th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 일반화 프로그래밍
            //하나의 데이터가 특정 데이터 타입에만 종속되지 않고,
            //여러 데이터 타입을 가질 수 있는 기술에 중점을 두어
            //재사용성을 높일 수 있는 프로그래밍 방법

            //Deque<string> stringDeque= new Deque<string>();
            //Deque<int> intDeque = new Deque<int>();

            //stringDeque.Set("Box Collider");
            //intDeque.Set(1121);

            //C++ 템플릿은 컴파일이 한 번 일어나면, c# 일반화는 컴파일이 두번 일어남

            //C++ 템플릿은 사용하지 않으면 컴파일을 하지 않습니다.
            //C# 일반화는 사용하지 않더라도 그에 관련된 정보를 저장하기 위한 
            //meta 파일을 생성해야 하므로 컴파일이 진행됨

            #endregion

            #region 범위 기반 반복문 foreach
            int[] buffer = new int[5];
            //Collection
            //List, Dictionary, LinkedList, Stack, Queue

            foreach (int element in buffer)
            {
                Console.WriteLine(element);
            }


        }
    }
}