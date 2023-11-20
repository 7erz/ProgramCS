using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ProgramCS
{
    public class GameObject
    {
        private string name;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }


    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region 콜렉션
            //arrayList : 모든 타입을 다 받을 수 있음 (박싱, 언박싱이 일어남)
            /*ArrayList arrayList = new ArrayList();

            arrayList.Add(101);
            arrayList.Add("String");
            arrayList.Add(56.4f);
            arrayList.Add('A');

            foreach(object item in arrayList)
            {
                Console.WriteLine(item);
            }

            // 0     1      2       3
            //[10]["String"][56.4f]['A']
            Console.WriteLine();
            arrayList.Remove(56.4f);
            Console.WriteLine("arrayList Count : " + arrayList.Count);

            foreach (object item in arrayList)
            {
                Console.WriteLine(item);
            }*/


            //List : 
            /*List<int> list = new List<int>();

            //capacity를 늘려놔야함
            list.Capacity = 10;
            //[] [] [] [] [] [] [] [] [] []   -> 10개

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(15);

            list.Remove(40);        //[3]
            list.RemoveAt(2);       //30

            //list.Reverse();       반전

            //list.Sort();          정렬

            for(int i = 0; i< list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }*/


            //Random 클래스
            /*Random random = new Random();
            int rand = random.Next(0, 10);

            Console.WriteLine(rand);*/


            //과제
            /*List<string> list = new List<string>();
            Random random= new Random();

            int rnd = random.Next(0,list.Count);
            list.Capacity = 5;

            list.Add("메이플");
            list.Add("콜옵");
            list.Add("FC 온라인");
            list.Add("스타");
            list.Add("카스");


            for(int i =0;i<list.Capacity;i++)
            {
                if (list[rnd] != null)
                {
                    Console.WriteLine(list[rnd]);
                    list.Remove(list[rnd]);
                }

            }

            //while(list.Count != 0)
            //{
            //    int rand = random.Next(0,list.Count);

            //    Console.WriteLine(list[rand]);

            //    list.RemoveAt(rand);
   
            //}*/


            //LinkedLIst :
            /*LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);    //맨 앞에 놓음
            linkedList.AddFirst(30);    //맨 앞에 놓음

            linkedList.AddLast(100);    //맨 뒤에 놓음

            //[30] [20] [10] [100]

            foreach(int i in linkedList)
            {
                Console.WriteLine(i);
            }*/


            //Stack
            /*Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            stack.Pop();    //가장 위의 데이터 삭제

            //FILO
            Console.WriteLine("Stack Peek : " + stack.Peek());  //가장 위의 데이터 반환

            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }*/


            //Queue
            Queue<GameObject> queue= new Queue<GameObject>();
            string[] objName = new string [4]  { "Cube", "Sphere","Cylinder","Capsule"};

            queue.Enqueue(new GameObject());        //[]
            queue.Enqueue(new GameObject());        //[] []
            queue.Enqueue(new GameObject());        //[] [] []
            queue.Enqueue(new GameObject());        //[] [] [] []

            int queueSize = queue.Count;

            for(int i = 0; i< queueSize; i++)
            {
                GameObject gameObject = queue.Dequeue();
                gameObject.Name = objName[i];

                Console.WriteLine(gameObject.Name);
            }
            //Dequeue한다고 삭제가 아니라 그 데이터를 뽑아버린 것
            Console.WriteLine("Queue Count : " + queue.Count);
            

            //queue.Dequeue();
            //Console.WriteLine("Queue Count : " + queue.Count);


            //Dictionary(Key) - HashTable(Value)

            #endregion
        }

    }

}

