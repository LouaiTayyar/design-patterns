using System;

namespace AbstractFactory {
    class VictorianChair : Chair
    {
        public override void Sit()
        {
            Console.WriteLine("Victorian Sitting...");
        }
    }
}