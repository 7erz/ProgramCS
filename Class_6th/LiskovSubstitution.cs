using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgramCS.Zerg;

namespace Class_6th
{
    #region 리스코프 치환 원칙
    //상위 클래스와 하위 클래스가 있을 때
    //상위 클래스가 호출하는 동작에서 하위 클래스가
    //상위 클래스를 완벽하게 대체할 수 있어햐 하는 원칙

    public abstract class Zerg
    {
        protected int attack;
        protected int defense;

        public abstract void Move();

        public class GroundUnit : Zerg
        {
            public GroundUnit(int attack, int defense)
            {
                this.attack = attack;
                this.defense = defense;

            }
            public void Ground()
            {
                Console.WriteLine("On the Ground");
            }

            public override void Move()
            {
                Ground();
                Console.WriteLine("Move");
            }
        }

        public class FlyUnit : Zerg
        {
            public override void Move()
            {
                throw new NotImplementedException();
            }
        }
    }

    public class Drone : GroundUnit
    {
        public Drone() : base(10, 5)
        {
            base.Move();
        }
    }

    #endregion
}
