using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilites
{
    public partial class Form2 : Form
    {
        private double gas;
        private double water;
        private double electricity;
        public Form2(double gas, double water, double electricity)
        {
            InitializeComponent();
            this.gas = gas;
            this.water = water;
            this.electricity = electricity;
        }
//кнопка ввода данных счетчиков, перехода на окно просмотра и подсчет конечной суммы
        private void button2_Click(object sender, EventArgs e)
        {
            double inputWater = Convert.ToDouble(textBox1.Text);
            if (textBox1 == null)
            {
                inputWater = 0;
            }
            double inputGas = Convert.ToDouble(textBox2.Text);
            if (textBox2 == null)
            {
                inputGas = 0;
            }
            double inputElectricity = Convert.ToDouble(textBox3.Text);
            if (textBox3 == null)
            {
                inputElectricity = 0;
            }

            double finalWater = water * inputWater;
            double finalGas = gas * inputGas;
            double finalElecricity = electricity * inputElectricity;
            double finalCost = finalWater + finalGas + finalElecricity;

            Form3 form3 = new Form3(gas, water, electricity, finalGas, finalElecricity, finalWater, finalCost);
            form3.Show();
            this.Hide();
        }
//кнопка возврата
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
