using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_02_Varable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int numOfCrew;
            numOfCrew = 19;
            string className = "말하기";
            className = "수학";
            int lineCount;
            byte buffer;
            int number = 10;
            string word = "a";
            //number=Convert.ToInt32(word);//불가
            //textBox1.Text=number.ToString();

            short word2 = 20;
            number = word2;
            int var_x = 10;
            int var_y = var_x;

            int var_z = var_x * var_y;
            int result = var_z = (var_x + 5);

            {
                int inside = 100;
            }
            //textBox_print.Text = numOfCrew.GetType() + "numOfCrew: " + numOfCrew.ToString() + "\r\n";


            // 실습
            byte retroColorRed = 20;
            short myShort;
            int myInt;
            long distanceToCanada_cm = 20;
            float myFloat;
            double myDouble;
            decimal myDecimal;

            textBox_print.Text = $"{retroColorRed.GetType()} retroColorRed: {retroColorRed}";
            textBox_print.Text += $"\r\n{distanceToCanada_cm.GetType()} distanceToCanada_cm: {distanceToCanada_cm}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
