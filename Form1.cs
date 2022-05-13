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
    public partial class Calculator : Form
    {


        string firstValue = "";
        string secondValue = "";
        char calcOperator;
        double result = 0.0;
        

        public Calculator()
        {
            InitializeComponent();

            answerBox.Enabled = false;
            number0Button.Enabled = false;
            number1Button.Enabled = false;
            number2Button.Enabled = false;
            number3Button.Enabled = false;
            number4Button.Enabled = false;
            number5Button.Enabled = false;
            number6Button.Enabled = false;
            number7Button.Enabled = false;
            number8Button.Enabled = false;
            number9Button.Enabled = false;
            addButton.Enabled = false;
            sbtrButton.Enabled = false;
            divButton.Enabled = false;
            multButton.Enabled = false;
            EqualButton.Enabled = false;
            dotButton.Enabled = false;
            clearButton.Enabled = false;
            chgSignButton.Enabled = false;

        }


        
        private void onOffButton_Click(object sender, EventArgs e)
        {

            if (onOffButton.BackColor == Color.Red)
            {
                onOffButton.BackColor = Color.Green;
                answerBox.Enabled = true;
                number0Button.Enabled = true;
                number1Button.Enabled = true;
                number2Button.Enabled = true;
                number3Button.Enabled = true;
                number4Button.Enabled = true;
                number5Button.Enabled = true;
                number6Button.Enabled = true;
                number7Button.Enabled = true;
                number8Button.Enabled = true;
                number9Button.Enabled = true;
                dotButton.Enabled = true;
                clearButton.Enabled = true;
                chgSignButton.Enabled = true;
            }

            else
            {
                onOffButton.BackColor = Color.Red;
                number0Button.Enabled = false;
                number1Button.Enabled = false;
                number2Button.Enabled = false;
                number3Button.Enabled = false;
                number4Button.Enabled = false;
                number5Button.Enabled = false;
                number6Button.Enabled = false;
                number7Button.Enabled = false;
                number8Button.Enabled = false;
                number9Button.Enabled = false;
                answerBox.Enabled = false;
                addButton.Enabled = false;
                sbtrButton.Enabled = false;
                divButton.Enabled = false;
                multButton.Enabled = false;
                EqualButton.Enabled = false;
                dotButton.Enabled = false;
                clearButton.Enabled = false;
                chgSignButton.Enabled = false;
                firstValue = "";
                secondValue = "";
                answerBox.Text = "";
            }
            
           
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
    
            answerBox.Text += "0";
        }

        private void number1Button_Click(object sender, EventArgs e)
        {
   
            answerBox.Text += "1";
        }

        private void number2Button_Click(object sender, EventArgs e)
        {

            answerBox.Text += "2";
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
      
            answerBox.Text += "3";
        }

        private void number4Button_Click(object sender, EventArgs e)
        {
           
            answerBox.Text += "4";
        }

        private void number5Button_Click(object sender, EventArgs e)
        {
  
            answerBox.Text += "5";
        }

        private void number6Button_Click(object sender, EventArgs e)
        {

            answerBox.Text += "6";
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
    
            answerBox.Text += "7";
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
         
            answerBox.Text += "8";
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
       
            answerBox.Text += "9";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
    
            calcOperator = '+';
            firstValue = answerBox.Text;

   
            sbtrButton.Enabled = false;
            divButton.Enabled = false;
            multButton.Enabled = false;
            addButton.Enabled = false;
            answerBox.Text = "";
        }

        private void sbtrButton_Click(object sender, EventArgs e)
        {
         
            calcOperator = '-';

   
            firstValue = answerBox.Text;

  
            divButton.Enabled = false;
            multButton.Enabled = false;
            addButton.Enabled = false;
            sbtrButton.Enabled = false;
            answerBox.Text = "";
        }

        private void multButton_Click(object sender, EventArgs e)
        {
      
            calcOperator = '*';

     
            firstValue = answerBox.Text;

     
            sbtrButton.Enabled = false;
            divButton.Enabled = false;
            addButton.Enabled = false;
            multButton.Enabled = false;
            answerBox.Text = "";
            

        }

        private void divButton_Click(object sender, EventArgs e)
        {
         
            calcOperator = '/';

 
            firstValue = answerBox.Text;

            sbtrButton.Enabled = false;
            multButton.Enabled = false;
            addButton.Enabled = false;
            divButton.Enabled = false;
            answerBox.Text = "";
            

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            
           
            firstValue = "";
            secondValue = "";
            answerBox.Text = "";
            calcOperator = ' ';
            sbtrButton.Enabled = true;
            multButton.Enabled = true;
            divButton.Enabled = true;
            addButton.Enabled = true;
            number0Button.Enabled = true;
            number1Button.Enabled = true;
            number2Button.Enabled = true;
            number3Button.Enabled = true;
            number4Button.Enabled = true;
            number5Button.Enabled = true;
            number6Button.Enabled = true;
            number7Button.Enabled = true;
            number8Button.Enabled = true;
            number9Button.Enabled = true;
            dotButton.Enabled = true;
            chgSignButton.Enabled = true;
            EqualButton.Enabled = false;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
          
            if (secondValue.Equals("")) { 
                secondValue = answerBox.Text;
            }

            answerBox.Text = "";

       
            sbtrButton.Enabled = true;
            multButton.Enabled = true;
            divButton.Enabled = true;
            addButton.Enabled = true;
            number0Button.Enabled = true;
            number1Button.Enabled = true;
            number2Button.Enabled = true;
            number3Button.Enabled = true;
            number4Button.Enabled = true;
            number5Button.Enabled = true;
            number6Button.Enabled = true;
            number7Button.Enabled = true;
            number8Button.Enabled = true;
            number9Button.Enabled = true;
            EqualButton.Enabled = true;
            dotButton.Enabled = true;
            chgSignButton.Enabled = true;

            
            try
            {
                
                switch (calcOperator)
                {
                    
                    case '+':
                        result += double.Parse(firstValue) + 
                            double.Parse(secondValue);
                        answerBox.Text = result.ToString();
                        
                        break;
              
                    case '-':
                        result = double.Parse(firstValue) - 
                            double.Parse(secondValue);
                        answerBox.Text = result.ToString();
                        break;
                   
                    case '*':
                        result = double.Parse(firstValue) * 
                            double.Parse(secondValue);
                        answerBox.Text = result.ToString();
                        break;
                   
                    case '/':
                        if (firstValue != "0" && secondValue != "0")
                        {
                            result = double.Parse(firstValue) / 
                                double.Parse(secondValue);
                            answerBox.Text = result.ToString();
                        }
           
                        else
                        {
                            answerBox.Text = "Cannot divide by zero!";
                        }
                        break;
                }
            }
            catch (FormatException ex)
            {
                answerBox.Text = "Math Error";
            }
        }

        private void answerBox_TextChanged(object sender, EventArgs e)
        {

            if(!firstValue.Equals("") && !answerBox.Text.Equals(""))
            {
                EqualButton.Enabled = true;
            }

            else if (firstValue.Equals("") && !answerBox.Text.Equals(""))
            {
                addButton.Enabled = true;
                sbtrButton.Enabled = true;
                divButton.Enabled = true;
                multButton.Enabled = true;
            }
           
        }

        private void chgSignButton_Click(object sender, EventArgs e)
        {
            if(!answerBox.Text.Equals("") && !answerBox.Text.Equals("."))
            {
                answerBox.Text = (-double.Parse(answerBox.Text)).ToString();
            }
            
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            
            if(!answerBox.Text.Contains("."))
            {
                answerBox.Text += ".";
            }
        }
    }
}
