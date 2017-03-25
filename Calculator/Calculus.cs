using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculus
    {
        public const int MAX = 2147483647;
        public const int MIN = -2147483647;
        public Result rslt;

        public Calculus() { this.rslt = new Result(0, ""); }

        public Result Run(Double a, Double b, String actn)
        {
            this.rslt.rslt = 0;
            this.rslt.errors = "";

            try
            {
                switch (actn)
                {
                    case "+": Plus(a, b);
                        break;
                    case "-": Minus(a, b);
                        break;
                    case "*": Multiply(a, b);
                        break;
                    case "/": Divide(a, b);
                        break;
                    case "%": DivideByModule(a, b);
                        break;
                    default: break;
                }
            }
            catch (TooLargeNumberException large)
            {
                this.rslt.errors = large.Message();
            }
            catch (TooSmallNumberException small)
            {
                this.rslt.errors = small.Message();
            }
            catch (DivideByZeroException zero)
            {
                this.rslt.errors = zero.Message();
            }
            catch (DivideZeroException zero)
            {
                this.rslt.errors = zero.Message();
            }

            return rslt;
        }

        private void Plus(Double a, Double b)
        {
            if (a > MAX || b > MAX || a + b > MAX)
                throw new TooLargeNumberException();
            if (a < MIN || b < MIN || a + b < MIN)
                throw new TooSmallNumberException();
            this.rslt.rslt = a + b;            
        }

        public void Minus(Double a, Double b)
        {
            if (a > MAX || b > MAX || a - b > MAX)
                throw new TooLargeNumberException();
            if (a < MIN || b < MIN || a - b < MIN)
                throw new TooSmallNumberException();
            this.rslt.rslt = a - b;
        }

        public void Multiply(Double a, Double b)
        {
            if (a > MAX || b > MAX || a * b > MAX)
                throw new TooLargeNumberException();
            if (a < MIN || b < MIN || a * b < MIN)
                throw new TooSmallNumberException();
            this.rslt.rslt = a * b;            
        }

        public void Divide(Double a, Double b)
        {
            if (a > MAX || b > MAX || a / b > MAX)
                throw new TooLargeNumberException();
            if (a < MIN || b < MIN || a / b < MIN)
                throw new TooSmallNumberException();
            if (a == 0)
                throw new DivideZeroException();
            if (b == 0)
                throw new DivideByZeroException();
            this.rslt.rslt = a / b;
        }

        public void DivideByModule(Double a, Double b)
        {
            if (a > MAX || b > MAX || a % b > MAX)
                throw new TooLargeNumberException();
            if (a < MIN || b < MIN || a % b < MIN)
                throw new TooSmallNumberException();
            if (a == 0)
                throw new DivideZeroException();
            if (b == 0)
                throw new DivideByZeroException();
            this.rslt.rslt = a % b;            
        }
    }
}
