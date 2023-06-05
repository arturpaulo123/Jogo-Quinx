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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            textBox5.Visible = false;
            textBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            Form14 for14 = new Form14();
            for14.Show();
            this.Hide();
            MessageBox.Show("Resposta Certa");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            Form2 for2 = new Form2();
            for2.Show();
            this.Hide();
            MessageBox.Show("Resposta Errada");
            MessageBox.Show("450 pontos");

        }
    }
}
