using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTaxCalc
    //EWH
    //7.22.19


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const decimal tax = 0.0675m; //Lorain County tax rate, which is 6.75% as of April 1, 2017

        //these are my accumulations holds
        decimal AccumGTS = 0;
        decimal AccumGTT = 0;
        decimal AccumGTA = 0;
        decimal AccumTI = 0;
        decimal AccumAvg = 0;

        private void calcbutton_Click(object sender, EventArgs e)
        {
            decimal inCost = 0; //place holder for the input


            decimal calcTaxonly = 0; //place holder for the calculation
            decimal calcTotal = 0;

            try
            {
                inCost = decimal.Parse(inputcost.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Dollar Amount"); //validation for input
                return;
            }

                inCost = decimal.Parse(inputcost.Text); //taking the text from the input box and 
                                                    //making it into a useable value

            calcTaxonly = (inCost * tax);   //our caluations for just the tax
            calcTotal = (inCost * (1 + tax)); //and the total cost
            AccumGTS = AccumGTS + inCost;  //the Grand Total Sales
            AccumGTT = AccumGTT + calcTaxonly; //The grand total of tax
            AccumGTA = AccumGTA + calcTotal; // the grand total amount due
            AccumTI = AccumTI + 1; //the total of "transaction"
            AccumAvg = AccumGTS / AccumTI; // the grand average, not taxed


           
            taxitself.Text = calcTaxonly.ToString("c"); //outputting my calculations to text
            totalcost.Text = calcTotal.ToString("c");
            GTSOut.Text = AccumGTS.ToString("c");
            GTTOut.Text = AccumGTT.ToString("c");
            GTAOut.Text = AccumGTA.ToString("c");
            TotalItemOut.Text = AccumTI.ToString();
            AvgItemOut.Text = AccumAvg.ToString("c");



        }

        private void clearbutton_Click(object sender, EventArgs e) //the clear entry button only cleans out the current values
        {
            taxitself.Text = null;
            totalcost.Text = null;
            inputcost.Text = null;
        }

        private void clearallbutton_Click(object sender, EventArgs e) //clear all buttons cleans out everthing
        {
            taxitself.Text = null;
            totalcost.Text = null;
            inputcost.Text = null;
            GTSOut.Text = null; ;
            GTTOut.Text = null; ;
            GTAOut.Text = null; ;
            TotalItemOut.Text = null; ;
            AvgItemOut.Text = null;
            AccumGTS = 0; //gotta makes sure the accumulations are zeroed
            AccumGTT = 0;
            AccumGTA = 0;
            AccumTI = 0;
            AccumAvg = 0;

        }
    }
}
