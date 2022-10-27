using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz10Perguntas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // # dados iniciais #
            int hits = 0;
            string mensagem = string.Empty;

            // # verificar se foram marcadas as alternativas corretas #
            if (rdbQ1Answer3.Checked)
            {
                hits++;
            }
            if (rdbQ2Answer2.Checked)
            {
                hits++;
            }
            if (rdbQ3Answer4.Checked)
            {
                hits++;
            }
            if (rdbQ4Answer4.Checked)
            {
                hits++;
            }
            if (rdbQ5Answer5.Checked)
            {
                hits++;   
            }
            if (rdbQ6Answer1.Checked)
            {
                hits++;
            }
            if (rdbQ7Answer1.Checked)
            {
                hits++;
            }
            if (rdbQ8Answer3.Checked)
            {
                hits++;
            }
            if (rdbQ9Answer4.Checked)
            {
                hits++;
            }
            if (rdbQ10Answer3.Checked)
            {
                hits++;
            }

            // # setar mensagem #
            mensagem = "Você teve " + hits + " acerto (s)";

            // # Exibir MessageBox com o total de acertos
            string caption = "Seus Acertos";
            MessageBox.Show(
                mensagem, // mensagem a ser exibida
                caption, // titulo da caixa de mensagem
                MessageBoxButtons.OK, // define quais seram os botões que irão aparecer
                MessageBoxIcon.Asterisk // configurar icone do button de mensagem 
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ1Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ1Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ1Answer4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ1Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ1Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ2Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbQ2Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ2Answer4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ2Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ2Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ3Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdbQ3Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ3Answer4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ3Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ3Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ4Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdbQ4Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ4Answer4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ4Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ4Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ5Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rdbQ5Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ5Answer4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ5Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ5Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ6Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rdbQ6Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ6Answer4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ6Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ6Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ7Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rdbQ7Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ7Answer4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ7Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ7Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ8Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rdbQ8Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ8Answer4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ8Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ8Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ9Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rdbQ9Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ9Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ9Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbQ10Answer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void rdbQ10Answer5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ10Answer4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ10Answer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbQ10Answer2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}