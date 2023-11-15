using System.Security.Cryptography.X509Certificates;

namespace ProgramCS
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
            UnitManager unit = new UnitManager();

            Marine marine = new Marine();
            Firebat firebat = new Firebat();

            unit.Command(marine);
            unit.Command(firebat);

            #endregion
        }

    }

}

