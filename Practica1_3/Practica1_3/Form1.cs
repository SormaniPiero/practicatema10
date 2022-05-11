using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_3
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Aaron");
            int n1 = int.Parse(tnombre.Text);
            int n2 = int.Parse(textBox1.Text);
            int tot = n1 + n2;
            tTelf.Text = tot.ToString();
        }
    }
}
