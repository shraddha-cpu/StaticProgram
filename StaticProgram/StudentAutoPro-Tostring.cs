using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProgram
{
    internal class StudentAutoPro_Tostring
    {
        public int Rollno{get; set;}
        public string Name{get; set;}
        public string Faculty{get; set;}
        public float Total { get; set; }
        public float per { get; set; }

        public StudentAutoPro_Tostring(int Rollno,string Name,string Faculty)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this.Faculty=Faculty;
        }
        public void CalculatePer()
        {
            Total=55+66+77+88;
            per=Total/4;
        }

        public override string ToString()
        {
            return $"Rollno ->{Rollno} Name ->{Name} Faculty ->{Faculty} Total ->{Total} percentage ->{per}" ;
        }
    }
}
