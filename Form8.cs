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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            textBox7.Visible = false;
            textBox8.Visible = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("250 Pontos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("250 Pontos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("250 Pontos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Visible = true;
            Form9 for9 = new Form9();
            for9.Show();
            this.Hide();
            MessageBox.Show("Resposta Certa");
        }
    }
}
