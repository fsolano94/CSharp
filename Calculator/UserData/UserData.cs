using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserData
{
    public class Data
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public double Calculation { get; set; }
        public string MathOperation { get; set; }
        
        public Data ()
        {
            Operand1 = 0.0;
            Operand2 = 0.0;
            Calculation = 0.0;
            MathOperation = "";
        }

        public void PeformCalculation()
        {
            switch (MathOperation)
            {
                case "+":
                {
                    Calculation = Utilities.CalcUtilities.Add(Operand1, Operand2);
                } break;

                case "-":
                    {
                        Calculation = Utilities.CalcUtilities.Subtract(Operand1, Operand2);
                    } break;

                case "x":
                    {
                        Calculation = Utilities.CalcUtilities.Multiply(Operand1, Operand2);
                    } break;

                case "/":
                    {
                        Calculation = Utilities.CalcUtilities.Divide(Operand1, Operand2);

                    } break;

                default:
                    break;
            }
        }


    }
}