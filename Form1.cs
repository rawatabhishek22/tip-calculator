using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator1
{
    public partial class Form1 : Form
    {
        private int _tipIncrement = 0;                         // for tip increment or decrement       
        private int _peopleIncrement = 0;                      // for people increment or decrement
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click (object sender, EventArgs e) 
        {
            double amount, tipPercent, totalAmount,totalPerperson,tipPerPerson;
            int people;
            try
            { 
                people = int.Parse(textPeople.Text);               //total number of people
                amount = double.Parse(textBill.Text);              //bill amount
                tipPercent = double.Parse(textTip.Text) / 100;     // tip % on bill
                totalAmount = amount * tipPercent + amount;        // total amount including tip
                totalPerperson = totalAmount / people;             //total ammount per person
                tipPerPerson = amount * tipPercent / people;       // tip per person
                if (people == 0 || amount == 0)
                {
                    throw new NullReferenceException("user input contains null value");               // to catch null execption
                }
                else
                {
                    if (people < 0 || tipPercent < 0 || amount < 0)                                   // to check if total number of people are 0 or not 
                    {
                        
                        throw new Exception("user input contains negative number");                    
                    }
                    else
                    {

                        textTotal.Text = "$" + totalPerperson.ToString();                             //return total amount per person
                        textTipPerperson.Text = "$" + tipPerPerson.ToString();                        //return tip per person 
                    }
                }
            }
            
                catch (FormatException exp)                                                          // when null exeption arises
            {
                textTotal.Text = "";
                textTipPerperson.Text = "";
                Console.WriteLine(exp.Message);
            }
            catch (NullReferenceException exp)                                                      // when null exeption arises
            {
                textTotal.Text = "";
                textTipPerperson.Text = "";
                Console.WriteLine(exp.Message);
            }
            catch (Exception exp)                                                                   // when exeption arises
            {
                 textTotal.Text = "";
                 textTipPerperson.Text = "";
                Console.WriteLine(exp.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            
                _tipIncrement ++;                                 //to increment tip number by 5
                textTip.Text = _tipIncrement.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_tipIncrement == 0)
            {
                textTip.Text = "";
            }
            else
            {
                 _tipIncrement --;                                          //to decrement tip number by 5
                textTip.Text = _tipIncrement.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_peopleIncrement == 0)
            {
                textPeople.Text = "";
            }
            else
            {
                _peopleIncrement--;                                                         //to decrease number of person by 1
                textPeople.Text = _peopleIncrement.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _peopleIncrement++;                                                           //to increase number of person by 1
            textPeople.Text = _peopleIncrement.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
    

