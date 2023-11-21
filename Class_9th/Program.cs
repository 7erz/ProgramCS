using System.Collections;

namespace Class_9th
{
    public class Rifle : IEnumerator
    {

        private int index;
        private int[] bullet;

        public Rifle()
        {
            index = -1;
            bullet = new int[5];
        }
        //Current는 읽기 전용 프로퍼티로 현재 위치 데이터를 object 데이터로 반환
        public object Current
        {
            get
            {
                return bullet[index];
            }
        }
        //MoveNext는 다음 위치로 이동하는데 다음 위치에 데이터가 있다면 true, 없다면 false 반환
        public bool MoveNext()
        {
            index++;
            return index < bullet.Length;

        }
        //Reset은 인덱스를 초기 상태로 이동
        //컬렉션의 인덱스를 -1로 설정
        public void Reset()
        {
            index = -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 예외 처리
            //예외처리 1
            /*try
            {
                int data = 0;

                Console.WriteLine(100 / data);
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Error : 0으로는 나누지 못합니다.");
                Console.WriteLine(error.Message);
            }*/

            //예외처리 2
            /*try
            {
                int[] array = new int[3];

                array[3] = 555;     //오류

                Console.WriteLine("프로그램 시작");   //위에서 오류가 났기에 더이상 실행 되지 않음

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally     //무조건 실행
            {
                Console.WriteLine("프로그램 종료");
            }*/


            #endregion


            #region 열거자
            Rifle rifle = new Rifle();
            while (rifle.MoveNext())
            {
                Console.WriteLine(rifle.Current);
            }
            #endregion
        }
    }
}