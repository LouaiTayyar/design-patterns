using System;

namespace AbstractFactory {
    class ModernFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new ModernChair();
        }

        public override Table CreateTable()
        {
             return new ModernTable();
        }
    }
}