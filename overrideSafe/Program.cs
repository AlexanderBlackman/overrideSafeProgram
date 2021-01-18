using System;

namespace overrideSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            SafeOwner owner = new SafeOwner();
            Safe safe = new Safe();

            Locksmith calledAsLocksmith = new JewelThief();
            calledAsLocksmith.ReturnContents(safeContents, owner);

            JewelThief thief = new JewelThief();

             thief.ReturnContents(safe, owner);

            Console.ReadKey(true);
        }
    }
}
