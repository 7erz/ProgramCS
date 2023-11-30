using System.Collections;

namespace Class_16th
{
    internal class Program
    {
        static IEnumerable Load()
        {
            int data = 0;

            while (true)
            {
                data++;
                yield return data;

                if (data >= 10)
                {
                    yield break;
                }
            }
        }
        static void Main(string[] args)
        {
            #region yield return
            //프로그램의 흐름을 다시 돌려주고 다시 되돌려받는 방식으로 제어하는 제어문

            //값, 클래스, 데이터들을 return해줄 수 있다.
            //yield return 50;
            //yield return 맵 정보 등등...

            foreach (var element in Load())     //객체를 반환함.
                                                //오브젝트 타입으로 받기에 박싱과정이 일어남(var = 유추를 하는것)
            {
                Console.WriteLine(element);
            }


            #endregion
        }
    }
}