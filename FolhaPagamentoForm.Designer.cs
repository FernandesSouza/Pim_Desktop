namespace SagitarioRHDesktop
{
    partial class FolhaPagamentoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroEmpresaToolStripMenuItem = new ToolStripMenuItem();
            cadastroEmpresaToolStripMenuItem1 = new ToolStripMenuItem();
            selecionarEmpresaToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            admitirFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            alterarFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            excluirFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            folhaDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btn_gerarpdf = new Button();
            txt_datapgto = new TextBox();
            label1 = new Label();
            btn_FolhaPGTO = new Button();
            dataGridView1 = new DataGridView();
            txt_matricula = new TextBox();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroEmpresaToolStripMenuItem, funcionáriosToolStripMenuItem, folhaDePagamentoToolStripMenuItem, cadastroDeUsuáriosToolStripMenuItem, encerrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(861, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "FunPrincipal";
            // 
            // cadastroEmpresaToolStripMenuItem
            // 
            cadastroEmpresaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroEmpresaToolStripMenuItem1, selecionarEmpresaToolStripMenuItem });
            cadastroEmpresaToolStripMenuItem.Name = "cadastroEmpresaToolStripMenuItem";
            cadastroEmpresaToolStripMenuItem.Size = new Size(67, 20);
            cadastroEmpresaToolStripMenuItem.Text = " Empresa";
            // 
            // cadastroEmpresaToolStripMenuItem1
            // 
            cadastroEmpresaToolStripMenuItem1.Name = "cadastroEmpresaToolStripMenuItem1";
            cadastroEmpresaToolStripMenuItem1.Size = new Size(176, 22);
            cadastroEmpresaToolStripMenuItem1.Text = "Cadastro Empresa";
            cadastroEmpresaToolStripMenuItem1.Click += cadastroEmpresaToolStripMenuItem1_Click;
            // 
            // selecionarEmpresaToolStripMenuItem
            // 
            selecionarEmpresaToolStripMenuItem.Name = "selecionarEmpresaToolStripMenuItem";
            selecionarEmpresaToolStripMenuItem.Size = new Size(176, 22);
            selecionarEmpresaToolStripMenuItem.Text = "Selecionar Empresa";
            selecionarEmpresaToolStripMenuItem.Click += selecionarEmpresaToolStripMenuItem_Click;
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { admitirFuncionárioToolStripMenuItem, alterarFuncionárioToolStripMenuItem, excluirFuncionárioToolStripMenuItem });
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(87, 20);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // admitirFuncionárioToolStripMenuItem
            // 
            admitirFuncionárioToolStripMenuItem.Name = "admitirFuncionárioToolStripMenuItem";
            admitirFuncionárioToolStripMenuItem.Size = new Size(178, 22);
            admitirFuncionárioToolStripMenuItem.Text = "Admitir funcionário";
            // 
            // alterarFuncionárioToolStripMenuItem
            // 
            alterarFuncionárioToolStripMenuItem.Name = "alterarFuncionárioToolStripMenuItem";
            alterarFuncionárioToolStripMenuItem.Size = new Size(178, 22);
            alterarFuncionárioToolStripMenuItem.Text = "Editar funcionário";
            // 
            // excluirFuncionárioToolStripMenuItem
            // 
            excluirFuncionárioToolStripMenuItem.Name = "excluirFuncionárioToolStripMenuItem";
            excluirFuncionárioToolStripMenuItem.Size = new Size(178, 22);
            excluirFuncionárioToolStripMenuItem.Text = "Excluir funcionário";
            // 
            // folhaDePagamentoToolStripMenuItem
            // 
            folhaDePagamentoToolStripMenuItem.Name = "folhaDePagamentoToolStripMenuItem";
            folhaDePagamentoToolStripMenuItem.Size = new Size(128, 20);
            folhaDePagamentoToolStripMenuItem.Text = "Folha de Pagamento";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            cadastroDeUsuáriosToolStripMenuItem.Size = new Size(130, 20);
            cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de Usuários";
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(62, 20);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_gerarpdf);
            groupBox1.Controls.Add(txt_datapgto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_FolhaPGTO);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txt_matricula);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(39, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 510);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btn_gerarpdf
            // 
            btn_gerarpdf.Location = new Point(695, 79);
            btn_gerarpdf.Name = "btn_gerarpdf";
            btn_gerarpdf.Size = new Size(92, 23);
            btn_gerarpdf.TabIndex = 12;
            btn_gerarpdf.Text = "Gerar PDF";
            btn_gerarpdf.UseVisualStyleBackColor = true;
            btn_gerarpdf.Click += btn_gerarpdf_Click;
            // 
            // txt_datapgto
            // 
            txt_datapgto.Location = new Point(331, 79);
            txt_datapgto.Name = "txt_datapgto";
            txt_datapgto.Size = new Size(132, 23);
            txt_datapgto.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 82);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 10;
            label1.Text = "Data de pagamento:";
            // 
            // btn_FolhaPGTO
            // 
            btn_FolhaPGTO.Location = new Point(484, 79);
            btn_FolhaPGTO.Name = "btn_FolhaPGTO";
            btn_FolhaPGTO.Size = new Size(192, 23);
            btn_FolhaPGTO.TabIndex = 9;
            btn_FolhaPGTO.Text = "Pesquisar folha de pagamento";
            btn_FolhaPGTO.UseVisualStyleBackColor = true;
            btn_FolhaPGTO.Click += btn_FolhaPGTO_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(772, 263);
            dataGridView1.TabIndex = 9;
            // 
            // txt_matricula
            // 
            txt_matricula.Location = new Point(75, 79);
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(132, 23);
            txt_matricula.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 82);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Matricula:";
            // 
            // FolhaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 561);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "FolhaPagamentoForm";
            Text = "FolhaPagamentoForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroEmpresaToolStripMenuItem;
        private ToolStripMenuItem cadastroEmpresaToolStripMenuItem1;
        private ToolStripMenuItem selecionarEmpresaToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem admitirFuncionárioToolStripMenuItem;
        private ToolStripMenuItem alterarFuncionárioToolStripMenuItem;
        private ToolStripMenuItem excluirFuncionárioToolStripMenuItem;
        private ToolStripMenuItem folhaDePagamentoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txt_matricula;
        private Label label4;
        private Button btn_FolhaPGTO;
        private TextBox txt_datapgto;
        private Label label1;
        private Button btn_gerarpdf;
    }
}