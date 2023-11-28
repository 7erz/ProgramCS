namespace ProgramCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 그래프
            //정점(Vertex)과 간선(Edge)들이 서로 복잡하게 연결되어 있는 자료구조

            //정점(Vertex)
            //노드라고도 하며, 데이터가 저장되는 그래프의 기본 원소

            //간선(Edge)
            //링크(link)라고도 하며, 정점 간의 관계를 나타냄

            //인접 정점(adjacent vertex)
            //하나의 정점에서 간선에 의해 직접 연결되어 있는 정점
            //[C] <=> [D]

            //차수 (Degree)
            //정점에 연결되어 있는 간선의 수를 의미

            //진입 차수
            //외부에서 오는 간선의 수

            //진출 차수
            //외부로 향하는 간선의 수

            //단순 경로
            //경로 중에서 반복되는 간선이 없는 경로

            //사이클(cycle)
            //시작 정점과 종료 정점이 같은 단순 경로
            #endregion

            #region 인접 행렬
            /*AdjacencyMatrix<char> adjacencyMatrix = new AdjacencyMatrix<char>(4);

            adjacencyMatrix.InsertVertex('A');
            adjacencyMatrix.InsertVertex('B');
            adjacencyMatrix.InsertVertex('C');
            adjacencyMatrix.InsertVertex('D');


            adjacencyMatrix.InsertEdge(0, 1);
            adjacencyMatrix.InsertEdge(0, 2);
            adjacencyMatrix.InsertEdge(0, 3);
            adjacencyMatrix.InsertEdge(1, 2);
            adjacencyMatrix.InsertEdge(2, 3);

            adjacencyMatrix.Display();*/

            #endregion

            #region 인접 리스트
            AdjacencyList<char> adjacencyList = new AdjacencyList<char>(5);

            adjacencyList.AddVertex('A');
            adjacencyList.AddVertex('B');
            adjacencyList.AddVertex('C');
            adjacencyList.AddVertex('D');
            adjacencyList.AddVertex('E');

            adjacencyList.AddList(0, 'B');
            adjacencyList.AddList(1, 'A');
            adjacencyList.AddList(1, 'C');
            adjacencyList.AddList(2, 'B');
            adjacencyList.AddList(2, 'D');
            adjacencyList.AddList(3, 'C');
            adjacencyList.AddList(3, 'E');
            adjacencyList.AddList(4, 'E');

            adjacencyList.Display();


            #endregion
        }
    }
}

