using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    public class PrivateStudent : Student, StudentMethods
    {
        public PrivateStudent(string id, Fields field) : base(id, field)
        {
        }

        public void CalculateTuition(int coursesCount, int unitsNumber)
        {
            var tuitionPerUnit = 50;
            var tuition = coursesCount * unitsNumber * tuitionPerUnit;
            Tuition = tuition;
        }
    }
}
