using Microsoft.EntityFrameworkCore;
using SagitarioRHDesktop.Data;
using SagitarioRHDesktop.Models;
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
    public partial class CadastroGerenteEmpresasForm : Form
    {
        public CadastroGerenteEmpresasForm()
        {
            InitializeComponent();
        }

        private void cadastroEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroEmpresa empresa = new CadastroEmpresa();
            empresa.Show();
            this.Hide();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void alterarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void btn_cadastro_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BancoContext>();
            optionsBuilder.UseNpgsql("Host=berry.db.elephantsql.com ;Database=cclcbiwm;Username=cclcbiwm;Password=EP_X_koFmXeUspco84FYTUILWgPptiJ_;");

            GerenteModel gerente = new GerenteModel();

            gerente.nome = txt_nome.Text;
            gerente.sobrenome = txt_sobrenome.Text;
            gerente.usuario = txt_usuario.Text;
            gerente.senha = txt_senha.Text;
            gerente.idempresa = int.Parse(txt_empresa.Text);

            using (var context = new BancoContext(optionsBuilder.Options))
            {

                if (gerente == null)
                {

                    MessageBox.Show("ALGO DEU ERRADO");

                }
                else
                {
                    await context.gerente.AddAsync(gerente);
                    await context.SaveChangesAsync();


                }
            }
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selecionarEmpresaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PesquisarEmpresa emp = new PesquisarEmpresa();
            emp.Show();
            this.Hide();
        }

        private void folhaDePagamentoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FolhaPagamentoForm folha = new FolhaPagamentoForm();
            folha.Show();
            this.Hide();
        }

        private void encerrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
