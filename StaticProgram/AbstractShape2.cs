using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProgram
{
    abstract public class AbstractShape2
    {
         
        public abstract void area();
    }
    public class Rectangle : AbstractShape2
    {
        private int length;
        private int breadth;
        private double result;
        public Rectangle(int length,int breadth )
        {
            this.length = length;
            this.breadth = breadth;

        }

        public override void area()
        {
            result = 2 *(length=breadth);
        }
        public override string ToString()
        {
            return $"area of circle {result}";
        }
    }
}

