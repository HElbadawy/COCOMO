using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        string mode;
        int kloc;
        double a, b, c, d, eaf, Effort, actualE;
        public Form1()
        {
            InitializeComponent();
            customizedDesign();
        }
        
        private void customizedDesign() 
        {
            panelModesSubMenu.Visible = false;
        }
        private void hideSubMenu() 
        {
            if (panelModesSubMenu.Visible == true) 
            {
                panelModesSubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void btnModes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelModesSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = "Organic";
            modeLabel.Text = mode;
            setCoef();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = "Semidetached";
            modeLabel.Text = mode;
            setCoef();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mode = "Embedded";
            modeLabel.Text = mode;
            setCoef();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox2.Text, out kloc))
            {
                modeLabel.Text = "";
                mode = "";
                button1.Enabled = false;
                return;
            }else
                button1.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Effort = a * Math.Pow(Convert.ToDouble(kloc), b);
            labelCalcEffort.Text = Convert.ToString(Effort);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            actualE = Effort * eaf;
            label22.Text = Convert.ToString(actualE);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double TDEV;
            TDEV = c * Math.Pow(actualE, d);
            labelCalcTDEV.Text = Convert.ToString(TDEV);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ktext = textBox2.Text;
           

            if (kloc >= 2 && kloc < 50)
            {
                mode = "Organic";
            }
            else if (kloc >= 50 && kloc <= 300)
            {
                mode = "Semidetached";
            }
            else
            {
                mode = "Embedded";
            }

            modeLabel.Text = mode;
            setCoef();
        }

        private void setCoef()
        {
            if (mode == "Organic")
            {
                a = 3.2f;
                b = 1.05f;
                c = 2.5f;
                d = 0.38f;
            }

            if (mode == "Semidetached")
            {
                a = 3.0f;
                b = 1.12f;
                c = 2.5f;
                d = 0.35f;
            }

            if (mode == "Embedded")
            {
                a = 2.8f;
                b = 1.20f;
                c = 2.5f;
                d = 0.32f;
            }


    
        }


        double a1 = 1, a2 = 1, a3 = 1, a4 = 1, a5 = 1, a6 = 1, a7 = 1, a8 = 1, a9 = 1, a10 = 1, a11 = 1, a12 = 1, a13 = 1, a14 = 1, a15 = 1;

        private void button6_Click_1(object sender, EventArgs e)
        {

            if (comboBox10.SelectedItem == "Very Low")
                a11 = 1.21;
            else if (comboBox10.SelectedItem == "Low")
                a11 = 1.10;
            else if (comboBox10.SelectedItem == "Nominal")
                a11 = 1.00;
            else if (comboBox10.SelectedItem == "High")
                a11 = 0.90;
            if (comboBox11.SelectedItem == "Very Low")
                a12 = 1.14;
            else if (comboBox11.SelectedItem == "Low")
                a12 = 1.07;
            else if (comboBox11.SelectedItem == "Nominal")
                a12 = 1.00;
            else if (comboBox11.SelectedItem == "High")
                a12 = 0.95;

            if (comboBox15.SelectedItem == "Very Low")
                a14 = 1.24;
            else if (comboBox15.SelectedItem == "Low")
                a14 = 1.10;
            else if (comboBox15.SelectedItem == "Nominal")
                a14 = 1.00;
            else if (comboBox15.SelectedItem == "High")
                a14 = 0.91;
            else if (comboBox15.SelectedItem == "Very High")
                a14 = 0.83;


            if (comboBox14.SelectedItem == "Very Low")
                a15 = 1.23;
            else if (comboBox14.SelectedItem == "Low")
                a15 = 1.08;
            else if (comboBox14.SelectedItem == "Nominal")
                a15 = 1.00;
            else if (comboBox14.SelectedItem == "High")
                a15 = 1.04;
            else if (comboBox14.SelectedItem == "Very High")
                a15 = 1.10;

            if (comboBox9.SelectedItem == "Very Low")
                a10 = 1.42;
            else if (comboBox9.SelectedItem == "Low")
                a10 = 1.17;
            else if (comboBox9.SelectedItem == "Nominal")
                a10 = 1.00;
            else if (comboBox9.SelectedItem == "High")
                a10 = 0.86;
            else if (comboBox9.SelectedItem == "Very High")
                a10 = 0.70;


            if (comboBox8.SelectedItem == "Very Low")
                a9 = 1.29;
            else if (comboBox8.SelectedItem == "Low")
                a9 = 1.13;
            else if (comboBox8.SelectedItem == "Nominal")
                a9 = 1.00;
            else if (comboBox8.SelectedItem == "High")
                a9 = 0.91;
            else if (comboBox8.SelectedItem == "Very High")
                a9 = 0.82;


            if (comboBox7.SelectedItem == "Very Low")
                a8 = 1.46;
            else if (comboBox7.SelectedItem == "Low")
                a8 = 1.19;
            else if (comboBox7.SelectedItem == "Nominal")
                a8 = 1.00;
            else if (comboBox7.SelectedItem == "High")
                a8 = 0.86;
            else if (comboBox7.SelectedItem == "Very High")
                a8 = 0.71;



            if (comboBox5.SelectedItem == "Low")
                a7 = 0.87;
            else if (comboBox5.SelectedItem == "Nominal")
                a7 = 1.00;
            else if (comboBox5.SelectedItem == "High")
                a7 = 1.07;
            else if (comboBox5.SelectedItem == "Very High")
                a7 = 1.15;


            if (comboBox12.SelectedItem == "Nominal")
                a5 = 1.00;
            else if (comboBox12.SelectedItem == "High")
                a5 = 1.06;
            else if (comboBox12.SelectedItem == "Very High")
                a5 = 1.21;
            else if (comboBox12.SelectedItem == "Extre High")
                a5 = 1.56;



            if (comboBox6.SelectedItem == "Nominal")
                a4 = 1.00;
            else if (comboBox6.SelectedItem == "High")
                a4 = 1.11;
            else if (comboBox6.SelectedItem == "Very High")
                a4 = 1.30;
            else if (comboBox6.SelectedItem == "Extre High")
                a4 = 1.66;

            if (comboBox2.SelectedItem == "Low")
                a2 = 0.94;
            else if (comboBox2.SelectedItem == "Nominal")
                a2 = 1.00;
            else if (comboBox2.SelectedItem == "High")
                a2 = 1.08;
            else if (comboBox2.SelectedItem == "Very High")
                a2 = 1.16;


            if (comboBox1.SelectedItem == "Very Low")
                a1 = 0.75;
            else if (comboBox1.SelectedItem == "Low")
                a1 = 0.88;
            else if (comboBox1.SelectedItem == "Nominal")
                a1 = 1.00;
            else if (comboBox1.SelectedItem == "High")
                a1 = 1.15;
            else if (comboBox1.SelectedItem == "Very High")
                a1 = 1.40;

            if (comboBox3.SelectedItem == "Very Low")
                a3 = 0.70;
            else if (comboBox3.SelectedItem == "Low")
                a3 = 0.85;
            else if (comboBox3.SelectedItem == "Nominal")
                a3 = 1.00;
            else if (comboBox3.SelectedItem == "High")
                a3 = 1.15;
            else if (comboBox3.SelectedItem == "Very High")
                a3 = 1.30;
            else if (comboBox3.SelectedItem == "Extre High")
                a3 = 1.65;


            if (comboBox13.SelectedItem == "Very Low")
                a13 = 1.24;
            else if (comboBox13.SelectedItem == "Low")
                a13 = 1.10;
            else if (comboBox13.SelectedItem == "Nominal")
                a13 = 1.00;
            else if (comboBox13.SelectedItem == "High")
                a13 = 0.91;
            else if (comboBox13.SelectedItem == "Very High")
                a13 = 0.82;


            if (comboBox4.SelectedItem == "Low")
                a6 = 0.87;
            else if (comboBox4.SelectedItem == "Nominal")
                a6 = 1.00;
            else if (comboBox4.SelectedItem == "High")
                a6 = 1.15;
            else if (comboBox4.SelectedItem == "Very High")
                a6 = 1.30;

            double EAF;
            EAF = a1 * a2 * a3 * a4 * a5 * a6 * a7 * a8 * a9 * a10 * a11 * a12 * a13 * a14 * a15;
            textBox3.Text = Convert.ToString(EAF);
            eaf = EAF;
        }

    }
}
