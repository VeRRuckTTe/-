using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_19
{
    public partial class PR_19 : Form
    {
        public PR_19()
        {
            InitializeComponent();
        }

        private void Ex1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "Введите число");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox3, "Введите число");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox4, "Введите число");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Вывод результата");
        }

        private void Result1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox1.Text);
                double c = double.Parse(textBox1.Text);
                double t1, t2, t3, t4, t5, t6, t7, t8, t9, s;
                t1 = Math.Pow(10, 1 / 3);
                t2 = Math.Pow(a, 3 * Math.Abs(b));
                t3 = 1 / t2;
                t4 = Math.Pow(b, 4);
                t5 = Math.Pow(c, 1 / 2);
                t6 = t3 * t4 * t5;
                t7 = t1 + t6;
                t8 = Math.Log10(t7);
                t9 = Math.Pow(Math.E, a * b * Math.Pow(c, -2));
                s = t9 + t8;
                s = Math.Round(s, 3, MidpointRounding.AwayFromZero);
            }
            catch (FormatException)
            { 
                MessageBox.Show("Данные введены не верно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
