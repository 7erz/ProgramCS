namespace Class_5th
{
    public delegate void Calculator(int x, int y);
    internal class Program
    {
        static void Add(int x, int y)
        {
            Console.WriteLine(x + " + " + y + " = " + (x + y));
        }

        static void Substract(int x, int y)
        {
            Console.WriteLine(x + " - " + y + " = " + (x - y));
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x + " * " + y + " = " + (x * y));
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine(x + " / " + y + " = " + (x / y));
        }

        static void Main(string[] args)
        {
            #region 델리게이트 (delegate)
            //Calculator calculator;
            //calculator = Add;
            //calculator(5, 4);

            //calculator = Substract;
            //calculator(5, 4);
            #endregion

            #region 델리게이트 체인
            //calculator = Add;
            //calculator += Substract;
            //calculator += Multiply;
            //calculator += Divide;

            //calculator(5, 5);

            //calculator -= Divide;

            //calculator(5, 5);
            #endregion

            //SOH
            //small of heap : 85kb 미만의 객체

            //LOH
            //large of heap : 85kb 이상의 객체
            //힙을 안늘리는 선에서 작업해야 좋음

            #region base 키워드
            Wizard wizard = new Wizard();
            #endregion
        }
    }