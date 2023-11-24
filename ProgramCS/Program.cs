namespace ProgramCS
{
    internal class Program
    {
        static void Split(int[] array)
        {
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;
            int[] leftArray = new int[mid];
            int[] rightArray = new int[array.Length - mid];

            Array.Copy(array, 0, leftArray, 0, mid);
            Array.Copy(array, mid, rightArray, 0, array.Length - mid);

            Split(leftArray);
            Split(rightArray);
            Sort(array, leftArray, rightArray);
        }

        //나의 답
        static void Sort1(int[] array, int[] array1, int[] array2)
        {

            int[] sortArray = new int[array1.Length + array2.Length];
            int left = 0;
            int right = 0;
            int counter = 0;

            if (array1.Length == 1 && array2.Length == 1)
            {
                if (array1[0] > array2[0])
                {
                    sortArray[0] = array2[0];
                    sortArray[1] = array1[0];
                }
                else
                {
                    sortArray[0] = array1[0];
                    sortArray[1] = array2[0];
                }
            }
            else
            {
                while (counter == sortArray.Length - 1)
                {
                    if (array1[left] > array2[right])
                    {
                        sortArray[counter] = array1[left];
                        counter++;
                        left++;
                    }
                    else
                    {
                        sortArray[counter] = array2[right];
                        counter++;
                        right++;
                    }
                }

            }
        }

        static void Sort(int[] array, int[] leftArray, int[] rightArray)
        {
            int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    array[mergedIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[mergedIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            while (leftIndex < leftArray.Length)
            {
                array[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < rightArray.Length)
            {
                array[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }

        static void Main(string[] args)
        {
            #region 병합 정렬
            //하나의 리스트를 두 개의 균등한 크기로 분할하고
            //분할된 부분 리스트를 정렬한 다음, 두 개의 정렬된 부분
            //리스트를 합하여 전체가 정렬된 리스트가 되게 하는 방법

            //분할 : 입력 배열을 같은 크기의 2개의 부분 배열로 분할

            //정복 : 부분 배열을 정렬하며, 부분 배열의 크기가 충분히 작지 않으면
            //순환 호출을 이용하여 다시 분할 정복 실행

            //결합 : 정렬된 부분 배열들을 하나의 배열에 병합

            // 하는 법
            /*
            //[21][10][12][20][25][13][15][22]
            //이 상태에서 반으로 쪼갬
            //[21][10][12][20]   /   [25][13][15][22]
            //[21][10]  /   [12][20]   /    [25][13]    /   [15][22]
            //[21]    [10]    [12]    [20]    [25]    [13]    [15]    [22]

            //값이 작다면 왼쪽에 넣어주기
            //[10][21]  /   [12][20]    /   [13][25]    /   [15][22]

            //4개짜리 배열은 LEFT([*10][21]) RIGHT([*12][20]) 을 비교
            //*표시중 제일 작은 것을 0번째 배열에 넣음
            //그후 LEFT를 1로 옮김[21]
            //[*12]가 작기에 1에 [12]를 넣음
            //그후 [21],[20]을 비교해서 2의 자리에 [20]을 넣음
            //나머지를 3의 배열에 넣기
            //8개 짜리도 똑같이 하면됨
            */


            int[] array = new int[8] { 21,10,12,20,25,13,15,22};    
            Split(array);

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }






            #endregion
        }

    }

}

