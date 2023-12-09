using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Ex04
{
    class Rectangle
    {
        private int length;
        private int breadth;
        private int height;

        public int GetArea()
        {
            return length * breadth * height;
        }

        public void SetBreadth(int breadth)
        {
            this.breadth = breadth;
        }

        public void SetLength(int length)
        {
            this.length = length;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public static Rectangle operator + (Rectangle a, Rectangle b)
        {
            Rectangle r = new Rectangle();

            r.length = a.length + b.length;
            r.breadth = a.breadth + b.breadth;
            r.height = a.height + b.height;

            return r;
        }
    }
}
