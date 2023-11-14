using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4th
{
    public abstract class Unit        //추상 클래스
    {
        int health;
        int attack;
        int defense;

        public virtual void Inform()
        {
            Console.WriteLine("health : " + health);
            Console.WriteLine("attack : " + attack);
            Console.WriteLine("defense : " + defense);
        }
        public abstract void Skill();

    }
}
