using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_by_Kirbiflint2
{
    public partial class Kirbiflint_s_home : Form
    {
        public Kirbiflint_s_home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Calculator = new Form1();
            Calculator.Show();
        }

        private void Kirbiflint_s_home_Load(object sender, EventArgs e)
        {

        }
    }
}
