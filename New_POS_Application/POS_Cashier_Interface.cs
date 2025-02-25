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
        double gl_price = 0.0;
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
            name9lbl.Text = whatPack + " 9";
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
            name9lbl.Text = whatPack + " 9";
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
            name9lbl.Text = whatPack + " 9";
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
            name9lbl.Text = whatPack + " 9";
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
            name9lbl.Text = whatPack + " 9";
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
            name9lbl.Text = whatPack + " 9";
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
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl2.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl3.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl4.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl5.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl6.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl7.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl8.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name9lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl10.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl11.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl12.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl13.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl14.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl15.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl16.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl17.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl18.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl19.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl20.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
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
    }
}
