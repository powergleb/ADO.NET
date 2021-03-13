using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{

    
    public static class StringFormatter
    {
        public static FormatterResult<double> GetDouble(string input)
        {
            FormatterResult<double> res = new FormatterResult<double>();

            if (input == null)
            {
                res.Errors.Add(FormatterError.Create("Тут нулл :с"));
                return res;
            }

            if (input.Length == 0)
            {
                res.Errors.Add(FormatterError.Create("Строка пустая :с"));
                return res;
            }

            double t = 0;
            if(!double.TryParse(input, out t))
            {
                res.Errors.Add(FormatterError.Create("Непалучяецо преобразовать :с"));
            }

            if (input.Contains("."))
            {
                res.Errors.Add(FormatterError.Create("НИЗЯ ТОЧКУ, НАДО ЗАПЯТУУУУЮ :с"));
            }

            res.Value = t;

            return res;
        }
    }
}