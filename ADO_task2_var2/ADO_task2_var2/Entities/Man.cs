using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_task2_var2
{
    public class Man
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Weight { get; set; }

        public int Height { get; set; }

        public Man(string name, int age, double weight, int height)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
        }
        
    }
}
