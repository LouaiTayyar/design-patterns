using System;

namespace AbstractFactory {
    class MainClass{
        public static void Main (string[] args) {

            FurnitureFactory? factory = null;

            // Create Modern Furniture
            factory = new ModernFactory();
            Chair chairModern = factory.CreateChair();
            Table tableModern = factory.CreateTable();
            chairModern.Sit();
            tableModern.Dine();

            // Create Victorian Furniture
            factory = new VictorianFactory();
            Chair chairVictorian = factory.CreateChair();
            Table tableVictorian = factory.CreateTable();
            chairVictorian.Sit();
            tableVictorian.Dine();


        }
    }
}