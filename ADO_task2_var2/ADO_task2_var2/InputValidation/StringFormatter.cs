using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADO_task2_var2.InputValidation
{
    class StringFormatter
    {
        public static FormatterResult<double> GetDouble(string input)
        {
            var res = new FormatterResult<double>();

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

            if (!double.TryParse(input, out var t))
            {
                res.Errors.Add(FormatterError.Create("Непалучяецо преобразовать :с"));
            }
            else
            if (double.Parse(input) <= 0)
            {
                res.Errors.Add(FormatterError.Create("не может быть меньше нуля"));
            }

            if (input.Contains("."))
            {
                res.Errors.Add(FormatterError.Create("НИЗЯ ТОЧКУ, НАДО ЗАПЯТУУУУЮ :с"));
            }
           

            res.Value = t;

            return res;
        }

        public static FormatterResult<int> GetInt(string input)
        {
            FormatterResult<int> res = new FormatterResult<int>();

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


            int t = 0;
            if (!int.TryParse(input, out t))
            {
                res.Errors.Add(FormatterError.Create("Непалучяецо преобразовать :с"));
            }
            else
            if (int.Parse(input) <= 0)
            {
                res.Errors.Add(FormatterError.Create("не может быть меньше нуля"));
            }
            
            
            res.Value = t;
            return res;
        }
        public static FormatterResult<string> GetString(string input)
        {

            FormatterResult<string> res = new FormatterResult<string>();


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
            Regex regex = new Regex("[a-zA-Z]");

            if (!regex.IsMatch(input))
            {
                res.Errors.Add(FormatterError.Create("Нужны хотя бы буквы"));
                return res;
            }
            res.Value = input;
            
            return res;
        }

        public static FormatterResult<DateTime> GetDateTime(string input)
        {

            FormatterResult<DateTime> res = new FormatterResult<DateTime>();

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

            if (!DateTime.TryParse(input, out var t))
            {
                res.Errors.Add(FormatterError.Create("Непалучяецо преобразовать :с"));
            }


            res.Value = t;

            return res;


        }
    }
}
