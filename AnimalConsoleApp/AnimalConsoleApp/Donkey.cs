using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConsoleApp
{
    class Donkey : Animal, IRidable
    {
        public void RideMe()
        {
            Console.WriteLine("I'm stuborn, but you can try to ride me.");
        }

        public new void Talk()
        {
            Console.WriteLine("HEE HAW!!!");
        }
    }
}
