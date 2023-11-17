using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    #region 의존관계 역전 원칙
    //상위 계층이 하위 계층에 의존하는 전통적인 관계를
    //반전시킴으로써 상위 계층이 하위 계층의 구현으로부터
    //독립될수 있도록 설계하는 원칙

    public abstract class Weapon
    {
        protected int attack;
        protected string name;

        public Weapon(int attack, string name)
        {
            this.attack = attack;
            this.name = name;
        }

        public abstract void Weaponable();
        public abstract void Action();

        public int Attack
        {
            get { return attack; }
        }
        public string Name
        {
            get { return name; }
        }

    }
    public class Rifle : Weapon
    {
        public Rifle() : base(34,"Rifle")
        {

        }
        public override void Weaponable()
        {
            Console.WriteLine("Rifle");
        }
        public override void Action()
        {
            Console.WriteLine("Shooting Rifle");
        }

    }
    public class Knife : Weapon
    {
        public Knife() : base(45, "Knife")
        {

        }
        public override void Weaponable()
        {
            Console.WriteLine("Knife");
        }
        public override void Action()
        {
            Console.WriteLine("Stabbing Knife");
        }
    }
    public class Granade : Weapon
    {
        public Granade() : base(150, "Granade")
        {

        }
        public override void Weaponable()
        {
            Console.WriteLine("Granade");
        }
        public override void Action()
        {
            Console.WriteLine("Throw Granade");
        }
    }

    public class Player
    {
        private int health;
        private Weapon weapon;

        public Player(int health, Weapon weapon)
        {
            this.health = health;
            this.weapon = weapon;
            ShowStat(weapon);
        }

        public void ChangeWeapon(Weapon weapon)
        {
            this.weapon = weapon;
            ShowStat(weapon);
        }

        public void WeaponAct()
        {
            weapon.Action();
        }

        public void ShowStat(Weapon weapon)
        {
            Console.WriteLine("Current Weapon : " + weapon.Name);
            Console.WriteLine("Current Damage : " + weapon.Attack);
        }

    }

    #endregion
}
