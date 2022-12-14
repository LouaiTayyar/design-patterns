using System;
using System.Drawing;

namespace FactoryMethod {

    class DrPepper : Drink {
        public override int GetCaffeineQuantity(){
            return 41;
        }
        public override int GetSugarQuantity(){
            return 5;
        }
        public override Color GetColor(){
            return Color.Black;
        }
        public override string GetName()
        {
            return "DrPepper";
        }
    }

}