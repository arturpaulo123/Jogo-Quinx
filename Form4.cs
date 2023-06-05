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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            Form5 for5 = new Form5();
            for5.Show();
            this.Hide();
            MessageBox.Show("Resposta Certa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta Errada");
            MessageBox.Show("50 pontos");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta Errada");
            MessageBox.Show("50 pontos");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta Errada");
            MessageBox.Show("50 pontos");
        }
    }
}
