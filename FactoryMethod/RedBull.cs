using System;
using System.Drawing;

namespace FactoryMethod {

    class RedBull : Drink {
        public override int GetCaffeineQuantity(){
            return 30;
        }
        public override int GetSugarQuantity(){
            return 10;
        }
        public override Color GetColor(){
            return Color.Yellow;
        }
        public override string GetName()
        {
            return "RedBull";
        }
    }

}