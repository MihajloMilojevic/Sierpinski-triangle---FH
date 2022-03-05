using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sierpinski_triangle
{
    class Triangle
    {
        private PointF a, b, c;
        public Triangle(PointF A, PointF B, PointF C)
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }
        public PointF A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        public PointF B
        {
            get { return this.b; }
            set { this.b = value; }
        }
        public PointF C
        {
            get { return this.c; }
            set { this.c = value; }
        }
        public PointF[] toArray()
        {
            PointF[] ret = { this.a, this.b, this.c };
            return ret;
        }
    }
}
