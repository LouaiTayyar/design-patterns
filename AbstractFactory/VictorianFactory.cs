using System;

namespace AbstractFactory {
    class VictorianFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new VictorianChair();
        }

        public override Table CreateTable()
        {
             return new VictorianTable();
        }
    }
}