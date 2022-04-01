using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denis3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox 
            double x = Convert.ToDouble(textBox1.Text);
            double p = Convert.ToDouble(textBox2.Text);
            double f = 0;
            // Ввод исходных данных в окно результатов 
            textBox4.Text = "Результаты работы программы " +
            "ст. Негруша Д.А. " +
            Environment.NewLine;
            textBox4.Text += "При X = " + textBox1.Text +
            Environment.NewLine;
            textBox4.Text += "При P = " + textBox2.Text +
            Environment.NewLine;
            // Вычисление выражения 
            if (radioButton1.Checked)
                f = (Math.Exp(x) - Math.Exp(-x)) / 2;
            else if (radioButton2.Checked)
                f = x * x;
            else if (radioButton3.Checked)
                f = Math.Exp(x);
            double l = 0;
            if (x > Math.Abs(p))
                l = 2 * Math.Pow(f, 3) + 3 * p * p;
            else
            if (x > 3 && x < Math.Abs(p))
                l = Math.Abs(f - p);
            else
            if (x == Math.Abs(p))
                l = Math.Pow((f - p), 2);
            // Вывод результата 
            textBox4.Text += "L = " + l.ToString() +
            Environment.NewLine;
            Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }
    }
}
