using System;

namespace FactoryMethod {
    class MainClass{
        public static void Main (string[] args) {
            DrinkCreator? creator = null;

            // create a DrPepper drink
            Console.WriteLine ("Creating DrPepper");
            creator = new DrPepperCreator ();
            creator.MakeDrink();
            Console.WriteLine();

            // create a RedBull drink
            Console.WriteLine ("Creating RedBull");
            creator = new RedBullCreator ();
            creator.MakeDrink();
            Console.WriteLine();
        }
    }
}