using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР7_Михайлов
{
    public partial class Form1 : Form
    {
        public double x = 14.26, y = -1.22, z = 3.5 * Math.Pow(10, -2), t;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = (((2 * Math.Cos(x - Math.PI / 6)) / (0.5 + (Math.Sin(y) * Math.Sin(y))) * (1 + (z*z) / (3 - z*z / 5))));
            label1.Text = t.ToString();
        }
    }
}
