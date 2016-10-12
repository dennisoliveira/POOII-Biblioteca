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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes objClientes = new frmClientes();
            objClientes.ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios objFuncionarios = new frmFuncionarios();
            objFuncionarios.ShowDialog();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            frmLivros objLivros = new frmLivros();
            objLivros.ShowDialog();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja sair?", 
                "Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
