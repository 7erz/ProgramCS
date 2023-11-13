namespace ProgramCS
{
    public class Shield : IItem, IWaitTime      //다중 상속이 되었음
    {
        public void Use()
        {
            Console.WriteLine("Use Shield");
        }

        public void Wait(float timer)
        {
            Console.WriteLine("Wait Time : " + timer);
        }
    }
}
