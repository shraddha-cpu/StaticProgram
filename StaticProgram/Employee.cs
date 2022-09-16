using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StaticProgram
{
    internal class Employee
    {
        private int id;
        private static int count = 0;
        private string name;
        private double bs, hra, da, pt, pf, total, netpaid;
        public Employee(string name, double bs, double pt)
        {
            count++;
            id= count;
            this.name = name;
            this.bs = bs;
            this.pt = pt;
        }
        public static int DisplayCount() // static
        {
            return count;
        }
        public void CalculateSalary() // instance / object method
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da;
            netpaid = total - (pf + pt);
        }
           public string Print()
           {
               return $"EMployee Id {id} Employee name {name} , total salary {total} & Net paid {netpaid}";

           } 
      /*  public override string ToString()
        {
            return $"EMployee Id {id} Employee name {name} , total salary {total} & Net paid {netpaid} ";

        }
      */
    }
}