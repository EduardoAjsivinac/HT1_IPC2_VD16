using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT1_IPC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                int r1 = a + (b * c);
                int r2 = a * b + c;
                Label4.Text= a+"+"+b + "*" + c+"= "+r1;
                Label5.Text = a + "*" + b + "+" + c+"= "+r2;
                Label6.Text= "MCM: "+ mcd(r1,r2).ToString();
                 
            }
            catch (Exception ex) {
                MessageBox.Show("Datos enteros para int" + ex);
            }
            


        }
        public static int mcd(int num1, int num2)
        {
            int mcd = 0;
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);
            do
            {
                mcd = b;
                b = a % b;
                a = mcd;
            } while (b != 0);
            return mcd;
        }
    }
}
