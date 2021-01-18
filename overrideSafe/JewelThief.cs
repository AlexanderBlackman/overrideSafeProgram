using System;
using System.Collections.Generic;
using System.Text;

namespace overrideSafe
{
    class JewelThief: Locksmith
    {
        private string stolenJewels;


        new protected void ReturnContents(string safeContents, SafeOwner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($"I'm stealing the jewels! I stole: {stolenJewels}");
        }
    }
}
