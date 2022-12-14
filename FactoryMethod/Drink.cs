using System;
using System.Drawing;

namespace FactoryMethod {

    abstract class Drink {
        public abstract int GetCaffeineQuantity();
        public abstract int GetSugarQuantity();
        public abstract Color GetColor();
        public abstract string GetName();
    }

}