namespace ProgramCS
{
    public class Magnet : IItem, IWaitTime
    {
        public void Use()
        {
            Console.WriteLine("Use Magnet");
        }

        public void Wait(float timer)
        {
            Console.WriteLine("Wait Time : " + timer);
        }
    }
}
