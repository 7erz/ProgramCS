using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_7th
{
    internal class Deque <T>     //<T> 모든 타입을 다 받을 수 있음
    {
        private T data;

        public void Set(T data)
        {
            this.data = data;
        }
    }
}
