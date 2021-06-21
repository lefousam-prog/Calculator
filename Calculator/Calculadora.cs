using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculadora
    {
        private string num;
        private double num1;
        private double result, resultOne;
        private string operation, signo="mas";
        private bool useEqual;

       public double NUM
        {
            get { return Convert.ToDouble(num); }
        }
        public string concatenateNumber(string n)
        {
            num = String.Concat(num, n);
            return num;
            
        }

        public string Back()
        {
            num = num.Remove(num.Length - 1);
            return num;
        }

        public void Erase()
        {
            num = String.Empty;
            num1 = 0;
            resultOne = 0;
            result = 0;
        }

        public string Signo()
        {
            if (signo=="mas")
            {
                num = "+";
                signo = "menos";
            }
            else if(signo=="menos")
            {
                num = "-";
                signo = "mas";
            }

            return num;
        }

       

        public void Sum()
        {
            if (num != "")
            {
                num1 = Convert.ToDouble(num);
            }
            num = String.Empty;
            operation = "suma";
        }

        public void Res()
        {
            if (num != "")
            {
                num1 = Convert.ToDouble(num);
            }
            num = String.Empty;
            operation = "resta";
        }

        public void Multi()
        {
            if (num != "")
            {
                num1 = Convert.ToDouble(num);
            }
            num = String.Empty;
            operation = "multiplicacion";
        }

        public void Div()
        {
            if (num != "")
            {
                num1 = Convert.ToDouble(num);
            }
            num = String.Empty;
            operation = "division";
        }

        public void Mod()
        {
            if (num != "")
            {
                num1 = Convert.ToDouble(num);
            }
            num = String.Empty;
            operation = "modulo";
        }

        public void Elevation()
        {
            if (num != "")
            {
                num1 = Convert.ToDouble(num);
            }
            num = String.Empty;
            operation = "elevacion";
        }


        public double ResultEqual()
        {

            switch (operation)
            {
                case "suma":
                    if (result != 0)
                    {
                        result = result + Convert.ToDouble(num);
                    }
                    else
                    {
                        result = num1 + Convert.ToDouble(num);
                    }
                    
                    break;
                case "resta":
                    if (result != 0)
                    {
                        result = result - Convert.ToDouble(num);
                    }
                    else
                    {
                        result = num1 - Convert.ToDouble(num);
                    }
                    break;
                case "multiplicacion":

                    if (result !=0)
                    {
                        result = result * Convert.ToDouble(num);
                    }
                    else
                    {
                        result =  num1 * Convert.ToDouble(num);
                    }
                    break;
                case "division":

                    if (result != 0)
                    {
                        result = result / Convert.ToDouble(num);
                    }
                    else
                    {
                        result = num1 / Convert.ToDouble(num);
                    }
                    
                    break;
                case "raiz":

                    if (result != 0)
                    {
                        result = result / Convert.ToDouble(num);
                    }
                    else
                    {
                        result = num1 / Convert.ToDouble(num);
                    }
                    break;

                case "modulo":

                    if (result != 0)
                    {
                        result = result % Convert.ToDouble(num);
                    }
                    else
                    {
                        result = num1 % Convert.ToDouble(num);
                    }

                    break;

                case "elevacion":

                    if (result != 0)
                    {
                        result = Math.Pow(result, Convert.ToDouble(num));
                    }
                    else
                    {
                        result = Math.Pow(num1, Convert.ToDouble(num));
                    }

                    break;
                default:
                   // useEqual = false;
                    break;
            }

            num = String.Empty;
            num1 = 0;
            operation = String.Empty;

            return result;
        }

        public string UsarIgual()
        {
            return operation;
        }

        public double OperactionOneNumber(string tipo)
        {
            resultOne = result;
            double n=0;
            if (num != "")
            {
                n = Convert.ToDouble(num);
            }
            switch (tipo)
            {
                case "raiz":

                    if (n==0)
                    {
                        resultOne = Math.Sqrt(resultOne);
                    }
                    else if(n!=0)
                    {
                        resultOne = Math.Sqrt(n);
                    }
                    
                    break;

                case "fraccion":

                    if (n == 0)
                    {
                        resultOne = 1/resultOne;
                    }
                    else if(n!=0)
                    {
                        resultOne = 1/n;
                    }

                    break;

                case "elevado2":

                    if (n== 0)
                    {
                        resultOne = Math.Pow(resultOne, 2);
                    }
                    else if(n!=0)
                    {
                        resultOne = Math.Pow(n, 2);
                    }

                    break;

                case "elevado3":

                    if (n == 0)
                    {
                        resultOne = Math.Pow(resultOne, 3);
                    }
                    else if (n != 0)
                    {
                        resultOne = Math.Pow(n, 3);
                    }

                    break;

                case "sin":

                    if (n == 0)
                    {
                        resultOne = Math.Round(Math.Sin(resultOne),3);
                    }
                    else if (n != 0)
                    {
                        resultOne = Math.Round(Math.Sin(n * (Math.PI / 180)),3);
                    }

                    break;
                case "cos":

                    if (n == 0)
                    {
                        resultOne = Math.Round(Math.Cos(resultOne),3);
                    }
                    else if (n != 0)
                    {
                        resultOne = Math.Round(Math.Cos(n * (Math.PI / 180)),3);
                    }

                    break;

                case "tan":

                    if (n == 0)
                    {
                        resultOne = Math.Round(Math.Tan(resultOne), 3);
                    }
                    else if (n != 0)
                    {
                        resultOne = Math.Round(Math.Tan(n * (Math.PI / 180)), 3);
                    }

                    break;

                case "euler":

                    if (n == 0)
                    {
                        resultOne = Math.Round(Math.Exp(resultOne),3);
                    }
                    else if (n != 0)
                    {
                        resultOne = Math.Round(Math.Exp(n),3);
                    }

                    break;

                case "ln":

                    if (n == 0)
                    {
                        resultOne = Math.Round(Math.Log(resultOne),6);
                    }
                    else if (n != 0)
                    {
                        resultOne = Math.Round(Math.Log(n), 6);
                    }

                    break;

                case "log":

                    if (n == 0)
                    {
                        resultOne = Math.Round(Math.Log10(resultOne), 6);
                    }
                    else if (n != 0)
                    {
                        resultOne = Math.Round(Math.Log10(n), 6);
                    }

                    break;

            }
            num = String.Empty;

            return resultOne;
        }
    }
}
