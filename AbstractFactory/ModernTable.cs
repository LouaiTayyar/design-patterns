using System;

namespace AbstractFactory {
    class ModernTable : Table {
        public override void Dine()
            {
                Console.WriteLine("Modern Dining...");
            }
    }
}