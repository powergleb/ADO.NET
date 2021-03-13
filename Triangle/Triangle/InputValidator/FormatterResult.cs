using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class FormatterResult<T> where T : struct
    {
        public T? Value { get; set; } = null;
        public List<FormatterError> Errors { get; set; } = new List<FormatterError>();
        public bool IsValid => Errors.Count == 0;
    }
}
