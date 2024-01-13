using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    public class PublicStudent : Student, StudentMethods
    {
        public PublicStudent(string id, Fields field) : base(id, field)
        {
        }



        public void CalculateTuition(int coursesCount, int unitsNumber)
        {
            var tuitionPerUnit = 10;
            var tuition = coursesCount * unitsNumber * tuitionPerUnit;
            Tuition = tuition;
        }
    }
}
