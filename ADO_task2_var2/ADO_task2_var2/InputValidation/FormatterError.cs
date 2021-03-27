using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_task2_var2
{
    public class FormatterError
    {
        public string Message { get; set; }

        public static FormatterError Create(string message) => new FormatterError
        {
            Message = message
        };
    }
}
