using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_5
{
    public abstract class Student
    {
        private List<Course> _courses;
        private string _id;
        private int _tuition;
        protected Student(string id, Fields field)
        {
            Id = id;
            Field = field;
            _courses = new List<Course>();
        }
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Id Cannot Be Empty");
                }
                _id = value;
            }
        }
        public Fields Field { get; set; }
        public UniversityType UniversityType { get; set; }
        public int Tuition
        {
            get
            {
                return _tuition;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Tuition Cannot Be Negative");
                }
                _tuition = value;
            }
        }
        public void AddCourse(Course course)
        {
            var course1 = new Course(course.Name, course.Units);
            _courses.Add(course1);
        }
        public List<Course> GetCourses()
        {
            return _courses;
        }

    }
}
