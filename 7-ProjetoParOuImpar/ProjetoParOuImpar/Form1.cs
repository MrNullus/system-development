using System;
using System.Windows.Forms;

namespace ProjetoParOuImpar
{
    public partial class frmParOuImpar : Form
    {
        public frmParOuImpar()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtInicio.Text) && String.IsNullOrEmpty(txtFim.Text))
            {
                MessageBox.Show("Digite valores validos para inicio e fim");
            }
            else if (Int32.TryParse(txtInicio.Text, out int valorTxtInicio) && Int32.TryParse(txtFim.Text, out int valorTxtFim))
            {

                if (valorTxtInicio <= valorTxtFim)
                {

                    if (radioPar.Checked == true || radioImpar.Checked == true)
                    {

                        if (radioPar.Checked == true)
                        {
                            lblResultado.Text = "";
                            for (int i = valorTxtInicio; i <= valorTxtFim; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    lblResultado.Enabled = true;
                                    lblResultado.Text += " " + i + " ";
                                }
                            }
                        }
                        else
                        {
                            lblResultado.Text = "";
                            for (int i = valorTxtInicio; i <= valorTxtFim; i++)
                            {
                                if (i % 2 == 1)
                                {
                                    lblResultado.Enabled = true;
                                    lblResultado.Text += " " + i + " ";
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Selecione par ou impar");
                    }

                }
                else
                {
                    MessageBox.Show("O valor de inicio deve ser menor ou igual ao fim");
                }

            }
            else
            {
                MessageBox.Show("Digite apenas números inteiros");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Enabled = true;
            lblResultado.Text = "";

            txtInicio.Text = "";
            txtFim.Text = "";

            radioPar.Checked = false;
            radioImpar.Checked = false;
        }
    }
}
