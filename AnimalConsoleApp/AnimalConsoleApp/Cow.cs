using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConsoleApp
{
    class Cow : Animal, IMilkable
    {
        public void MileMe()
        {
            Console.WriteLine("Milk, it does the body good!");
        }

        public new void Talk()
        {
            Console.WriteLine("MOOOOOOOO!!!");
        }


    }
}
