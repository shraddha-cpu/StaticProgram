using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StaticProgram
{
    internal class StudentProperties
    {
        private int rollno;
        private int total;
        private string name;
        private double per;

        // use property to assign & retrieve value from the data member
        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; } // value is a built in keyword which assign value
        }
        public string Name
        {
            get { return name; }
            set { name = "value"; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public double Per
        {
            get { return per; }
            set { per = per; }
        }

        public StudentProperties(int rollno,string name,int total,double per)
        {
            this.Rollno = rollno;
            this.name=name;
            this.total=total;
            this.per=per;
        }

       public override string ToString()
        {
            return $" Rollno ->{Rollno} name -> {Name} total ->{Total} per ->{Per}";

        } 
      
    }
}
