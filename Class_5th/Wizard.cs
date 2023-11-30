using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5th
{
    internal class Wizard : Job
    {
        int attack = 100;
        //this 와 base 키워드 중에서는 this 키워드가 우선 순위가 더 높다.

        public Wizard() : base(100)
        {
            Console.WriteLine("attack의 값 : " + base.attack);
            Console.WriteLine("health의 값 : " + health);
        }
    }
}
