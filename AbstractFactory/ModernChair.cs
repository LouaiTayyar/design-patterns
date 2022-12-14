using System;

namespace AbstractFactory {
    class ModernChair : Chair
    {
        public override void Sit()
        {
            Console.WriteLine("Modern Sitting...");
        }
    }
}