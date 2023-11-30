using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14th
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
    }
}
