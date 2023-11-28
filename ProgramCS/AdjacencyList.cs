using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCS
{
    internal class AdjacencyList<T>
    {
        int size;
        T[] vertex; 
        //그래프의 인접 리스트
        List<T>[] adjacencyList;

        public AdjacencyList(int size)
        {
            this.size = size; // 클래스 멤버 size에 매개변수 값 할당
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
            foreach (T vertex in vertex)
            {
                Console.WriteLine(vertex);
            }
        }
    }
}
