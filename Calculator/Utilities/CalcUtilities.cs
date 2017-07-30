using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{

    enum MathOperator { Multiplication, Division, Addition, Subtraction };

    public class CalcUtilities
    {

        //public MathOperator MathOperation { get; set; }

        public static double Multiply(double op1, double op2)
        {
            return op1 * op2;
        }
        
        public static double Divide( double op1, double op2 )
        {
            try
            {
                
                //throw new DivideByZeroException();
                // notify View that a divide by zero exception has occured but don't hault the program
                // reset the operands and calculation to zero
                if ( op2 == 0 )
                {
                    throw new DivideByZeroException();
                }
            }
            catch ( DivideByZeroException  error)
            {
                // notify view that divide by zero excepction has occured
                return -1;
            }

            return op1 / op2;
        }

        public static double Add(double op1, double op2)
        {
            return op1 + op2;
        }

        public static double Subtract(double op1, double op2)
        {
            return op1 - op2;
        }
    }
}
