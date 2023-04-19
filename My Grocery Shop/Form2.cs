using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Grocery_Shop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string GetString(int breakpoint, int breakpointa)
        {
            string a = comboBox1.Text.Substring(breakpoint, breakpointa);
            return a;
        }

       

        private void f2lb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
       
        public double a = 0;
       

        private void refresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Enabled = true;
                FileStream fs =
                    new FileStream("products.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    comboBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void f2bsel_Click_1(object sender, EventArgs e)
        {
            try
            {
                int b = 0;

                for (int i = 0; i < 4; i++)
                {

                    b = comboBox1.Text.IndexOf("?");
                    if (i == 0)
                    {
                        f2pn.Text = GetString(0, b);
                        comboBox1.Text = comboBox1.Text.Remove(0, b + 1);
                    }
                    else if (i == 1)
                    {
                        f2id.Text = GetString(0, b);
                        comboBox1.Text = comboBox1.Text.Remove(0, b + 1);
                    }
                    else if (i == 2)
                    {
                        f2p.Text = GetString(0, b);
                        comboBox1.Text = comboBox1.Text.Remove(0, b + 1);
                    }
                    else if (i == 3)
                    {
                        label9.Text = GetString(0, b);
                        comboBox1.Text = comboBox1.Text.Remove(0, b + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void f2bad_Click_1(object sender, EventArgs e)
        {
            try
            {
                f2lb2.Items.Add(f2pn.Text + "\t" + f2id.Text + "\t" + f2p.Text + "\t" + f2q.Text + " (" + label9.Text + ")");

                a += Convert.ToDouble(f2p.Text) * Convert.ToDouble(f2q.Text);
                label10.Text = Convert.ToString(a);
                f2pn.Text = f2id.Text = f2p.Text = f2q.Text = label9.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease enter an integer");
            }
        }

        private void f2bch_Click_1(object sender, EventArgs e)
        {
            f2lb2.Items.Clear();
            label10.Text = "";
            MessageBox.Show("You have been checked out!\nTHANK YOU FOR YOUR PURCHASE!");
        }

        private void receipt_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void f2bex_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
