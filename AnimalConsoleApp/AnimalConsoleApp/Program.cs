using System;

namespace AnimalConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
         //   Animal beast = new Animal();
         //
         //   beast.Talk();
         //   beast.Greet();
         //   beast.Sing();

            Dog emma = new Dog();

            emma.Talk();
            emma.Greet();
            emma.Sing();
            emma.fetch("ball");
            emma.FeedMe();
            emma.PetMe();
            Console.WriteLine();

            Robin red = new Robin();

            red.Talk();
            red.Greet();
            red.Sing();
            //red.Fetch("worm");
            //red.FeedMe();
            //red.PetMe();
            Console.WriteLine();

            Cow cow = new Cow();
            cow.Greet();
            cow.Talk();
            cow.MileMe();
            Console.WriteLine();

            Donkey donkey = new Donkey();
            donkey.Greet();
            donkey.Talk();
            donkey.RideMe();
            Console.WriteLine();

            Goat goat = new Goat();
            goat.Greet();
            goat.Talk();
            goat.MileMe();
            goat.RideMe();

            Console.ReadLine();


        }
    }
}
