using System;

namespace FactoryMethod {
    class DrPepperCreator : DrinkCreator {
        protected override Drink CreateDrink(){
            return new DrPepper();
        }
    }
}