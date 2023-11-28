using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.ExpressionTranslators.Internal;
using SagitarioRH.Models;
using SagitarioRHDesktop.Data;
using SagitarioRHDesktop.Infraestrutura.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SagitarioRHDesktop
{
    public partial class AdmitirFuncionario : Form
    {
        public AdmitirFuncionario()
        {
            InitializeComponent();

        }

        private async void btn_ProxCadFunc_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BancoContext>();
            optionsBuilder.UseNpgsql("Host=berry.db.elephantsql.com ;Database=cclcbiwm;Username=cclcbiwm;Password=EP_X_koFmXeUspco84FYTUILWgPptiJ_;");

            FuncionarioModel funcionarioModel = new FuncionarioModel();

            //Informações pessoais
            funcionarioModel.nome = txt_NmCompletoFunc.Text;
            funcionarioModel.rg = txt_RgFunc.Text;
            funcionarioModel.cpf = txt_cpfFunc.Text;
            funcionarioModel.pis = txt_pisFunc.Text;
            funcionarioModel.cep = txt_cepFunc.Text;

            //Validações de Dados
            if (txt_RgFunc.Text.Length < 12)
            {
                MessageBox.Show("O RG deve conter 12 digitos!");
                txt_RgFunc.Focus();
                return;
            }


            if (txt_cpfFunc.Text.Length < 11)
            {
                MessageBox.Show("O CPF deve conter 11 digitos!");
                txt_cpfFunc.Focus();
                return;
            }

            if (txt_pisFunc.Text.Length < 11)
            {
                MessageBox.Show("O PIS deve conter 11 digitos!");
                txt_pisFunc.Focus();
                return;
            }

            if (txt_cepFunc.Text.Length < 8)
            {
                MessageBox.Show("O CEP deve conter 8 digitos!");
                txt_cepFunc.Focus();
                return;
            }


            //Informações de contato
            funcionarioModel.email = txt_emailFunc.Text;
            funcionarioModel.telefone = txt_telFunc.Text;

            //Informações de Cargo
            funcionarioModel.dtadmissao = DateTime.Parse(txt_dtAdmFunc.Text);
            funcionarioModel.setor = txt_setorFunc.Text;
            funcionarioModel.funcao = txt_funcaoFunc.Text;
            funcionarioModel.jornada = int.Parse(txt_jornadaFunc.Text);
            funcionarioModel.idempresa = int.Parse(txt_IdEmpresa.Text);

            //Informacoes de Remuneracao
            funcionarioModel.salario = decimal.Parse(txt_salarioFunc.Text);

            //Cheque Insalubridade
            if (rb_InsalFuncSim.Checked)
            {

                if (rb_InsalFunc10.Checked)
                {
                    funcionarioModel.adcinsalubridade = (decimal)0.10;

                }
                else if (rb_InsalFunc20.Checked)
                {
                    funcionarioModel.adcinsalubridade = (decimal)0.20;

                }
                else
                {
                    funcionarioModel.adcinsalubridade = (decimal)0.30;
                }

            }
            else
            {
                funcionarioModel.adcinsalubridade = 0;

            }


            //Cheque Periculosidade
            if (rb_PericFuncSim.Checked)
            {
                funcionarioModel.adcpericulosidade = (decimal)0.30;



            }
            else
            {
                funcionarioModel.adcpericulosidade = 0;

            }


            //Cheque Vale Transporte
            if (rb_vtFuncSim.Checked)
            {
                funcionarioModel.valetransp = (decimal)0.06;

            }
            else
            {
                funcionarioModel.valetransp = 0;

            }

            funcionarioModel.dependentes = int.Parse(txt_funcDepent.Text);


            //Informações de Desconto

            //Vale Refeicao
            var vlInputRefeicao = decimal.Parse(txt_funcValeRef.Text) / 100;

            if (rb_vrFuncSim.Checked)
            {

                funcionarioModel.valerefeicao = vlInputRefeicao;

            }
            else
            {
                funcionarioModel.valerefeicao = 0;

            }

            //Plano de Saude

            var vlInputPlSaude = decimal.Parse(txt_PlSaude.Text) / 100;

            if (rb_PlanSFuncSim.Checked)
            {
                funcionarioModel.plsaude = vlInputPlSaude;


            }
            else
            {
                funcionarioModel.plsaude = 0;

            }

            //Usuario e Senha do Funcionario

            funcionarioModel.senha = txt_FuncSenha.Text;
            funcionarioModel.usuario = txt_FuncUsuario.Text;

            //Efetuando cadastro do funcionário
            using (var context = new BancoContext(optionsBuilder.Options))
            {

                if (funcionarioModel != null)
                {

                    var funcionario = await context.funcionarios.AddAsync(funcionarioModel);
                    await context.SaveChangesAsync();

                    CalculoINSS calculo = new CalculoINSS();
                    calculo.CalculoInSS(funcionarioModel);

                    await context.SaveChangesAsync();



                    MessageBox.Show("Cadastro efetuado com sucesso");


                }
                else
                {
                    MessageBox.Show("Digite todas as informações necessárias");

                }


            }



        }

        private void btn_LimparInfoFunc_Click(object sender, EventArgs e)
        {
            txt_NmCompletoFunc.Clear();
            txt_RgFunc.Clear();
            txt_FuncSenha.Clear();
            txt_FuncUsuario.Clear();
            txt_PlSaude.Clear();
            txt_cepFunc.Clear();
            txt_cpfFunc.Clear();
            txt_dtAdmFunc.Clear();
            txt_emailFunc.Clear();
            txt_telFunc.Clear();
            txt_setorFunc.Clear();
            txt_funcaoFunc.Clear();
            txt_funcDepent.Clear();
            txt_pisFunc.Clear();
            txt_funcValeRef.Clear();
            txt_PlSaude.Clear();
            txt_IdEmpresa.Clear();
            txt_salarioFunc.Clear();
            txt_jornadaFunc.Clear();

        }

        private void admitirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmitirFuncionario admitirFuncionario = new AdmitirFuncionario();

            admitirFuncionario.Show();
            this.Hide();
        }

        private void cadastroEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroGerenteEmpresasForm gerente = new CadastroGerenteEmpresasForm();

            gerente.Show();
            this.Hide();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scrollbar_Scroll(object sender, ScrollEventArgs e)
        {



        }

        private void AdmitirFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGerenteEmpresasForm gerente = new CadastroGerenteEmpresasForm();
            gerente.Show();
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
    }
}
