using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hasilbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(textBox1.Text);
            var b = Convert.ToInt32(textBox2.Text);

            listBox1.Items.Clear();

           if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(string.Format("hasil tambah: {2}", a, b, Penambahan(a, b)));
            }

            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(string.Format("hasil kurang: {2}", a, b, Pengurangan(a, b)));
            }

            if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(string.Format("hasil kali: {2}", a, b, Perkalian(a, b)));
            }

            if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(string.Format("hasil bagi: {2}", a, b, Pembagian(a, b)));
            }

            // kode bawah ini jika tanpa combobox
            //  listBox1.Items.Clear(); //kosongkan listbox




            /*listBox1.Items.Add(string.Format("hasil penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b)));
            listBox1.Items.Add(string.Format("hasil pengurangan: {0} - {1} = {2}", a, b, Pengurangan (a, b)));
            listBox1.Items.Add(string.Format("hasil perkalian: {0} x {1} = {2}", a, b, Perkalian(a, b)));
            listBox1.Items.Add(string.Format("hasil pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b))); */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
