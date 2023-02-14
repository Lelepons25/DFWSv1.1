using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFWSv1._1
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void FruitsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fruits fruits = new Fruits();
            fruits.Show();
        }
    }
}
