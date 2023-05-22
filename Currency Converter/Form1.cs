using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        double convertedAmount;
        string convertingFrom;
        string convertedTo;
        // Currency Initialization
        double usdToRm = 4.53;
        double usdToBdt = 96.90;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void sameCurrencyEntered() {
            output.Text = "Same currency type entered!";
            output.ForeColor = System.Drawing.Color.OrangeRed;
        }

        private void displayResult(string currency) {
            output.Text = $"{currency} {Math.Round(convertedAmount, 2)}";
            output.ForeColor = System.Drawing.Color.Indigo;
        }
        private void convertCurrency() {
            if (string.IsNullOrEmpty(convertingFrom) || string.IsNullOrEmpty(convertedTo) || (input.Text == "")) {
                output.Text = "Please enter all the fields";
                output.ForeColor = System.Drawing.Color.Crimson;
                return;
            }
            // output.Text = input.Text;
            //double userInput = int.TryParse(input.Text);
            double number;
            if (Double.TryParse(input.Text, out number))
            {
                //output.Text = "Parse succeded!";
                if (convertingFrom == "USD") {
                    // Converting From USD
                    if (convertedTo == "USD") {
                        sameCurrencyEntered();
                    } else if (convertedTo == "RM") {
                        convertedAmount = number * usdToRm;
                        displayResult("RM");
                    }
                    else if (convertedTo == "BDT")
                    {
                        convertedAmount = number * usdToBdt;
                        displayResult("BDT");
                    }

                } else if (convertingFrom == "RM") {
                    // Converting From RM
                    if (convertedTo == "RM") {
                        sameCurrencyEntered();
                    } else if (convertedTo == "USD") {
                        convertedAmount = number * (1 / usdToRm);
                        displayResult("USD");
                    } else if (convertedTo == "BDT") {
                        convertedAmount = number * (1 / usdToRm) * usdToBdt;
                        displayResult("BDT");
                    }
                }
                else if (convertingFrom == "BDT") {
                    // Converting From BDT
                    if (convertedTo == "BDT") {
                        sameCurrencyEntered();
                    } else if (convertedTo == "USD") {
                        convertedAmount = number * (1 / usdToBdt);
                        displayResult("USD");
                    } else if (convertedTo == "RM") {
                        convertedAmount = number * (1 / usdToBdt) * usdToRm;
                        displayResult("RM");
                    }
                }
            }
            else {
                output.Text = "Entered amount is invalid!";
                output.ForeColor = System.Drawing.Color.Crimson;
            }
        }

        private void fromDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fromDD.Text == "United States Dollar") {
                convertingFrom = "USD";
                fromDisplay.Text = "USD";
            } else if (fromDD.Text == "Malaysian Ringgit") {
                convertingFrom = "RM";
                fromDisplay.Text = "RM";
            } else if (fromDD.Text == "Bangladeshi Taka") {
                convertingFrom = "BDT";
                fromDisplay.Text = "BDT";
            }
        }

        private void toDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toDD.Text == "United States Dollar")
            {
                convertedTo = "USD";
                toDisplay.Text = "USD";
            }
            else if (toDD.Text == "Malaysian Ringgit")
            {
                convertedTo = "RM";
                toDisplay.Text = "RM";
            }
            else if (toDD.Text == "Bangladeshi Taka")
            {
                convertedTo = "BDT";
                toDisplay.Text = "BDT";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertCurrency();
        }
    }
}
