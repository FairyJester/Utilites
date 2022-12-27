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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//кнопка перехода на следующее окно и перенос значений тарифа
        private void button1_Click(object sender, EventArgs e)
        {


            double water = Convert.ToDouble(Water());
            double gas = Convert.ToDouble(Gas());
            double electricity = Convert.ToDouble(Electricity());

            Form2 form2 = new Form2(gas, water, electricity);
            form2.Show();


            this.Hide();
        }
//кнопка выхода из приложения
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


//методы для выбора тарифа по районам
        public double Water()
        {
           
                string district = comboBox1.Text;
                switch (district)
                {
                    case "Кузнецкий район":
                        return 5.43;


                    case "Бессоновский район":
                        return 4.93;


                    case "Пензенский район":
                        return 6.43;

                    case "Шемышейский район":
                        return 5.76;


                }
                return 0;
            
        

        }
        public double Gas()
        {
            string district = comboBox1.Text;
            switch (district)
            {
                case "Кузнецкий район":
                    return 6.43;

                case "Бессоновский район":
                    return 5.432;

                case "Пензенский район":
                    return 4.97;

                case "Шемышейский район":
                    return 6.453;



            }
            return 0;

        }
        public double Electricity()
        {
            string district = comboBox1.Text;
            string house = comboBox2.Text;
            switch (district)
            {
                case "Кузнецкий район":
                    if (house == "стационарный")
                    {
                        return 2.43;
                    }
                    else
                    {
                        return 4.34;
                    }

                case "Бессоновский район":
                    if (house == "стационарный")
                    {
                        return 2.43;
                    }
                    else
                    {
                        return 4.34;
                    }

                case "Пензенский район":
                    if (house == "стационарный")
                    {
                        return 2.43;
                    }
                    else
                    {
                        return 4.34;
                    }

                case "шемышейский район":
                    if (house == "стационарный")
                    {
                        return 2.43;
                    }
                    else
                    {
                        return 4.34;
                    }


            }
            return 0;

        }

    }

}
    
	

