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

        double gl_price = 0.0;
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
            // default the first option
            itemnametxtbox.Text = name1lbl.Text;
            gl_price = 120.0;


            String baseString = "C:\\Users\\USER\\OneDrive\\Desktop\\New_POS_Application\\images";
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

            name1lbl.Text = whatPack + " 1";
            name2lbl.Text = whatPack + " 2";
            name3lbl.Text = whatPack + " 3";
            name4lbl.Text = whatPack + " 4";
            name5lbl.Text = whatPack + " 5";
            name6lbl.Text = whatPack + " 6";
            name7lbl.Text = whatPack + " 7";
            name8lbl.Text = whatPack + " 8";
            name9lbl.Text = whatPack + " 9";
            name10lbl.Text = whatPack + " 10";
            name11lbl.Text = whatPack + " 11";
            name12lbl.Text = whatPack + " 12";
            name13lbl.Text = whatPack + " 13";
            name14lbl.Text = whatPack + " 14";
            name15lbl.Text = whatPack + " 15";


        }
        private void lunchBtn_Click(object sender, EventArgs e)
        {
            // default the first option
            itemnametxtbox.Text = name1lbl.Text;
            gl_price = 150.0;


            String baseString = "C:\\Users\\USER\\OneDrive\\Desktop\\New_POS_Application\\images";
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

            name1lbl.Text = whatPack + " 1";
            name2lbl.Text = whatPack + " 2";
            name3lbl.Text = whatPack + " 3";
            name4lbl.Text = whatPack + " 4";
            name5lbl.Text = whatPack + " 5";
            name6lbl.Text = whatPack + " 6";
            name7lbl.Text = whatPack + " 7";
            name8lbl.Text = whatPack + " 8";
            name9lbl.Text = whatPack + " 9";
            name10lbl.Text = whatPack + " 10";
            name11lbl.Text = whatPack + " 11";
            name12lbl.Text = whatPack + " 12";
            name13lbl.Text = whatPack + " 13";
            name14lbl.Text = whatPack + " 14";
            name15lbl.Text = whatPack + " 15";
        }

        private void dessertsBtn_Click(object sender, EventArgs e)
        {
            // default the first option
            itemnametxtbox.Text = name1lbl.Text;
            gl_price = 100.0;


            String baseString = "C:\\Users\\USER\\OneDrive\\Desktop\\New_POS_Application\\images";
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

            name1lbl.Text = whatPack + " 1";
            name2lbl.Text = whatPack + " 2";
            name3lbl.Text = whatPack + " 3";
            name4lbl.Text = whatPack + " 4";
            name5lbl.Text = whatPack + " 5";
            name6lbl.Text = whatPack + " 6";
            name7lbl.Text = whatPack + " 7";
            name8lbl.Text = whatPack + " 8";
            name9lbl.Text = whatPack + " 9";
            name10lbl.Text = whatPack + " 10";
            name11lbl.Text = whatPack + " 11";
            name12lbl.Text = whatPack + " 12";
            name13lbl.Text = whatPack + " 13";
            name14lbl.Text = whatPack + " 14";
            name15lbl.Text = whatPack + " 15";
        }

        private void breakfastBrn_Click(object sender, EventArgs e)
        {
            // default the first option
            itemnametxtbox.Text = name1lbl.Text;
            gl_price = 200.0;

            String baseString = "C:\\Users\\USER\\OneDrive\\Desktop\\New_POS_Application\\images";
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

            name1lbl.Text = whatPack + " 1";
            name2lbl.Text = whatPack + " 2";
            name3lbl.Text = whatPack + " 3";
            name4lbl.Text = whatPack + " 4";
            name5lbl.Text = whatPack + " 5";
            name6lbl.Text = whatPack + " 6";
            name7lbl.Text = whatPack + " 7";
            name8lbl.Text = whatPack + " 8";
            name9lbl.Text = whatPack + " 9";
            name10lbl.Text = whatPack + " 10";
            name11lbl.Text = whatPack + " 11";
            name12lbl.Text = whatPack + " 12";
            name13lbl.Text = whatPack + " 13";
            name14lbl.Text = whatPack + " 14";
            name15lbl.Text = whatPack + " 15";
        }

        private void beveragesBtn_Click(object sender, EventArgs e)
        {
            // default the first option
            itemnametxtbox.Text = name1lbl.Text;
            gl_price = 90.0;


            String baseString = "C:\\Users\\USER\\OneDrive\\Desktop\\New_POS_Application\\images";
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


            name1lbl.Text = whatPack + " 1";
            name2lbl.Text = whatPack + " 2";
            name3lbl.Text = whatPack + " 3";
            name4lbl.Text = whatPack + " 4";
            name5lbl.Text = whatPack + " 5";
            name6lbl.Text = whatPack + " 6";
            name7lbl.Text = whatPack + " 7";
            name8lbl.Text = whatPack + " 8";
            name9lbl.Text = whatPack + " 9";
            name10lbl.Text = whatPack + " 10";
            name11lbl.Text = whatPack + " 11";
            name12lbl.Text = whatPack + " 12";
            name13lbl.Text = whatPack + " 13";
            name14lbl.Text = whatPack + " 14";
            name15lbl.Text = whatPack + " 15";
            name16lbl.Text = whatPack + " 16";
            name17lbl.Text = whatPack + " 17";
            name18lbl.Text = whatPack + " 18";
            name19lbl.Text = whatPack + " 19";
            name20lbl.Text = whatPack + " 20";

        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {

            // default the first option
            itemnametxtbox.Text = name1lbl.Text;
            gl_price = 12.0;

            String baseString = "C:\\Users\\USER\\OneDrive\\Desktop\\New_POS_Application\\images";
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


            name1lbl.Text = whatPack + " 1";
            name2lbl.Text = whatPack + " 2";
            name3lbl.Text = whatPack + " 3";
            name4lbl.Text = whatPack + " 4";
            name5lbl.Text = whatPack + " 5";
            name6lbl.Text = whatPack + " 6";
            name7lbl.Text = whatPack + " 7";
            name8lbl.Text = whatPack + " 8";
            name9lbl.Text = whatPack + " 9";
            name10lbl.Text = whatPack + " 10";
            name11lbl.Text = whatPack + " 11";
            name12lbl.Text = whatPack + " 12";
            name13lbl.Text = whatPack + " 13";
            name14lbl.Text = whatPack + " 14";
            name15lbl.Text = whatPack + " 15";
        }



        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name1lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name2lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name3lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name4lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name5lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name6lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name7lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name8lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name9lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name10lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name11lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name12lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name13lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name14lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name15lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name16lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name17lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name18lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name19lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name20lbl.Text;
            pricetextbox.Text = Convert.ToString(gl_price);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
