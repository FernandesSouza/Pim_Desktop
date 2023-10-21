using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagitarioRHDesktop
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadastroEmrpesa = new CadastroEmpresa();

            cadastroEmrpesa.Show();
            this.Hide();

        }

        private void selecionarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarEmpresa pesquisarEmpresa = new PesquisarEmpresa();

            pesquisarEmpresa.Show();
            this.Hide();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolhaPagamentoForm folhaPagamento = new FolhaPagamentoForm();

            folhaPagamento.Show();
            this.Hide();
        }

        private void admitirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AdmitirFuncionario admitirFuncionario = new AdmitirFuncionario();

                admitirFuncionario.Show();
                this.Hide();
            
        }
    }
}
