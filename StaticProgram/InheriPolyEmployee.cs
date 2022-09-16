using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProgram
{
    public class InheriPolyEmployee
    {
        private int id;
        private static int count = 0;
        private string name;
        private double bs, hra, da, pt, pf, total, netpaid;
        public InheriPolyEmployee(string name, double bs, double pt)
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
        public virtual void CalculateSalary() // instance / object method
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
        public class Manager : InheriPolyEmployee
        {
            private double ta;
            
            public Manager(string name, double bs, double pt, double ta) : base(name, bs, pt) // call constructor of base class
            {
                this.ta = ta;
            }
            public override void CalculateSalary()
            {
                hra = bs * 0.40;
                da = bs * 0.20;
                pf = bs * 0.12;
                total = bs + hra + da+ta;
                netpaid = total - (pf + pt);
            }
            public override string ToString()
            {
                return $"Manager Id {id} Manager name {name} , total salary {total} & Net paid {netpaid}";
            }
        }

        public class SalesManager  : InheriPolyEmployee
        {
            private double comm, bonus;
            public SalesManager(string name,double bs,double pt,double comm,double bonus) : base(name,bs,pt)
            {
                    this.comm = comm;
                    this.bonus = bonus;
            }
            public override void CalculateSalary() // instance / object method
            {
                hra = bs * 0.40;
                da = bs * 0.20;
                pf = bs * 0.12;
                total = bs + hra + da;
                netpaid = total - (pf + pt);
            }
            public override string ToString()
            {
                return $"Manager Id {id} Manager name {name} , total salary {total} & Net paid {netpaid}";
            }
            
        }
    }
}
