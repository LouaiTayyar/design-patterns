using System;

namespace AbstractFactory {
    abstract class FurnitureFactory {
        public abstract Chair CreateChair();
        public abstract Table CreateTable();

    }
}