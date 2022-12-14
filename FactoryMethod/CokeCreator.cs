using System;

namespace FactoryMethod {
    class CokeCreator : DrinkCreator {
        protected override Drink CreateDrink(){
            return new Coke();
        }
    }
}