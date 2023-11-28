
using iText.Kernel.Pdf;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SagitarioRH.Models;
using SagitarioRHDesktop.Data;
using SagitarioRHDesktop.Infraestrutura.Services;
using SagitarioRHDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Layout.Borders;

namespace SagitarioRHDesktop
{
    public partial class FolhaPagamentoForm : Form
    {
        DataTable dt = new DataTable();
        public FolhaPagamentoForm()
        {
            InitializeComponent();
            CarregarDados();

        }

        private void CarregarDados()
        {

            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Valor", typeof(string));
            dt.Columns.Add("DataPgto", typeof(string));
            dt.Columns.Add(" CodEvento", typeof(string));


            dataGridView1.DataSource = dt;

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

        private void btn_FolhaPGTO_Click(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BancoContext>();
            optionsBuilder.UseNpgsql("Host=berry.db.elephantsql.com;Database=cclcbiwm;Username=cclcbiwm;Password=EP_X_koFmXeUspco84FYTUILWgPptiJ_;");


            FolhaPgtoModel folhaPgtoModel = new FolhaPgtoModel();

            string textoData = txt_datapgto.Text;


            if (DateTime.TryParseExact(textoData, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataPgto) || !string.IsNullOrEmpty(txt_matricula.Text))
            {


                if (DateTime.TryParseExact(textoData, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataPgto))
                {
                    folhaPgtoModel.datapgto = DateTime.SpecifyKind(dataPgto, DateTimeKind.Utc);
                }

                // Se a matrícula for um número válido
                if (int.TryParse(txt_matricula.Text, out int matricula))
                {
                    folhaPgtoModel.matfuncionario = matricula;
                }

                using (var context = new BancoContext(optionsBuilder.Options))
                {
                    var query = context.folhaPgto.Where(e => e.datapgto == folhaPgtoModel.datapgto && e.matfuncionario == folhaPgtoModel.matfuncionario);

                    if (query.Any())
                    {
                        var results = query.ToList();
                        dataGridView1.DataSource = results;
                    }
                    else
                    {
                        MessageBox.Show("PREENCHA TODOS OS CAMPOS");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data válida ou uma matrícula.");
            }
        }

        private void btn_gerarpdf_Click(object sender, EventArgs e)
        {


            var optionsBuilder = new DbContextOptionsBuilder<BancoContext>();
            optionsBuilder.UseNpgsql("Host=berry.db.elephantsql.com;Database=cclcbiwm;Username=cclcbiwm;Password=EP_X_koFmXeUspco84FYTUILWgPptiJ_;");


            FolhaPgtoModel folhaPgtoModel = new FolhaPgtoModel();


            string textoData = txt_datapgto.Text;


            if (DateTime.TryParseExact(textoData, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataPgto) || !string.IsNullOrEmpty(txt_matricula.Text))
            {


                if (DateTime.TryParseExact(textoData, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataPgto))
                {
                    folhaPgtoModel.datapgto = DateTime.SpecifyKind(dataPgto, DateTimeKind.Utc);
                }

                // Se a matrícula for um número válido
                if (int.TryParse(txt_matricula.Text, out int matricula))
                {
                    folhaPgtoModel.matfuncionario = matricula;
                }

                using (var context = new BancoContext(optionsBuilder.Options))
                {
                    var query = context.folhaPgto.Where(e => e.datapgto == folhaPgtoModel.datapgto && e.matfuncionario == folhaPgtoModel.matfuncionario);

                    if (query.Any())
                    {
                        var results = query.ToList();

                        var folhaPgto = query.First();

                        folhaPgtoModel.matfuncionario = folhaPgto.matfuncionario;
                        folhaPgtoModel.idempresa = folhaPgto.idempresa;
                        folhaPgtoModel.valor = folhaPgto.valor;

                        string caminhoDiretorio = @"C:\Users\Igor\Desktop\PIM_IV\SagitarioRHDesktop\Storage\";

                        if (!Directory.Exists(caminhoDiretorio))
                        {
                            Directory.CreateDirectory(caminhoDiretorio);
                        }

                        string caminho = System.IO.Path.Combine(caminhoDiretorio, "output.pdf");
                        PdfWriter writer = new PdfWriter(caminho);
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf, PageSize.A4);


                        Paragraph titulo = new Paragraph("Recebimento de pagamento de salário");
                        titulo.SetFontSize(20);
                        titulo.SetMarginBottom(10);
                        titulo.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                        Paragraph informacoesFolhaPgto = new Paragraph($"Nome Funcionário: {folhaPgto.nome}\n " +
                                                        $"Matrícula do Funcionário: {folhaPgtoModel.matfuncionario}\n");




                        informacoesFolhaPgto.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

                        DateTime dataPagamento = Convert.ToDateTime(folhaPgtoModel.datapgto);
                        string dataFormatada = dataPagamento.ToString("yyyy-MM-dd");

                        Paragraph datapag = new Paragraph($"Referente ao Mês/Ano \n {dataFormatada}");
                        datapag.SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);

                        Table table = new Table(3);



                        table.AddCell(new Cell().Add(new Paragraph("Tipo de desconto\n\n\n\n\n\n\n")));
                        table.AddCell(new Cell().Add(new Paragraph("Cargo\n\n\n\n\n\n\n")));
                        table.AddCell(new Cell().Add(new Paragraph("Salario\n\n\n\n\n\n\n")));

                        table.AddCell(new Cell().Add(new Paragraph("INSS")));

                        table.AddCell(new Cell().Add(new Paragraph($"{folhaPgto.funcao}")));
                        table.AddCell(new Cell().Add(new Paragraph($"{folhaPgto.valor}")));

                        table.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);




                        document.Add(titulo);
                        document.Add(datapag);
                        document.Add(informacoesFolhaPgto);
                        document.Add(table);

                        document.Close();





                    }
                    else
                    {
                        MessageBox.Show("PREENCHA TODOS OS CAMPOS");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data válida ou uma matrícula.");
            }



        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGerenteEmpresasForm gerente = new CadastroGerenteEmpresasForm();
            gerente.Show();
            this.Hide();

        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolhaPagamentoForm folha = new FolhaPagamentoForm();
            folha.Show();
            this.Hide();
        }

        private void admitirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmitirFuncionario add = new AdmitirFuncionario();
            add.Show();
            this.Hide();
        }
    }
}
