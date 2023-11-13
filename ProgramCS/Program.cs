namespace ProgramCS
{
    public class GameObject
    {
        private int guID;

        public int GUID
        {
            set { guID = value; }
            get { return guID; }
        }

        public GameObject Clone()       //깊은 복사
        {
            //1.class를 생성
            GameObject gameObject = new GameObject();
            //2.class안에 있는 데이터를 넣어줌
            gameObject.guID = guID;
            //3.class 반환
            return gameObject;
        }

    }

    public interface IItem
    {
        void Use();
    }

    public interface IWaitTime
    {
        void Wait(float timer);       //매개 변수 사용 가능
    }

    public class Player
    {
        public void OnTriggerEnter(IItem item)
        {
            item.Use();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 얕은 복사
            /*GameObject gameObject1 = new GameObject();
            GameObject gameObject2 = gameObject1;

            gameObject2.GUID = 99;

            Console.WriteLine("gameObject1.guID : " + gameObject1.GUID);
            Console.WriteLine("gameObject2.guID : " + gameObject2.GUID);*/
            #endregion

            #region 깊은 복사
            //GameObject clone1 = new GameObject();

            //GameObject clone2 = clone1.Clone();

            //clone1.GUID= 1;
            //clone2.GUID= 2;

            //Console.WriteLine("clone1.GUID : " + clone1.GUID);
            //Console.WriteLine("clone2.GUID : " + clone2.GUID);
            #endregion

            #region 인터페이스
            /*Player player = new Player();       //이런게 인스턴스

            //인터페이스는 참조 변수를 선언할 수 있지만 
            //인스턴스를 생성할 수는 없음
            IItem items;        //인스턴스가 아니라 인터페이스를 가리키는 참조 변수

            player.OnTriggerEnter(new Magnet());
            player.OnTriggerEnter(new Missile());
            player.OnTriggerEnter(new Shield());*/



            #endregion

            #region 추상 클래스
            //abstract void Function();
            //함수 변수 다 작성 가능함
            //abstract는 자식에서 다 재정의 해야함
            //예)
            //속성:
            //int data
            //기능:
            //abstract();   //참조변수로만 사용가능

            juggling juggling = new juggling();
            juggling.Skill();

            #endregion
        }
    }
}

