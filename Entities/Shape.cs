﻿using AbstractMethods1.Entities.Enums;

namespace AbstractMethods1.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
