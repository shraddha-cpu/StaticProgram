using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static StaticProgram.InheriPolyEmployee;

namespace StaticProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Employee emp1 = new Employee("test1", 27000, 200);
                emp1.CalculateSalary();
                Console.WriteLine(emp1.Print());

                Employee emp2 = new Employee("test2", 27500, 200);
                emp2.CalculateSalary();
                Console.WriteLine(emp2.Print());

                Employee emp3 = new Employee("test2", 24500, 200);
                emp3.CalculateSalary();
                Console.WriteLine(emp3.Print());  */



            // class method */

            // (property initializer syntax)
            /*   CourseProperties c1=new CourseProperties();
                  c1.Id = 1;   // set accessor get called & assign the value
                  c1.Name = "C#";
                  c1.Fees = 20000;

                  Console.WriteLine($"Id {c1.Id} {c1.Name} {c1.Fees}"); */

            // (ToString)
            /*  CourseProperties c1 = new CourseProperties(11,"rava",8000);
              Console.WriteLine(c1);
              CourseProperties c2 = new CourseProperties(13, "meena", 7800);
              Console.WriteLine(c2); */




            // (student)

            /*    StudentProperties s1=new StudentProperties();
                 s1.Rollno =1;
                 s1.Name = "shraddha";
                 s1.Total = 70+45+65;
                 s1.Per =  180/3;

                 Console.WriteLine($"student \n roll no is {s1.Rollno} \n name is {s1.Name} \n total is {s1.Total} \n precentage is {s1.Per}"); 
             */
            //(ToString)
            /*    StudentProperties s1 = new StudentProperties(11, "tina",50+50+50,150/300*100); 
                   Console.WriteLine(s1.ToString());
              */




            //Manager m1 = new Manager("managar1", 45000, 250, 5000);
            //m1.CalculateSalary();
            //Console.WriteLine(m1);

            /*  InheriPolyEmployee e1 = new Manager("managar2", 43000, 250, 5000);
              // association of method with object does at run time
              e1.CalculateSalary(); // runtime polymorphism
              Console.WriteLine(e1);
            */



         /*   StudentAutoPro_Tostring s1 = new StudentAutoPro_Tostring(1,"sham","compscience");
            s1.CalculatePer();
            Console.WriteLine(s1);  
         */


            //(circle-abstract)
        /*    AbstractShape shape1 =new AbstractShape(4);
         *    shape1.area;
            Console.WriteLine(shape1);
          */

         /*   //(rectangle-abstract)
            AbstractShape2 shape1 = new AbstractShape2(4,6);
            shape1.area();
            Console.WriteLine(shape1);
         */


        }
    }
}
