using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_Delegates_Extensions
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public Student(string name, List<int> score)
        {
            this.Name = name;
            this.Scores = score;
        }
        public override string ToString()
        {
            return $"{Name} , Average Score: {Scores.AverageScore()}";
        }
    }
}
