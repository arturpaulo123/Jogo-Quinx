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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            textBox4.Visible = false;
            textBox5.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            Form7 for7 = new Form7();
            for7.Show();
            this.Hide();
            MessageBox.Show("Resposta Certa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("150 Pontos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("150 Pontos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta errada");
            MessageBox.Show("150 Pontos");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
