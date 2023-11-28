using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCS
{
    internal class AdjacencyMatrix<T>
    {
        //속성
        //정점의 수 (size)
        int size;
        //정점의 이름(vertex)
        T[] vertex;
        //인접행렬 여부(2차원 배열)
        int[,] matrix;


        public AdjacencyMatrix(int matrixSize)
        {
            vertex = new T[matrixSize];
            matrix = new int[matrixSize, matrixSize];
        }
        public void InsertVertex(T data)
        {
            vertex[size++] = data;
        }

        public void InsertEdge(int x, int y)
        {
            matrix[x, y] = 1;
            matrix[y, x] = 1;
        }

        public void Display()
        {
            Console.WriteLine(size);

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j <size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
