using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramCS
{
    public class Inform
    {
        public void MonsterInfo(Monster monster)
        {
            Console.WriteLine(monster.Representation());
        }
    }
}
