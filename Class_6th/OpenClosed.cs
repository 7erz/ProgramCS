using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    #region 개방 폐쇄 원칙
    //객체의 확장은 열려있어야 하며, 객체의 수정에는 닫혀있어야 함

    //추가는 쉽게, 기존에 있던 코드를 수정하지 않고 확장이 되어야 함
    public class UnitManager
    {
        public void Command(Unit unit)
        {
            unit.Move();
        }
    }

    public abstract class Unit {
        protected int health;
        protected int defense;
        public abstract void Move();
    }

    public class Marine : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Marine Moving...");
        }

    }

    public class Firebat : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Firebat Moving...");
        }

    }


    #endregion
}
