using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCS
{
    internal class Resolution
    {
        const int width = 1440;     
        //런타임 상수는 생성자에서 단 한번 초기화를 할 수 있음
        readonly int height;        //데이터영역

        public Resolution()
        {
            //width = 1000;
            height = 3200;      //이후 초기화가 되지 않음
        }
    }
}
