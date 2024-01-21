using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    abstract class ColoredFigure
    {
        protected string color;
        protected double size;

        public ColoredFigure(string color, double size)
        {
            this.color = color;
            this.size = size;
        }

        public string Color
        {
            get
            {
                return $"{color}";
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Color was not set");
                }
                color = value;
            }
        }
        public double Size
        {
            get
            {
                return size;
            }
            set
            {
                if (size <= 0)
                {
                    throw new ArgumentException("Number must be positive");
                }
                size = value;
            }
        }
        public void Show()
        {
            Console.WriteLine(" Color: {0}\n Size: {1}", color, size);
        }
        public abstract void GetName();
        public abstract void GetArea();
    }
}
