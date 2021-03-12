using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{

    class FormatterError
    {
        public string Message { get; set; }

        public static FormatterError Create(string message) => new FormatterError
        {
            Message = message
        };
    }

    class FormatterResult<T> where T : struct
    {
        public T? Value { get; set; } = null;
        public List<FormatterError> Errors { get; set; } = new List<FormatterError>();
        public bool IsValid => Errors.Count == 0;
    }


    static class StringFormatter
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