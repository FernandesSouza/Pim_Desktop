using Microsoft.EntityFrameworkCore;
using SagitarioRH.Models;
using SagitarioRHDesktop.Data;
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
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btn_cadastroEmpresa_Click(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<BancoContext>();
            optionsBuilder.UseNpgsql("Host=berry.db.elephantsql.com ;Database=cclcbiwm;Username=cclcbiwm;Password=EP_X_koFmXeUspco84FYTUILWgPptiJ_;");


            EmpresaModel empresaModel = new EmpresaModel();

            empresaModel.cnpj = txt_cnpj.Text;
            empresaModel.usuario = txtUsuario.Text;
            empresaModel.senha = txtSenha.Text;
            empresaModel.titularemp = txt_titularEmpresa.Text;
            empresaModel.razaosocial = txt_razaoSocial.Text;
            empresaModel.email = txt_email.Text;
            empresaModel.nmfantasia = txt_fantasia.Text;
            empresaModel.telefone = txt_telefone.Text;

            using (var context = new BancoContext(optionsBuilder.Options))
            {


                if (empresaModel != null)
                {

                    var empresa = context.empresas.AddAsync(empresaModel);
                    await context.SaveChangesAsync();

                    MessageBox.Show("Cadastro efetuado com sucesso");


                }
                else
                {
                    MessageBox.Show("Alguma informação foi digitada incorretamente");

                }



            }



        }

        private void cadastroEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancia menu principal
            MenuPrincipal menuPrincipal = new MenuPrincipal();

            // usa a instancia do MenuPrincipal para abrir a tela de MenuPrincipal
            menuPrincipal.Show();
            // esconde a tela
            this.Hide();
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGerenteEmpresasForm gerente = new CadastroGerenteEmpresasForm();
            gerente.Show();
            this.Hide();
        }

        private void cadastroEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroEmpresa empresa = new CadastroEmpresa();
            empresa.Show();
            this.Hide();

        }

        private void selecionarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarEmpresa pesquisarEmpresa = new PesquisarEmpresa();

            pesquisarEmpresa.Show();
            this.Hide();
        }

        private void admitirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AdmitirFuncionario admitirFuncionario = new AdmitirFuncionario();

            admitirFuncionario.Show();
            this.Hide();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolhaPagamentoForm folhaPagamento = new FolhaPagamentoForm();

            folhaPagamento.Show();
            this.Hide();
        }
    }
}
