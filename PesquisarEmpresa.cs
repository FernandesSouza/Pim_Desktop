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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SagitarioRHDesktop
{
    public partial class PesquisarEmpresa : Form
    {

        DataTable dt = new DataTable();
        public PesquisarEmpresa()
        {
            InitializeComponent();
            CarregarDados();
        }
        private void CarregarDados()
        {
            dt.Columns.Add("idEmpresa", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));
            dt.Columns.Add("razaoSocial", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Senha", typeof(string));
            dt.Columns.Add("Usuario", typeof(string));
            dt.Columns.Add("nmFantasia", typeof(string));
            dt.Columns.Add("titularEmp", typeof(string));
            dt.Columns.Add("CNPJ", typeof(string));

            dataGridView1.DataSource = dt;

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BancoContext>();
            optionsBuilder.UseNpgsql("Host=berry.db.elephantsql.com ;Database=cclcbiwm;Username=cclcbiwm;Password=EP_X_koFmXeUspco84FYTUILWgPptiJ_;");


            EmpresaModel empresaModel = new EmpresaModel();

            empresaModel.cnpj = txt_filtro.Text;

            using (var context = new BancoContext(optionsBuilder.Options))
            {

                var query = context.empresas.Where(e => e.cnpj!.Contains(empresaModel.cnpj));


                if (query.Any())
                {
                    var results = query.ToList();
                    dataGridView1.DataSource = results;
                }
                else
                {
                    MessageBox.Show("CNPJ não encontrado");


                }
            }

        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
