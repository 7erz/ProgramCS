﻿namespace Class_15th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BFS (너비 우선 탐색)
            //root 노드에서 시작해서 인접한 노드를 먼저 탐색하는 방법 (Queue)
            /*AdjacencyList adjacencyList = new AdjacencyList(7);

            adjacencyList.InsertEdge(0, 1);
            adjacencyList.InsertEdge(0, 2);

            adjacencyList.InsertEdge(1, 3);
            adjacencyList.InsertEdge(1, 4);

            adjacencyList.InsertEdge(2, 5);
            adjacencyList.InsertEdge(2, 6);


            adjacencyList.BFS(0);

            //adjacencyList.Show(0, 1);
            //adjacencyList.Show(1, 1);
            //adjacencyList.Show(2, 1);
            //adjacencyList.Show(3, 3);*/
            #endregion


            #region DFS (깊이 우선 탐색)
            //root 노드에서 시작해서 다음 분기로 넘어가기 전에 해당 분기를 완벽하게 탐색하는 방법 (Stack)
            /*AdjacencyList adjacencyList = new AdjacencyList(7);

            adjacencyList.InsertEdge(0, 1);
            adjacencyList.InsertEdge(0, 2);

            adjacencyList.InsertEdge(1, 3);
            adjacencyList.InsertEdge(1, 4);

            adjacencyList.InsertEdge(2, 5);
            adjacencyList.InsertEdge(2, 6);

            adjacencyList.DFS(0);
            Console.WriteLine();
            adjacencyList.DFS2(0);*/
            #endregion
        }
    }
}