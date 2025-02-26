using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_POS_Application
{
    public partial class POS_Cashier_Interface : Form
    {

		// GLOBAL VARIABLES
       
        double price1 = 0.0;
        double price2 = 0.0;
        double price3 = 0.0;
        double price4 = 0.0;
        double price5 = 0.0;
        double price6 = 0.0;
        double price7 = 0.0;
        double price8 = 0.0;
        double price9 = 0.0;
        double price10 = 0.0;
        double price11 = 0.0;
        double price12 = 0.0;
        double price13 = 0.0;
        double price14 = 0.0;
        double price15 = 0.0;
        double price16 = 0.0;
        double price17 = 0.0;
        double price18 = 0.0;
        double price19 = 0.0;
        double price20 = 0.0;


        String baseString = "G:\\school\\3rdyr\\2ndsem\\ecp\\prelim\\quiqui\\forks\\Quiz1_Elective\\images"; // change accordingly



        public POS_Cashier_Interface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Blue;
            this.Text = "Point of Sale Interface";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// //////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dinnerBtn_Click(object sender, EventArgs e)
        {
            price1 = 150.00;
            price2 = 200.00;
            price3 = 250.00;
            price4 = 195.00;
            price5 = 275.00;
            price6 = 100.00;
            price7 = 150.00;
            price8 = 200.00;
            price9 = 175.00;
            price10 = 150.00;
            price11 = 125.00;
            price12 = 300.00;
            price13 = 125.00;
            price14 = 150.00;
            price15 = 165.00;
            price16 = 135.00;
            price17 = 155.00;
            price18 = 120.00;
            price19 = 250.00;
            price20 = 130.00;

            String specificContext = "\\dinner\\d";
            String whatPack = "Dinner Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");

            namelbl1.Text = whatPack + " 1";
            namelbl2.Text = whatPack + " 2";
            namelbl3.Text = whatPack + " 3";
            namelbl4.Text = whatPack + " 4";
            namelbl5.Text = whatPack + " 5";
            namelbl6.Text = whatPack + " 6";
            namelbl7.Text = whatPack + " 7";
            namelbl8.Text = whatPack + " 8";
            namelbl9.Text = whatPack + " 9";
            namelbl10.Text = whatPack + " 10";
            namelbl11.Text = whatPack + " 11";
            namelbl12.Text = whatPack + " 12";
            namelbl13.Text = whatPack + " 13";
            namelbl14.Text = whatPack + " 14";
            namelbl15.Text = whatPack + " 15";
            namelbl16.Text = whatPack + " 16";
            namelbl17.Text = whatPack + " 17";
            namelbl18.Text = whatPack + " 18";
            namelbl19.Text = whatPack + " 19";
            namelbl20.Text = whatPack + " 20";



        }
        private void lunchBtn_Click(object sender, EventArgs e)
        {
            price1 = 189.00;
            price2 = 100.00;
            price3 = 120.00;
            price4 = 175.00;
            price5 = 165.00;
            price6 = 180.00;
            price7 = 295.00;
            price8 = 200.00;
            price9 = 250.00;
            price10 = 175.00;
            price11 = 190.00;
            price12 = 205.00;
            price13 = 100.00;
            price14 = 195.00;
            price15 = 215.00;
            price16 = 199.00;
            price17 = 169.00;
            price18 = 190.00;
            price19 = 315.00;
            price20 = 225.00;


            String specificContext = "\\lunch\\l";
            String whatPack = "Lunch Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");

            namelbl1.Text = whatPack + " 1";
            namelbl2.Text = whatPack + " 2";
            namelbl3.Text = whatPack + " 3";
            namelbl4.Text = whatPack + " 4";
            namelbl5.Text = whatPack + " 5";
            namelbl6.Text = whatPack + " 6";
            namelbl7.Text = whatPack + " 7";
            namelbl8.Text = whatPack + " 8";
            namelbl9.Text = whatPack + " 9";
            namelbl10.Text = whatPack + " 10";
            namelbl11.Text = whatPack + " 11";
            namelbl12.Text = whatPack + " 12";
            namelbl13.Text = whatPack + " 13";
            namelbl14.Text = whatPack + " 14";
            namelbl15.Text = whatPack + " 15";
            namelbl16.Text = whatPack + " 16";
            namelbl17.Text = whatPack + " 17";
            namelbl18.Text = whatPack + " 18";
            namelbl19.Text = whatPack + " 19";
            namelbl20.Text = whatPack + " 20";
        }

        private void dessertsBtn_Click(object sender, EventArgs e)
        {
            price1 = 250.00;
            price2 = 200.00;
            price3 = 285.00;
            price4 = 275.00;
            price5 = 300.00;
            price6 = 290.00;
            price7 = 195.00;
            price8 = 399.00;
            price9 = 400.00;
            price10 = 415.00;
            price11 = 350.00;
            price12 = 388.00;
            price13 = 265.00;
            price14 = 375.00;
            price15 = 300.00;
            price16 = 220.00;
            price17 = 425.00;
            price18 = 365.00;
            price19 = 395.00;
            price20 = 210.00;

            String specificContext = "\\dessert\\s";
            String whatPack = "Dessert Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");

            namelbl1.Text = whatPack + " 1";
            namelbl2.Text = whatPack + " 2";
            namelbl3.Text = whatPack + " 3";
            namelbl4.Text = whatPack + " 4";
            namelbl5.Text = whatPack + " 5";
            namelbl6.Text = whatPack + " 6";
            namelbl7.Text = whatPack + " 7";
            namelbl8.Text = whatPack + " 8";
            namelbl9.Text = whatPack + " 9";
            namelbl10.Text = whatPack + " 10";
            namelbl11.Text = whatPack + " 11";
            namelbl12.Text = whatPack + " 12";
            namelbl13.Text = whatPack + " 13";
            namelbl14.Text = whatPack + " 14";
            namelbl15.Text = whatPack + " 15";
            namelbl16.Text = whatPack + " 16";
            namelbl17.Text = whatPack + " 17";
            namelbl18.Text = whatPack + " 18";
            namelbl19.Text = whatPack + " 19";
            namelbl20.Text = whatPack + " 20";
        }

        private void breakfastBrn_Click(object sender, EventArgs e)
        {
            price1 = 199.00;
            price2 = 300.00;
            price3 = 125.00;
            price4 = 95.00;
            price5 = 150.00;
            price6 = 225.00;
            price7 = 299.00;
            price8 = 120.00;
            price9 = 310.00;
            price10 = 155.00;
            price11 = 265.00;
            price12 = 325.00;
            price13 = 375.00;
            price14 = 140.00;
            price15 = 100.00;
            price16 = 230.00;
            price17 = 180.00;
            price18 = 190.00;
            price19 = 360.00;
            price20 = 105.00;

            String specificContext = "\\breakfast\\b";
            String whatPack = "Breakfast Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");

            namelbl1.Text = whatPack + " 1";
            namelbl2.Text = whatPack + " 2";
            namelbl3.Text = whatPack + " 3";
            namelbl4.Text = whatPack + " 4";
            namelbl5.Text = whatPack + " 5";
            namelbl6.Text = whatPack + " 6";
            namelbl7.Text = whatPack + " 7";
            namelbl8.Text = whatPack + " 8";
            namelbl9.Text = whatPack + " 9";
            namelbl10.Text = whatPack + " 10";
            namelbl11.Text = whatPack + " 11";
            namelbl12.Text = whatPack + " 12";
            namelbl13.Text = whatPack + " 13";
            namelbl14.Text = whatPack + " 14";
            namelbl15.Text = whatPack + " 15";
            namelbl16.Text = whatPack + " 16";
            namelbl17.Text = whatPack + " 17";
            namelbl18.Text = whatPack + " 18";
            namelbl19.Text = whatPack + " 19";
            namelbl20.Text = whatPack + " 20";
        }

        private void beveragesBtn_Click(object sender, EventArgs e)
        {
            price1 = 110.00;
            price2 = 89.00;
            price3 = 75.00;
            price4 = 100.00;
            price5 = 98.00;
            price6 = 85.00;
            price7 = 78.00;
            price8 = 120.00;
            price9 = 110.00;
            price10 = 80.00;
            price11 = 90.00;
            price12 = 99.00;
            price13 = 110.00;
            price14 = 77.00;
            price15 = 75.00;
            price16 = 92.00;
            price17 = 78.00;
            price18 = 125.00;
            price19 = 108.00;
            price20 = 89.00;


            String specificContext = "\\beverages\\";
            String whatPack = "Beverage Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "beer1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "beer2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "beer3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "beer4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "beer5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "juice1.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "juice2.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "juice3.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "juice4.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "juice5.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "soda1.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "soda2.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "soda3.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "soda4.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "tea1.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "tea2.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "tea3.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "tea5.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "tea6.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "tea7.jfif");


            namelbl1.Text = whatPack + " 1";
            namelbl2.Text = whatPack + " 2";
            namelbl3.Text = whatPack + " 3";
            namelbl4.Text = whatPack + " 4";
            namelbl5.Text = whatPack + " 5";
            namelbl6.Text = whatPack + " 6";
            namelbl7.Text = whatPack + " 7";
            namelbl8.Text = whatPack + " 8";
            namelbl9.Text = whatPack + " 9";
            namelbl10.Text = whatPack + " 10";
            namelbl11.Text = whatPack + " 11";
            namelbl12.Text = whatPack + " 12";
            namelbl13.Text = whatPack + " 13";
            namelbl14.Text = whatPack + " 14";
            namelbl15.Text = whatPack + " 15";
            namelbl16.Text = whatPack + " 16";
            namelbl17.Text = whatPack + " 17";
            namelbl18.Text = whatPack + " 18";
            namelbl19.Text = whatPack + " 19";
            namelbl20.Text = whatPack + " 20";

        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {

            price1 = 55.00;
            price2 = 45.00;
            price3 = 70.00;
            price4 = 59.00;
            price5 = 54.00;
            price6 = 65.00;
            price7 = 110.00;
            price8 = 90.00;
            price9 = 66.00;
            price10 = 51.00;
            price11 = 99.00;
            price12 = 105.00;
            price13 = 90.00;
            price14 = 68.00;
            price15 = 105.00;
            price16 = 70.00;
            price17 = 115.00;
            price18 = 50.00;
            price19 = 88.00;
            price20 = 77.00;

            String specificContext = "\\coffee\\c";
            String whatPack = "Coffee Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");


            namelbl1.Text = whatPack + " 1";
            namelbl2.Text = whatPack + " 2";
            namelbl3.Text = whatPack + " 3";
            namelbl4.Text = whatPack + " 4";
            namelbl5.Text = whatPack + " 5";
            namelbl6.Text = whatPack + " 6";
            namelbl7.Text = whatPack + " 7";
            namelbl8.Text = whatPack + " 8";
            namelbl9.Text = whatPack + " 9";
            namelbl10.Text = whatPack + " 10";
            namelbl11.Text = whatPack + " 11";
            namelbl12.Text = whatPack + " 12";
            namelbl13.Text = whatPack + " 13";
            namelbl14.Text = whatPack + " 14";
            namelbl15.Text = whatPack + " 15";
            namelbl16.Text = whatPack + " 16";
            namelbl17.Text = whatPack + " 17";
            namelbl18.Text = whatPack + " 18";
            namelbl19.Text = whatPack + " 19";
            namelbl20.Text = whatPack + " 20";
        }



        /// <summary>
        /// behaviour for picture boxes
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl1.Text;
            pricetextbox.Text = Convert.ToString(price1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl2.Text;
            pricetextbox.Text = Convert.ToString(price2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl3.Text;
            pricetextbox.Text = Convert.ToString(price3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl4.Text;
            pricetextbox.Text = Convert.ToString(price4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl5.Text;
            pricetextbox.Text = Convert.ToString(price5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl6.Text;
            pricetextbox.Text = Convert.ToString(price6);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl7.Text;
            pricetextbox.Text = Convert.ToString(price7);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl8.Text;
            pricetextbox.Text = Convert.ToString(price8);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl9.Text;
            pricetextbox.Text = Convert.ToString(price9);
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl10.Text;
            pricetextbox.Text = Convert.ToString(price10);
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl11.Text;
            pricetextbox.Text = Convert.ToString(price11);
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl12.Text;
            pricetextbox.Text = Convert.ToString(price12);
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl13.Text;
            pricetextbox.Text = Convert.ToString(price13);
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl14.Text;
            pricetextbox.Text = Convert.ToString(price14);
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl15.Text;
            pricetextbox.Text = Convert.ToString(price15);
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl16.Text;
            pricetextbox.Text = Convert.ToString(price16);
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl17.Text;
            pricetextbox.Text = Convert.ToString(price17);
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl18.Text;
            pricetextbox.Text = Convert.ToString(price18);
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl19.Text;
            pricetextbox.Text = Convert.ToString(price19);
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl20.Text;
            pricetextbox.Text = Convert.ToString(price20);
		}

        /// <summary>
        /// for processing the discount checkboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// for processing the calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcbtn_Click(object sender, EventArgs e)
        {

        }

        private void newbtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {

        }

        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
