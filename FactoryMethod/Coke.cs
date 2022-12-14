using System;
using System.Drawing;

namespace FactoryMethod {

    class Coke : Drink {
        public override int GetCaffeineQuantity(){
            return 34;
        }
        public override int GetSugarQuantity(){
            return 35;
        }
        public override Color GetColor(){
            return Color.Black;
        }
        public override string GetName()
        {
            return "Coke";
        }
    }

}