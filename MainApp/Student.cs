using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Student : Person
    {
      private  int _numCource=0;
        private  List<string> _courses;
        private  List<int> _grades;

        public Student(string name, string address) : base(name, address)
        {
            _courses = new List<string>();
            _grades = new List<int>();
        }
        public void AddCourseGrade(string course,int grade)
        {
            _courses.Add(course);
            _grades.Add(grade);
            _numCource++;
        }
        public void PrintGrades()
        {

            foreach (var item in _grades)
            {
                Console.Write(item+" ");
            }
        }
        public double GetAverageGrade()
        {
            return _grades.Sum()/_grades.Count();
        }

        public override string ToString()
        {
            return $"{_name} {_address}";
        }
    }
}
