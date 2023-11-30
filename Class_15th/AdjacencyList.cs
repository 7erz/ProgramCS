using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Class_15th
{
    internal class AdjacencyList//<T>
    {
        //나의 답
        /*int size;
        T[] vertex; 
        //그래프의 인접 리스트
        List<T>[] adjacencyList;

        public AdjacencyList(int size)
        {
            vertex = new T[size];
            adjacencyList = new List<T>[size];

            for (int i = 0; i < size; i++)
            {
                adjacencyList[i] = new List<T>(); // 각 정점의 인접 리스트 초기화
            }
        }

        public void AddVertex(T vertexData)
        {
            vertex[size++] = vertexData;
        }
        public void AddList(int array, T data)
        {
            adjacencyList[array].Add(data);
        }

        public void Display()
        {

        }*/

        //정답
        int size;
        List<int>[] adjacencyList;


        public AdjacencyList(int vertexSize)
        {
            size = vertexSize;
            adjacencyList= new List<int>[vertexSize];

            for(int i =0;i<vertexSize;i++)
            {
                adjacencyList[i]= new List<int>();      //인덱스의 리스트 만들기
            }
        }

        public void InsertEdge(int vertex, int edge)
        {
            adjacencyList[vertex].Add(edge);
        }

        public void BFS(int root)
        {
            //방문한 노드를 추적하기 위한 배열
            bool[] visited = new bool[size];

            //Queue컬렉션 선언
            Queue<int> queue = new Queue<int>();


            //queue에 루트 노드 넣기
            queue.Enqueue(root);
            visited[root] = true;
            
            //빌때까지 반복
            while(queue.Count != 0) {
                //데이터 뽑기
                int index = queue.Dequeue();
                //뽑은 데이터 출력
                Console.Write(index + " ");
                //인접한 데이토 큐에 넣기
                for(int i = 0; i < adjacencyList[index].Count; i++)
                {
                    if (visited[adjacencyList[index][i]] == false)
                    {
                        visited[adjacencyList[index][i]] = true;

                        queue.Enqueue(adjacencyList[index][i]);
                    }
                }
            }


        }

        public void DFS(int root)
        {
            bool[] visited = new bool[size];
            visited[root] = true;
            Stack<int> stack = new Stack<int>();
            stack.Push(root);


            while (stack.Count != 0)
            {
                int num = stack.Pop();
                Console.Write(num + " ");
                for (int i = 0; i < adjacencyList[root].Count; i++)
                {

                    if (visited[adjacencyList[root][i]] == false)   //1이 vistied 아니라면
                    {
                        visited[adjacencyList[root][i]] = true;     //1을 visited로 만들고
                        DFS(adjacencyList[root][i]);                //1을 재귀함수 돌림
                    }
                }

            }
        }

        public void DFS2(int root)
        {
            bool[] visited = new bool[size];
            //현재 노드를 방문한 것으로 표시
            visited[root] = true;

            //현재 노드 출력
            Console.Write(root + " ");

            //현재 노드와 연결된 방문하지 않는 노드를 재귀적으로 탐색
            foreach(int index in adjacencyList[root])
            {
                if (visited[index] == false)
                {
                    DFS(index);
                }
            }
        }




        public void Display()
        {
            for(int i = 0; i < size;i++)
            {
                for (int j = 0; j < adjacencyList[i].Count; j++)
                {
                    Console.Write(adjacencyList[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Show(int data1, int data2)
        {
            Console.WriteLine(adjacencyList[data1][data2]);
        }
    }
}
