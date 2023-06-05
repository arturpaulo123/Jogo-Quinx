using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Quinx
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox3.Visible = false;
            textBox4.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            Form6 for6 = new Form6();
            for6.Show();
            this.Hide();
            MessageBox.Show("Resposta Certa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("100 Pontos");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("100 Pontos");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("100 Pontos");
        }
    }
}
