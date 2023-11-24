namespace Class_12th
{
    internal class Program
    {
        //나의 답
        static void QuickSort(int[] array, int start, int end)
        {
            int left = start;
            int right = end;
            int pivot = array[start];
            int middle = 0;

            start++;

            if (left < right)
            {
                while (start <= end)
                {
                    while (array[start] <= pivot && start < end)
                    {
                        start++;
                    }
                    while (array[end] > pivot && start <= end)
                    {
                        end--;
                    }
                    if (start < end)
                    {
                        Swap(ref array[start], ref array[end]);
                    }
                    else
                    {
                        break;
                    }
                }
                Swap(ref array[left], ref array[end]);
                //[1][3][2][4][5][9][6][8][7]
                //Console.WriteLine("left : " + left);        //0
                //Console.WriteLine("right : " + right);      //8
                //Console.WriteLine("start : " + start);      //[5]
                //Console.WriteLine("end : " + end);          //[4]
                Console.WriteLine("middle" + middle);
                //QuickSearch(array, left, middle-1);
                //QuickSearch(array, middle + 1, right );
            }

        }
        //정답
        static void QuickSort1(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = start;
            int left = start + 1;
            int right = end;

            while (left <= right)
            {
                while (left <= end && array[pivot] >= array[left])
                {
                    left++;
                }
                while (right > start && array[pivot] <= array[right])
                {
                    right--;
                }
                if (left > right)
                {
                    Swap(ref array[pivot], ref array[right]);
                }
                else
                {
                    Swap(ref array[left], ref array[right]);
                }
            }
            QuickSort1(array, start, right - 1);
            QuickSort1(array, right + 1, end);
        }

        static void Swap(ref int x, ref int y)       //ref로 복사비용 없앰
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            #region 퀵 정렬
            //기준점을 획득한 다음 해당 기준점을 기준으로 배열을 나누고
            //한 쪽에는 기준점보다 작은 항목들이 위치하고 
            //다른 쪽에는 기준점보다 큰 항목들이 들어옴

            //나뉘어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여
            //모든 배열이 기본 배열이 될 때까지 반복하면서 정렬하는 알고리즘


            //예제 설명
            /*
            //[5][3][8][4][9][1][6][2][7]
            //pivot = 5
            //left = 3   right = 7
            //right 는 pivot 보다 커야함 (left는 반대)
            //left는 8에서 멈추고 right실행 (2에서 멈춤)
            //그 후 left right 스왑
            //[5][3][2][4][9][1][6][8][7]
            //그 후 다시 left right 비교(left = 9 , right = 1에서 멈춤)
            //다시 값을 swap
            //[5][3][2][4][1][9][6][8][7]

            //계속 하다 left right에서 엇갈린다면 멈추고 pivot과 right값 교체함
            //pivot = 1 right = 5
            //[1][3][2][4][5][9][6][8][7]

            //재귀 함수()
            //왼쪽부터 검사
            //그 후 오른쪽으로 검사

            //left right는 교차 전까지 멈추고 교환하다가
            //교차가 된다면 pivot과 right로 교차*/

            int[] array = new int[9] { 5, 3, 8, 4, 9, 1, 6, 2, 7 };
            QuickSort1(array, 0, array.Length - 1);

            foreach (int x in array)
            {
                Console.WriteLine(x);
            }




            #endregion

        }
    }
}