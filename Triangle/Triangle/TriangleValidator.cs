using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class TriangleError
    {
        public string Message { get; set; }

        public static TriangleError Create(string message) => new TriangleError
        {
            Message = message
        };
    }
    class TriangleResult<T> where T : struct
    {
        public T? Value { get; set; } = null;
        public List<TriangleError> Errors { get; set; } = new List<TriangleError>();
        public bool IsValid => Errors.Count == 0;
    }

    class TriangleValidator 
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
            if (!double.TryParse(input, out t))
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
