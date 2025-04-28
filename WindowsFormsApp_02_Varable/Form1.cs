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
            // 초등학교 학생수
            short studentCount = 30;
            int myInt;
            long distanceToCanada_cm = 20;
            float myFloat;
            // 우주 로켓 발사 속도
            double spaceToMoon_km;
            decimal myDecimal;

            textBox_print1.Text = $"{retroColorRed.GetType()} retroColorRed: {retroColorRed}";
            textBox_print1.Text += $"\r\n{distanceToCanada_cm.GetType()} distanceToCanada_cm: {distanceToCanada_cm}";
            textBox_print1.Text += "\r\n";
            int a = 5;
            int b = 2;
            textBox_print1.Text += a.ToString();
            textBox_print1.Text += "\r\n";
            textBox_print1.Text += $"{a} + {b} = {a + b} \r\n";
            textBox_print1.Text += $"{a} - {b} = {a - b}\r\n";
            textBox_print1.Text += $"{a} * {b} = {a * b}\r\n";
            textBox_print1.Text += $"{a} / {b} = {a / b}\r\n";
            textBox_print1.Text += $"{a} % {b} = {a % b}\r\n";
            textBox_print1.Text += $"{a}pow{b}={Math.Pow(a, b)}\r\n";//a의 b제곱
            textBox_print1.Text += $"{Math.Sqrt(9)}\r\n";//루트

            textBox_print1.Text += $"{1 == 1}\r\n";
            textBox_print1.Text += $"{1 == 2}\r\n";
            textBox_print1.Text += $"{2 >= 2}\r\n";
            textBox_print1.Text += $"{2 >= 1}\r\n";
            textBox_print1.Text += $"{2 <= 2}\r\n";

            textBox_print1.Text += $"\r\n";

            textBox_print1.Text += $"{!true}\r\n";
            textBox_print1.Text += $"{!!true}\r\n";
            textBox_print1.Text += $"{!!!true}\r\n";
            textBox_print1.Text += $"{!!!!true}\r\n";
            textBox_print1.Text += $"\r\n";
            textBox_print1.Text += $"{true&&true}\r\n";
            textBox_print1.Text += $"{true&&false}\r\n";
            textBox_print1.Text += $"{false && false}\r\n";
            textBox_print1.Text += $"\r\n";
            textBox_print1.Text += $"{true||true}\r\n";
            textBox_print1.Text += $"{true||false}\r\n";
            textBox_print1.Text += $"{false||false}\r\n";
            textBox_print1.Text += $"\r\n";

            int num = 10;
            int num2 = 10;
            int result1 = num++; //주의 대입 안해도 num 값이 오른다
            int result2 = ++num2;
            textBox_print1.Text = $"{result1}\r\n";
            textBox_print1.Text += $"{result2}\r\n";

            textBox_print1.Text = $"{num+=1}\r\n";//12
            textBox_print1.Text = $"{num-=1}\r\n";//11
            textBox_print1.Text += $"{num2 *=num2}\r\n";//121
            textBox_print1.Text += $"{num2 /= num2}\r\n";//

            //실습 2
            // q1
            //가격
            int price = 1000;
            //수량
            int count = 5;
            // 과일
            string fruit = "사과";
            textBox_print1.Text = $"{fruit} {count}개의 총 가격은 {price * count}원입니다.\r\n";

            // q2
            string strInt = "15";
            int myInt2 = 10;
            textBox_print1.Text = $"{strInt}에 {myInt2}를 더하면 {Convert.ToInt32(strInt) + myInt2}";

            // q3
            // 상품명
            string productName = "노트북";
            // 가격
            int productPrice = 1000000;
            //할인율
            float discountRate = 0.1f;
            // 재고 수량
            byte stockCount = 10;
            bool isAvailable = false;
            //할인된 가격
            double discountedPrice = productPrice * (1 - discountRate);
            if(studentCount > 0)
            {
                isAvailable = true;
                textBox_print1.Text=$"구매 가능: 할인 가격은 {discountedPrice:F2}입니다.\r\n";//실수 2자리 까지만 출력
            }
            else
            {
                isAvailable = false;
                textBox_print1.Text = $"품절되었습니다.\r\n";
            }
            if (studentCount >= 5)
            {
                textBox2.Text = "여유 있음";
            }
            else
            {
                textBox2.Text = "소량 남음";
            }
            textBox3.Text = $"상품명:{productName},할인된 가격:{discountedPrice:F2}원, 재고:{studentCount}개";
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
