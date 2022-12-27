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
    public partial class Form3 : Form
    {
        private double gas;
        private double water;
        private double electricity;
     // вывод конечной суммы
        public Form3(double gas, double water, double electricity, double finalGas, double finalElecricity, double finalWater, double finalCost)
        {
           
            InitializeComponent();
            this.gas = gas;
            this.water = water;
            this.electricity = electricity;
            textBox1.Text = Convert.ToString(finalGas);
            textBox2.Text = Convert.ToString(finalElecricity);
            textBox3.Text = Convert.ToString(finalWater);
            textBox4.Text = Convert.ToString(finalCost);
        }


//кнопка возврата
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2(gas, water, electricity);
            form2.Show();

        }
    }
}
