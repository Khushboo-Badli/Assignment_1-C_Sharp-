using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //double result = 0;
        //string operation = "";
        //bool isoperation = false;
        double FirstNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Sub_Click(object sender, EventArgs e) { }
        

        private void Button_Click(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" )
            {
                Output_Screen.Clear();
            }
            
            //Button button = (Button)sender;

           // Output_Screen.Text = Output_Screen.Text + button.Text ;
        }


        //to clear the screen
        private void Button_Clear(object sender, EventArgs e)
        {
            Output_Screen.Clear();
        }


        // all the operations perfomed 
        
        private void Button_Operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            //result = double.Parse(Output_Screen.Text);
            //isoperation = true;
        }

        private void Button_Equal(object sender, EventArgs e)
        {
            /*
            switch (Output_Screen.Text)
            {
                case "+":
                    Output_Screen.Text = (result + double.Parse(Output_Screen.Text)).ToString();
                    break;
                case "-":
                    Output_Screen.Text = (result - double.Parse(Output_Screen.Text)).ToString();
                    break;
                case "*":
                    Output_Screen.Text = (result * double.Parse(Output_Screen.Text)).ToString();
                    break;
                case "/":
                    Output_Screen.Text = (result / double.Parse(Output_Screen.Text)).ToString();
                    break;
                default:
                    break;
            }
            */

            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(Output_Screen.Text);

            if (operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                Output_Screen.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Output_Screen.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                Output_Screen.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (operation == "/")
            {
                if (SecondNumber == 0)
                {
                    Output_Screen.Text = "Infinity";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    Output_Screen.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
        

        //to delete the previous value
        private void Button_Delete(object sender, EventArgs e)
        {
            string s = Output_Screen.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            Output_Screen.Text = s;
        }

       
        private void Button_Click_1(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" && Output_Screen.Text != null)
            {
                Output_Screen.Text = "1";
            }
            else
            {
                Output_Screen.Text = Output_Screen.Text + "1";
            }


        }

        private void Button_Click_2(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" && Output_Screen.Text != null)
            {
                Output_Screen.Text = "2";
            }
            else
            {
                Output_Screen.Text = Output_Screen.Text + "2";
            }


        }

        private void Button_Click_3(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" && Output_Screen.Text != null)
            {
                Output_Screen.Text = "3";
            }
            else
            {
                Output_Screen.Text = Output_Screen.Text + "3";
            }


        }

       

        private void Button_Click_4(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" && Output_Screen.Text != null)
            {
                Output_Screen.Text = "4";
            }
            else
            {
                Output_Screen.Text = Output_Screen.Text + "4";
            }


        }
        private void Button_Click_5(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" && Output_Screen.Text != null)
            {
                Output_Screen.Text = "5";
            }
            else
            {
                Output_Screen.Text = Output_Screen.Text + "5";
            }


        }

        private void Button_Click_6(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" && Output_Screen.Text != null)
            {
                Output_Screen.Text = "6";
            }
            else
            {
                Output_Screen.Text = Output_Screen.Text + "6";
            }


        }

        private void Button_Click_7(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" && Output_Screen.Text != null)
            {
                Output_Screen.Text = "7";
            }
            else
            {
                Output_Screen.Text = Output_Screen.Text + "7";
            }


        }

        private void Button_Click_8(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" && Output_Screen.Text != null)
            {
                Output_Screen.Text = "8";
            }
            else
            {
                Output_Screen.Text = Output_Screen.Text + "8";
            }


        }

        private void Button_Click_9(object sender, EventArgs e)
        {
            if (Output_Screen.Text == "0" && Output_Screen.Text != null)
            {
                Output_Screen.Text = "9";
            }
            else
            {
                Output_Screen.Text = Output_Screen.Text + "9";
            }


        }

        //Oprations
        private void Additon(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Output_Screen.Text);
            Output_Screen.Text = "";
            operation = "+";
        }

        private void Subtraction(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Output_Screen.Text);
            Output_Screen.Text = "";
            operation = "-";
        }

        private void Multiplication(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Output_Screen.Text);
            Output_Screen.Text = "";
            operation = "*";
        }

        private void Divison(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Output_Screen.Text);
            Output_Screen.Text = "";
            operation = "/";
        }

    }
}
