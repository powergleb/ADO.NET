using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_task2_var2
{
    public class Student : Man
    {
        public int Cource { get; set; }

        public int YearOfStart { get; set; }

        public int Group { get; set; }
       
        public Student(int cource, int yearOfStart, int group, string name, int age, double weight, int height) : base (name, age, weight, height)
        {
            this.Cource = cource;
            this.YearOfStart = yearOfStart;
            this.Group = group;
        }

        public Student(int cource, int yearOfStart, int group, Man man) : base(man.Name, man.Age, man.Weight, man.Height)
        {
            this.Cource = cource;
            this.YearOfStart = yearOfStart;
            this.Group = group;
        }

    }
}
