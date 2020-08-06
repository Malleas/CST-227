﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConsoleApp
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }

        public void Greet()
        {
            Console.WriteLine("Animal Says Hello");
        }

        public void Talk()
        {
            Console.WriteLine("Animal Talking");
        }

        public virtual void Sing()
        {
            Console.WriteLine("Animal Song");
        }
    }
}
