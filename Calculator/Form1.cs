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
    public partial class form1 : Form           // Partial class bize tek bir sınıfın fonksiyonelliğini birden fazla sınıfa uygulama imkanı sunar.
    {
        private char _process;
        private bool _resetscreen;
        private double _firstnumber;




        public form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_resetscreen)                       //Yapılan process den sonra resetscreen true ise ekranı temizle 
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_resetscreen)
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_resetscreen)
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_resetscreen)
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_resetscreen)
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (_resetscreen)
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (_resetscreen)
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_resetscreen)
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_resetscreen)
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "9";
            
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_resetscreen)
            {
                txtBox.Text = "";
                _resetscreen = false;
            }
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += "0";

        }



        private void plusButton_Click(object sender, EventArgs e)
        {
            _process = '+';
            _resetscreen = true;
            _firstnumber = Convert.ToDouble(txtBox.Text);
           
        }

        public void equalButton_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(txtBox.Text);
            double result;
            Button btn = (Button)sender;
            string process = btn.Text;
            //label.Text= label.Text + " " + label.Text + " " + _process;
            switch (_process)
            {
                case '+':
                    result = _firstnumber + secondNumber;
                    break;
                case '-':
                    result = _firstnumber - secondNumber;
                    break;
                case '*':
                    result = _firstnumber * secondNumber;
                    break;
                case '/':
                    result = _firstnumber / secondNumber;
                    break;
                   
                default:
                    result = 0;
                    break;
            }

            
            txtBox.Text = Convert.ToString(result); 

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            _process = '-';
            _resetscreen = true;
            _firstnumber = Convert.ToDouble(txtBox.Text);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            _process = '/';
            _resetscreen = true;
            _firstnumber = Convert.ToDouble(txtBox.Text);
        }
       

        private void resetButton_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
                _process = '*';
                _resetscreen = true;
                _firstnumber = Convert.ToDouble(txtBox.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            txtBox.Text += ".";
            _firstnumber = Convert.ToDouble(txtBox.Text);
        }

        
    }
}
