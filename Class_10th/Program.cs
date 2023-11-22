namespace Class_10th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 숙제(등차수열) 
            //등차수열
            /*int firstTerm;          //첫항
            int commonDifferent;    //공차
            int size;

            //Console.ReadLine() : string 타입으로만 값 반환
            //string string1 = Console.ReadLine();
            //string string2 = Console.ReadLine();
            //firstTerm = Console.ReadLine();


            Console.Write("firstTerm :");
            firstTerm = Int32.Parse(Console.ReadLine());
            Console.Write("commonDifferent :");
            commonDifferent = Int32.Parse(Console.ReadLine());
            Console.Write("size :");
            size = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("name : " + string1);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(firstTerm + commonDifferent * i);
            }*/

            #endregion

            #region 등비 수열
            /*int i, j;
            int size;
            //int sub = 0;

            Console.Write("시작 수: ");
            i = Int32.Parse(Console.ReadLine());
            Console.Write("등비: ");
            j = Int32.Parse(Console.ReadLine());
            Console.Write("사이즈: ");
            size = Int32.Parse(Console.ReadLine());

            for (int a = 1; a <= size; a++)
            {
                //2시작 3등비 5사이즈 = 2 6 18 
                if (a == 1)
                {
                    sub += i;
                }
                else
                {
                    sub *= j;
                }

                Console.WriteLine(sub);
            }

            for (int a=0; a<size; a++)
            {
                Console.WriteLine(i);
                i *= j;
            }*/

            #endregion

            #region 무명 형식
            //이름이 존재하지 않는 객체 또는 변수를 의미함
            /*var data = new { Name = "Data", Value = 10 };

            //무명 형식의 경우 값을 읽기만 할 수 있음
            //data.Name = 200; => X

            Console.WriteLine(data.Name);
            Console.WriteLine(data.Value);*/

            #endregion
        }
    }
}