using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
EWH 
7.22.19
    */
namespace CalcWithAccums___EWH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const decimal Yardage = 27m; // a cubic yard is 27 cubic feet
        const decimal Pricage = 17m; // a cubic yard is $17
        const decimal TruckBed = 4m; // a truck load is 4 cubic yards

        //accumulation holds
        decimal TVaccum = 0;  //total volume (yards) accumulated
        decimal CuFeetaccum = 0; //total cubic feet accumulated
        decimal TPaccum = 0; //total price accumulated
        decimal Ordersaccum = 0; //total orders accumulated
        decimal VolumeRemaining = 0; //volume left in trucks




        private void CalcButton_Click(object sender, EventArgs e)
        {
            //my input holds 
            decimal LCalc = 0;
            decimal HCalc = 0;
            decimal WCalc = 0;


            //my calculation holds
            decimal CuFeetCalc = 0; //cubic feet
            decimal TVCalc = 0; //total volume (yards)
            decimal TPCalc = 0; //total price 

            try
            {
                LCalc = decimal.Parse(Lin.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter a valid Length");
                return;
            }
            try
            {
                WCalc = decimal.Parse(Win.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter a valid Width");
                return;
            }
            try
            {
                HCalc = decimal.Parse(Hin.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter a valid Height");
                return;
            }

       



            //calcuations (none accumulated)
            CuFeetCalc = LCalc * WCalc * HCalc;
            TVCalc = CuFeetCalc / Yardage;
            TPCalc = TVCalc * Pricage;

            //calculations (accumulated)
            CuFeetaccum = CuFeetaccum + CuFeetCalc;
            TVaccum = TVaccum + TVCalc;
            TPaccum = TVaccum * Pricage;
            Ordersaccum = Ordersaccum + 1;
            VolumeRemaining = TruckBed - TVaccum;


            //calculations to outputs
            CuOut.Text = CuFeetCalc.ToString("n2");
            TVOut.Text = TVCalc.ToString("n2");
            TPout.Text = TPCalc.ToString("n2");
            CuFeetAccumOut.Text = CuFeetaccum.ToString("n2");
            TPAccumOut.Text = TPaccum.ToString("c");
            TVAccumOut.Text = TVaccum.ToString("n2");
            OrdersOut.Text = Ordersaccum.ToString();
            ETVol.Text = TruckBed.ToString();
            VOOut.Text = TVaccum.ToString("n2");
            VORemOut.Text = VolumeRemaining.ToString("n2");

            if (TruckBed > TVaccum) //the IF ELSE statement depending on whci calculated cost is greater
                VORemOut.BackColor = Color.PaleTurquoise; //if the Left is greater than the right, left is Red
            else
                VORemOut.BackColor = Color.Red;

          
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            Lin.Text = null;
            Win.Text = null;
            Hin.Text = null;
            CuOut.Text = null;
            TVOut.Text = null;
            TPout.Text = null;
            CuFeetAccumOut.Text = null;
            TPAccumOut.Text = null;
            TVAccumOut.Text = null;
            OrdersOut.Text = null;
            ETVol.Text = null;
            VOOut.Text = null;
            VORemOut.Text = null;
            TVaccum = 0; 
            CuFeetaccum = 0; 
            TPaccum = 0; 
            Ordersaccum = 0; 
            VolumeRemaining = 0;
            VORemOut.BackColor = Color.LightGray;


        }

        private void ClearIn_Click(object sender, EventArgs e)
        {
            Lin.Text = null;
            Win.Text = null;
            Hin.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

  
