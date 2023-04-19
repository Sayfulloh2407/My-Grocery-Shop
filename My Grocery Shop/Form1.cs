using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Grocery_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 addproduct = new Form3();
            addproduct.ShowDialog();
        }

        private void f1shp_Click(object sender, EventArgs e)
        {
            Form2 shoppingpage = new Form2();
            shoppingpage.ShowDialog();
        }
    }
}
