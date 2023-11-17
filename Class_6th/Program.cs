namespace Class_6th
{
    //SOLID
    //단일 책임 원칙
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP 5대 원칙 (단일 책임 원칙)
            //Monster horangi = new Monster("Horangi", 30, 200);
            //horangi.Patrol();

            //Inform monsterInfo= new Inform();
            //monsterInfo.MonsterInfo(horangi);
            #endregion

            #region OCP 5대 원칙
            //UnitManager unit = new UnitManager();

            //Marine marine = new Marine();
            //Firebat firebat = new Firebat();

            //unit.Command(marine);
            //unit.Command(firebat);

            #endregion

            #region ISP 5대 원칙
            //Valkyrie valkyrie= new Valkyrie();
            //BattleCruiser battleCruiser= new BattleCruiser();
            //Wraith wraith= new Wraith();
            //Dropship dropship= new Dropship();

            //valkyrie.Attack();
            //battleCruiser.Attack();
            //wraith.Attack();
            //Console.WriteLine();

            //valkyrie.Move();
            //battleCruiser.Move();
            //wraith.Move();
            //dropship.Move();
            //Console.WriteLine();

            //battleCruiser.Skill();
            //wraith.Skill();
            //dropship.Skill();


            #endregion

            #region DIP 5대 원칙
            //Player player = new Player(100, new Knife());
            //player.WeaponAct();

            //player.ChangeWeapon(new Rifle());
            //player.WeaponAct();

            //player.ChangeWeapon(new Granade());
            //player.WeaponAct();

            #endregion

            #region LSP 5대 원칙
            //Drone drone = new Drone();
            #endregion
        }
    }
}