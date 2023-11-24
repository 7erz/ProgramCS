namespace Class_11th
{
    internal class Program
    {
        static void BinarySeacrch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            int pivot = 0;

            while (left <= right)
            {
                pivot = (left + right) / 2;

                if (array[pivot] == target)
                {
                    Console.WriteLine("array[pivot] : " + array[pivot]);
                    return;
                }
                else if (array[pivot] > target)
                {
                    right = pivot - 1;
                }
                else if (array[pivot] < target)
                {
                    left = pivot + 1;
                }
            }
            Console.WriteLine("Not Value Found");
        }
        static void Main(string[] args)
        {
            #region 이진 트리
            //오름차순으로 정렬된 리스트에서 특정한 값의 위치를 찾는 알고리즘
            //시간 복잡도 : log(n)

            /*
            //찾아야 하는 수 2
            //[1][2][3][4][5][6]
            // 0    ↑         5
            //left = 0 right = 5
            //0+5 후 나누기 = index값 

            //[1][2][3]
            // 0  ↑ 2

            //3을 찾을때는 0은 없애고
            //[1][2][3]
            //    1  2

            //비교는 인덱스로 찾는건 수로
            //크면 left 작으면 right를 갱신
            */
            //내가 한답
            /*int[] array = new int[6];
            int left = 0;
            int right = array.Length - 1;
            int pivot = (left + right) / 2;
            bool found = false;


            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(i + "번째 array에 들어갈 숫자 입력 : ");
                array[i] = Int32.Parse(Console.ReadLine());
            }
            
            Console.Write("찾을 숫자 : ");
            int search = Int32.Parse(Console.ReadLine());

            Array.sort(array);

            Search(search);

            void Search(int num)
            {
                //[num] 비교      //[2] 찾고 싶어
                //[1][2][*3][4][5][6]
                // 0  1   2  3  4  5
                //Console.WriteLine("array[pivot] : " + array[pivot]);        //*3
                //Console.WriteLine("pivot : " + pivot);                      //2
                //Console.WriteLine();

                if (num > array[pivot])     //2 > 3? 거짓
                {
                    for(int i = pivot + 1; i <= right; i++)
                    {
                        if (array[i] == num)
                        {
                            Console.WriteLine("찾던 숫자 " + num + "은 " +i+"번째 array에 있습니다.");
                            found = true;
                            break;
                        }
                    }
                    if(found == false)
                    {
                        Console.WriteLine("찾던 숫자 " + num + "은 array에 없습니다.");
                    }
                }
                else if (num < array[pivot]) //2 < 3 참   
                {
                    for (int i = 0; i <= pivot; i++)
                    {
                        if (array[i] == num)
                        {
                            Console.WriteLine("찾던 숫자 " + num + "은 " + i + "번째 array에 있습니다.");
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                    {
                        Console.WriteLine("찾던 숫자 " + num + "은 array에 없습니다.");
                    }
                }
                else
                {
                    Console.WriteLine("찾던 숫자 " + num + "은 " + pivot + "번째 array에 있습니다.");
                }
            }


            



            //1. 배열의 가운데 요소에 인덱스 pivot으로 설정

            //2. [pivot]의 값이 찾고자 하는 요소가 같다면 검색 완료

            //3. [pivot]의 값이 찾는 값보다 크다면 left~pivot 사이 검색

            //4. [pivot]의 값이 찾는 값보다 작다면 pivot~right 사이 검색*/

            //예제
            /*int[] array = new int[8] { 3, 5, 10, 13, 15, 17, 20, 19  };
            Array.Sort(array);

            BinarySeacrch(array,10);*/



            #endregion
        }
    }
}