using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    class TooLargeNumberException : Exception 
    { 
        public string Message() { return "Error 06. Too large number!"; } 
    }

    class TooSmallNumberException : Exception 
    {
        public string Message() { return "Error 06. Too small number!"; } 
    }

    class DivideByZeroException : Exception 
    {
        public string Message() { return "Error 09. Number cannot be divided by zero"; } 
    }

    class DivideZeroException : Exception 
    {
        public string Message() { return "Error 09. Zero cannot be divided"; } 
    }

    struct Result
    {
        public Double rslt;
        public string errors;

        public Result(Double rslt, string error) { this.rslt = rslt; this.errors = error; }
    }
}
