using System;

namespace AbstractFactory {
    class VictorianTable : Table {
        public override void Dine()
            {
                Console.WriteLine("Victorian Dining...");
            }
    }
}