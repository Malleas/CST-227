using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConsoleApp
{
    class Goat : Animal, IRidable, IMilkable
    {
        public void MileMe()
        {
            Console.WriteLine("Goat Cheese > regular cheese");
        }

        public void RideMe()
        {
            Console.WriteLine("Kids ride me at the rodeo and petting farms...not a fan.");
        }

        public new void Talk()
        {
            Console.WriteLine("Bleat, Bleat, Bleat...sounds like i'm cussing doesn't it.");
        }
    }
}
