namespace Class_3rd
{
    #region 메소드 숨기기
    public class Weapon
    {
        protected int attack;   //상속을 걸었으니 private보다는 protected

        public void Inform()
        {
            Console.WriteLine("Weapon 정보");
        }

        public virtual void Action()
        {
            Console.WriteLine("Weapon의 동작");
        }
    }

    public class Sword : Weapon
    {
        //부모는 자식 상태를 모르지만 자식은 부모를 알기에 그래도 사용가능
        public new void Inform()
        {
            Console.WriteLine("Sword 정보");
            //C++에서 오버라이딩
        }

        public override void Action()
        {
            Console.WriteLine("Sword의 동작");
        }
    }


    #endregion

    #region 프로퍼티
    public class Transform
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            set
            {
                if (value >= 100)
                {
                    Console.WriteLine("예외값");
                    return;
                }
                x = value;
            }
            get { return x; }        //값 반환,get만 있다면 읽기 전용
            //return X 는 자기 자신을 여러번 호출하기 떄문에 무한 반복 (유니티에서 조심)

        }
    }
    #endregion

    #region 함수의 오버로딩
    public class GameObject
    {
        public void Destroy()
        {
            Console.WriteLine("Destroy GameObject");
        }

        public void Destroy(float timer)
        {
            Console.WriteLine("Destroy GameObject. " + "Destroy Time : " + timer + " Sec.");
        }

        public void GetComponent(string name, int id)
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("ID : " + id);
        }

        public void SetActive(bool active = true)
        {
            Console.WriteLine("GameObject State : " + active);
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //프로퍼티
            /*Transform transform= new Transform();
            transform.X = 555;

            Console.WriteLine(transform.X);*/

            //메소드 숨기기
            /*Sword sword = new Sword();
            sword.Inform();*/

            //가상 함수
            /*Weapon weapon = new Sword();
            weapon.Inform();
            weapon.Action();
            //weapon만 가리키기 때문에 가상함수를 선언해서 불러와야함
            */

            //함수의 오버로딩
            /*GameObject gameObject = new GameObject();
            gameObject.Destroy();
            gameObject.Destroy(5f);

            //명명된 매개 변수
            //gameObject.GetComponent(id: 5, name: "Sphere");
            //gameObject.GetComponent("Box", 10);

            //선택적 매개 변수
            //gameObject.SetActive();         //이미 True이기 때문에 안해도 됨
            //gameObject.SetActive(false);
            */
        }
    }
}