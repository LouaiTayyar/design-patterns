using System;

namespace FactoryMethod {
    class RedBullCreator : DrinkCreator {
        protected override Drink CreateDrink(){
            return new RedBull();
        }
    }
}