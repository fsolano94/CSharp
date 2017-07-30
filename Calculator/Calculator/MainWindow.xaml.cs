using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Utilities;
using UserData;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Data calcData = new Data();
        public bool resetDisplay = false;
        public string previousPressedButton = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_7(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_0(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_Decimal(object sender, RoutedEventArgs e)
        {
            updateString(sender);
        }

        private void Button_Equals(object sender, RoutedEventArgs e)
        {
            if ( String.Equals(previousPressedButton, "=") )
            {
                calcData.Operand1 = calcData.Calculation;
                calcData.PeformCalculation();   
            }
            else
            {
                calcData.Operand2 = Convert.ToDouble(AnswerBox.Text);
                calcData.PeformCalculation();
            }
   
            if ( calcData.MathOperation.Equals("/") && calcData.Calculation == -1 && calcData.Operand2 == 0 )
            {
                AnswerBox.Text = "CANNOT DIVIDE BY ZERO";
            }

            else
            {
                AnswerBox.Text = calcData.Calculation.ToString();
            }
            previousPressedButton = "=";
        }

        private void Button_Addition(object sender, RoutedEventArgs e)
        {
            calcData.MathOperation = Addition.Content.ToString();
            calcData.Operand1 = Convert.ToDouble(AnswerBox.Text);
            resetDisplay = true;
            previousPressedButton = "+";
        }

        private void Button_Subtraction(object sender, RoutedEventArgs e)
        {
            calcData.MathOperation = Subtraction.Content.ToString();
            calcData.Operand1 = Convert.ToDouble(AnswerBox.Text);
            resetDisplay = true;
            previousPressedButton = "-";
        }

        private void Button_Multiplication(object sender, RoutedEventArgs e)
        {
            calcData.MathOperation = Multiplication.Content.ToString();
            calcData.Operand1 = Convert.ToDouble(AnswerBox.Text);
            resetDisplay = true;
            previousPressedButton = "x";
        }
        private void Button_Division(object sender, RoutedEventArgs e)
        {
            calcData.MathOperation = Division.Content.ToString();
            calcData.Operand1 = Convert.ToDouble(AnswerBox.Text);
            resetDisplay = true;
            previousPressedButton = "/";
        }
        private void Button_ClearEntry(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text = "0";
            previousPressedButton = "CE";
        }
        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text = "0";
            previousPressedButton = "C";
        }
        private void Button_BackSpace(object sender, RoutedEventArgs e)
        {
            if ( AnswerBox.Text.Length == 1 )
            {
                AnswerBox.Text = "0";
            }

            else if ( !String.Equals( AnswerBox.Text, "0" ) )
            {
                AnswerBox.Text = AnswerBox.Text.Remove(AnswerBox.Text.Length - 1);
            }
            previousPressedButton = "<-";
        }

        private void updateString ( object sender )
        {

            Button button = (Button)sender;

            if ( resetDisplay && calcData.Operand1 != 0 )
            {
                AnswerBox.Text = button.Content.ToString();
                resetDisplay = false;
            }

            else if ( String.Equals( AnswerBox.Text, "0"  ) )
            {

                if ( String.Equals( button.Content.ToString(), "." ) )
	            {
		          AnswerBox.Text += button.Content;  
	            }

                else
	            { 
                   AnswerBox.Text = "";
                   AnswerBox.Text += button.Content;
	            }
            }

            else
            {
                if ( String.Equals( button.Content, ".") && !AnswerBox.Text.Contains(".") )
                {
                    AnswerBox.Text += button.Content;
                }
                else if ( String.Equals(AnswerBox.Text, "CANNOT DIVIDE BY ZERO") )
	            {
                    AnswerBox.Text = "";
                    AnswerBox.Text = button.Content.ToString();
	            }
                else if (!String.Equals(button.Content, "."))
                {
                    AnswerBox.Text += button.Content;
                }

            }

        }

        private void Button_NegateSymbol(object sender, RoutedEventArgs e)
        {
            if ( Convert.ToDouble( AnswerBox.Text ) < 0 )
            {
                AnswerBox.Text = AnswerBox.Text.Replace("-", "");
            }
            else
            {
                AnswerBox.Text = "-" + AnswerBox.Text;
            }
        }

    }
}
