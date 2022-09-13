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
    }
}