using System;
using System.Drawing;

namespace FactoryMethod {

    abstract class DrinkCreator {
        protected abstract Drink CreateDrink();

        public void MakeDrink(){
            Drink drink = CreateDrink();
            int miligrams = drink.GetCaffeineQuantity();
            PrepareContainer(drink);
            AddCaffeine(miligrams);
            int grams = drink.GetSugarQuantity();
            AddSugar(grams);
            Color color = drink.GetColor();
            AddColor(color);
        }

        public void PrepareContainer(Drink drink) {
            Console.WriteLine ("Preparing container for " + drink.GetName());
        }

        public void AddCaffeine(int miligrams) {
            Console.WriteLine ("Adding " + miligrams + " miligrams of caffeine.");
        }

        public void AddSugar(int grams) {
            Console.WriteLine ("Adding " + grams + " grams of Sugar.");
        }

        public void AddColor(Color color) {
            Console.WriteLine ("Adding " + color + " food coloring.");
        }


    }
}