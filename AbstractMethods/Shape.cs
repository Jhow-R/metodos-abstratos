using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods
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

    enum Color : int
    {
        Black = 0,
        Blue = 1,
        Red = 2
    }
}
