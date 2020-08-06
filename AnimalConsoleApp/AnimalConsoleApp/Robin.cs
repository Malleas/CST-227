using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConsoleApp
{
    class Robin : Animal
    {
        public virtual void Sing()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
