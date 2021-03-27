using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_task2_var2.Entities
{
    public class Author
    {
        public string Name { get; set; }

        public string SecondName { get; set; }

        public DateTime BirthDate { get; set; }

        public Author(string name, string secondName, DateTime BirthDate)
        {
            this.Name = name;
            this.SecondName = secondName;
            this.BirthDate = BirthDate;
        }
    }
}
