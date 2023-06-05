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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            textBox5.Visible = false;
            textBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta Errada");
            MessageBox.Show("400 pontos");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox5.Visible = true;
            Form13 for13 = new Form13();
            for13.Show();
            this.Hide();
            MessageBox.Show("Resposta Certa");
        }
    }
}
