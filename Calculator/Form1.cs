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
        Calculadora Calcu;

        public Form1()
        {
            InitializeComponent();
            Calcu = new Calculadora();
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("1");
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("9");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber(".");
        }

        

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.concatenateNumber("0");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            if (Calcu.UsarIgual()!="")
            {
                txtNumber.Text = Convert.ToString(Calcu.ResultEqual());
            }
            
        }

        private void btnSum_Click(object sender, EventArgs e)
        {            
            txtNumber.Text = "";
            Calcu.Sum();  
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            Calcu.Res();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            Calcu.Multi();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            Calcu.Div();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            Calcu.Mod();
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            Calcu.Elevation();

        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            if (Calcu.NUM>=0)
            {
                txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("raiz"));
            }
            else
            {
                txtNumber.Text = "ERROR Matemático";
            }
            
        }

        private void btnFraction_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            if (Calcu.NUM != 0)
            {
                txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("fraccion"));
            }
            else
            {
                txtNumber.Text = "ERROR Matemático";
            }
            
        }

        private void btnPow2_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("elevado2"));
        }

        private void btnPow3_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("elevado3"));
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("sin"));
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("cos"));
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            if (Calcu.NUM != 90 && Calcu.NUM!=270)
            {
                txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("tan"));
            }
            else
            {
                txtNumber.Text = "ERROR Matemático";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("euler"));
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            if (Calcu.NUM > 0)
            {
                txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("ln"));
            }
            else
            {
                txtNumber.Text = "ERROR Matemático";
            }
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            if (Calcu.NUM > 0)
            {
                txtNumber.Text = Convert.ToString(Calcu.OperactionOneNumber("log"));
            }
            else
            {
                txtNumber.Text = "ERROR Matemático";
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            Calcu.Erase();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.Back();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Calcu.Signo();
        }

        
    }
}
