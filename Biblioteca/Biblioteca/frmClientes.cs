using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmClientes : Form
    {
        // Cria uma instância do formulário de cadastro
        frmCadastrarClientes objfrmCadastrarClientes = new frmCadastrarClientes();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void DesabilitaBotoes(object sender, EventArgs e)
        {
            btnAlterarExcluir.Enabled = false;
            btnCadastrar.Enabled      = false;
            btnConsultar.Enabled      = false;
            btnSair.Enabled           = false;
            btnVoltar.Enabled         = false;
        }

        private void HabilitaBotoes(object sender, EventArgs e)
        {
            btnAlterarExcluir.Enabled = true;
            btnCadastrar.Enabled      = true;
            btnConsultar.Enabled      = true;
            btnSair.Enabled           = true;
            btnVoltar.Enabled         = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(objfrmCadastrarClientes.IsDisposed)
            {
                objfrmCadastrarClientes = new frmCadastrarClientes();
            }

            objfrmCadastrarClientes.MdiParent = this;

            this.DesabilitaBotoes(sender, e);

            objfrmCadastrarClientes.btnCancelar.Click += new EventHandler(this.HabilitaBotoes);

            if(objfrmCadastrarClientes.Visible == false)
            {
                objfrmCadastrarClientes.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
