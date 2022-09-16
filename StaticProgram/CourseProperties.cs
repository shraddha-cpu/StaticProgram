using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProgram
{
    internal class CourseProperties
    {
            private int id;
            private string name;
            private double fees;

            // use property to assign & retrieve value from the data member
            public int Id
            {
                get { return id; }
                set { id = value; } // value is a built in keyword which assign value
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Fees
            {
                get { return fees; }
                set { fees = value; }
            }
        public CourseProperties( int id,string name,double fees)
        {
            this.id=id;
            this.name=name;
            this.fees=fees;    
        }
        public override string ToString()
        {
            return $"Id ->{Id} Name ->{Name} Fees ->{Fees}";
        }
    }
}
