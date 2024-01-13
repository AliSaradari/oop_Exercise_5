using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    public class Course
    {
        public Course(string name,int units)
        {
            Name = name;
            Units = units;
        }
        public string Name { get; set; }
        public int Units {  get; set; }

    }
}
