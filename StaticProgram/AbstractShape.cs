using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProgram
{
    abstract public class AbstractShape
    {
        public abstract void area();
    }
    public class Circle : AbstractShape
    {
        private int radius;
        private double result;
        public Circle(int radius)
        {
            this.radius=radius;
            
        }

        public override void area()
        {
            result = 3.14 * radius *radius;
        }
        public override string ToString()
        {
            return $"area of circle {result}";
        }
    }
}
