using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zawedenie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        bool Karta = false;
        bool cash = false;
        double sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            double a = double.Parse(textBox1.Text);
            if (textBox1.Text != "")
            {
                double SumaA = a * 5.50;
                sum = sum + SumaA;
            }


            double b = double.Parse(textBox2.Text);
            if (textBox1.Text != "")
            {
                double SumaB = b * 3.70;
                sum = sum + SumaB;
            }

            double c = double.Parse(textBox3.Text);
            if (textBox1.Text != "")
            {
                double SumaC = c * 4.85;
                sum = sum + SumaC;
            }

            double d = double.Parse(textBox4.Text);
            if (textBox1.Text != "")
            {
                double SumaD = d * 3;
                sum = sum + SumaD;
            }

            double f = double.Parse(textBox5.Text);
            if (textBox1.Text != "")
            {
                double SumaF = f * 10;
                sum = sum + SumaF;
            }

            double g = double.Parse(textBox6.Text);
            if (textBox1.Text != "")
            {
                double SumaG = g * 25;
                sum = sum + SumaG;
            }

            double h = double.Parse(textBox9.Text);
            if (textBox1.Text != "")
            {
                double SumaH = h * 3;
                sum = sum + SumaH;
            }

            double i = double.Parse(textBox8.Text);
            if (textBox1.Text != "")
            {
                double SumaI = i * 2;
                sum = sum + SumaI;
            }

            double j = double.Parse(textBox7.Text);
            if (textBox1.Text != "")
            {
                double SumaJ = j * 3;
                sum = sum + SumaJ;
            }

            double k = double.Parse(textBox12.Text);
            if (textBox1.Text != "")
            {
                double SumaK = k * 7;
                sum = sum + SumaK;
            }

            double l = double.Parse(textBox11.Text);
            if (textBox1.Text != "")
            {
                double SumaL = l * 3.70;
                sum = sum + SumaL;
            }

            double m = double.Parse(textBox10.Text);
            if (textBox1.Text != "")
            {
                double SumaM = m * 15;
                sum = sum + SumaM;
            }

            double n = double.Parse(textBox15.Text);
            if (textBox1.Text != "")
            {
                double SumaN = n * 4;
                sum = sum + SumaN;
            }

            double o = double.Parse(textBox14.Text);
            if (textBox1.Text != "")
            {
                double SumaO = o * 1;
                sum = sum + SumaO;
            }

            double p = double.Parse(textBox13.Text);
            if (textBox1.Text != "")
            {
                double SumaP = p * 0.80;
                sum = sum + SumaP;
            }

            double q = double.Parse(textBox18.Text);
            if (textBox1.Text != "")
            {
                double SumaQ = q * 0.70;
                sum = sum + SumaQ;
            }

            double r = double.Parse(textBox17.Text);
            if (textBox1.Text != "")
            {
                double SumaR = r * 2;
                sum = sum + SumaR;
            }

            double s = double.Parse(textBox16.Text);
            if (textBox1.Text != "")
            {
                double SumaS = s * 7;
                sum = sum + SumaS;
            }

            if (Karta)
            {
                sum = sum * 1.05; //добавяме 5 % към сметката
            }
           
            MessageBox.Show("Общата сума е: " + sum + " лева");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //сортирането на сметката ако е по брой на артикулите 

            TextBox[] textBoxes = {textBox1, textBox2, textBox3, textBox4, textBox5, textBox6,
    textBox7, textBox8, textBox9, textBox10, textBox11, textBox12,
    textBox13, textBox14, textBox15, textBox16, textBox17, textBox18};

            // Създаване на масив за съхранение на поръчките
            int[] poruchki = new int[textBoxes.Length];

          
           

            // Извличане на поръчките от textBoxes и пресмятане на сумата
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (int.TryParse(textBoxes[i].Text, out int order))
                {
                    poruchki[i] = order;
                    sum += order;
                }
            }

            // Проверка дали сумата е под 100
            if (sum < 100)
            {
                // Сортиране на поръчките във възходящ ред
                Array.Sort(poruchki);

                // Формиране на съобщението със сортираните поръчки
                string message = "Сортирани поръчки:\n";
                foreach (int order in poruchki)
                {
                    message += order.ToString() + "\n";
                }

                // Извеждане на съобщението в MessageBox
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Сумата на поръчките е над 100.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Karta = !Karta;  
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cash = !cash; 
                         
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
