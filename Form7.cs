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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            textBox6.Visible = false;
            textBox5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            Form8 for8 = new Form8();
            for8.Show();
            this.Hide();
            MessageBox.Show("Resposta Certa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("200 Pontos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("200 Pontos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("200 Pontos");
        }
    }
}
