using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConsoleApp
{
    class Dog : Animal, IDomesticated
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor.  Who's a good boy!");
        }

        public new void Talk()
        {
            Console.WriteLine("Bark Bark Bark");
        }

        public override void Sing()
        {
            Console.WriteLine("Hooowwwl!");
        }
        public void fetch(string thing)
        {
            Console.WriteLine("Oh boy, here is your " + thing + ".  Let's do it again!");
        }

        public void PetMe()
        {
            Console.WriteLine("Please rub my belly");
        }

        public void FeedMe()
        {
            Console.WriteLine("It's suppertime, the very bestest time of the day!!!");
        }
    }
}
