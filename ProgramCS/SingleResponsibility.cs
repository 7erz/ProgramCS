using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCS
{
    #region 단일 책임 원칙 (SRP)
    //하나의 객체는 반드시 하나의 동작만을 수행해야 함
    public class Monster
    {
        private string name;
        private int attack;
        private int health;

        public Monster(string name, int attack, int health) {
            this.name = name;
            this.attack = attack;
            this.health = health;
        }

        public void Patrol()
        {
            Console.WriteLine("순찰중...");

        }
        public string Representation()
        {
            return "name : " + name + " attack : " + attack + " health : " + health;
        }

    }
    #endregion
}
