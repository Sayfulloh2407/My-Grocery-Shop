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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void f3b1_Click_1(object sender, EventArgs e)
        {
            try
            {
                AddProducts p = new AddProducts();
                p.productname = f3tbpn.Text;
                p.id = f3tb2.Text;
                p.price = Convert.ToInt32(f3tb3.Text);
                p.unit = comboBox1.SelectedItem.ToString();

                FileStream fs =
                 new FileStream("products.txt", FileMode.Append, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(p.Combine());

                sw.Close();
                fs.Close();
                f3tbpn.Text = f3tb2.Text = f3tb3.Text = "";
                comboBox1.SelectedIndex = -1;
                if (checkBox1.Checked)
                {
                    checkBox1.Checked = false;
                }
                MessageBox.Show("A product named " + p.productname + " has been Added\n to the List of products!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void f3b2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                f3tb2.Enabled = false;
                f3tb2.Text = Randomc.RandomLetter1(1) + Randomc.RandomNumber(4) + Randomc.RandomLetter1(1);
            }
            else
            {
                f3tb2.Enabled = true;
                f3tb2.Text = "";
            }
        }
    }
}
