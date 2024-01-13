using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    public static class University
    {
        private static List<Student> _students = new List<Student>();

        public static void AddStudent(int universityType, string id, int field)
        {
            switch (universityType)
            {
                case 1:
                    {
                        if (field == 1)
                        {
                            var student = new PublicStudent(id, Fields.engineering);
                            student.UniversityType = UniversityType.Public;
                            _students.Add(student);
                        }
                        if (field == 2)
                        {
                            var student = new PublicStudent(id, Fields.medical);
                            student.UniversityType = UniversityType.Public;
                            _students.Add(student);
                        }
                        break;
                    }
                case 2:
                    {
                        if (field == 1)
                        {
                            var student = new PrivateStudent(id, Fields.engineering);
                            student.UniversityType = UniversityType.Private;
                            _students.Add(student);
                        }
                        if (field == 2)
                        {
                            var student = new PrivateStudent(id, Fields.medical);
                            student.UniversityType = UniversityType.Private;
                            _students.Add(student);
                        }
                        break;

                    }
            }
        }
        public static void ShowStudents()
        {
            foreach (var student in _students)
            {
                Console.WriteLine($"Student:\nId: {student.Id}\n" +
                    $"Field: {student.Field}\n");
            }
        }
        public static void SetStudentCourse(string studentId, string courseName, int courseUnits)
        {
            var student = _students.Single(_ => _.Id == studentId);
            var course = new Course(courseName, courseUnits);
            student.AddCourse(course);
        }
        public static void ShowTuition(string studentId)
        {
            var student = _students.Single(_ => _.Id == studentId);
            if (student.UniversityType == UniversityType.Public)
            {
                var student1 = student as PublicStudent;
                var courses = student1.GetCourses();
                var unitsNumber = 0;
                foreach (var course in courses)
                {
                    unitsNumber += course.Units;
                }
                var coursesCount = courses.Count();
               student1.CalculateTuition(unitsNumber, coursesCount);
                Console.WriteLine($"Student Tuition: ${student1.Tuition}");
            }
            if (student.UniversityType == UniversityType.Private)
            {
                var student2 = student as PrivateStudent;
                var courses = student2.GetCourses();
                var unitsNumber = 0;
                foreach (var course in courses)
                {
                    unitsNumber += course.Units;
                }
                var coursesCount = courses.Count();
                student2.CalculateTuition(unitsNumber, coursesCount);
                Console.WriteLine($"Student Tuition: ${student2.Tuition}");
            }

        }
        


    }
}
