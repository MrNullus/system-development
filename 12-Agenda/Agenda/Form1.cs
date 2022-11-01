using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmAgenda : Form
    {
        List<Contato> contatos = new List<Contato>();
        AgendaApplication agendaApplication = new AgendaApplication();

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            Contato novoContato = new Contato();

            novoContato.Id = Guid.NewGuid();
            novoContato.Ativo = true;
            novoContato.Nome = txtNome.Text;
            novoContato.Celular = txtCelular.Text;
            novoContato.Fixo = txtFixo.Text;
            novoContato.Email = txtEmail.Text;
            novoContato.Endereco = txtEnder.Text;
            novoContato.Observacao = txtObs.Text;

            contatos = agendaApplication.CadastrarNovoContato(contatos, novoContato);

            ListViewItem item = new ListViewItem();
            item.Text = novoContato.GetDadosFormatados();
        }
    }
}
