namespace SagitarioRHDesktop
{
    partial class EditarFuncionario
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
            Button btn_ExcluirFunc;
            Button btn_AltFunc;
            Button btn_PesquisaFuncAlt;
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
            dataGridView1 = new DataGridView();
            txt_filtro = new TextBox();
            btn_ExcluirFunc = new Button();
            btn_AltFunc = new Button();
            btn_PesquisaFuncAlt = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroEmpresaToolStripMenuItem, funcionáriosToolStripMenuItem, folhaDePagamentoToolStripMenuItem, cadastroDeUsuáriosToolStripMenuItem, encerrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(873, 24);
            menuStrip1.TabIndex = 2;
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
            // 
            // selecionarEmpresaToolStripMenuItem
            // 
            selecionarEmpresaToolStripMenuItem.Name = "selecionarEmpresaToolStripMenuItem";
            selecionarEmpresaToolStripMenuItem.Size = new Size(176, 22);
            selecionarEmpresaToolStripMenuItem.Text = "Selecionar Empresa";
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
            // 
            // btn_ExcluirFunc
            // 
            btn_ExcluirFunc.Location = new Point(672, 37);
            btn_ExcluirFunc.Name = "btn_ExcluirFunc";
            btn_ExcluirFunc.Size = new Size(183, 23);
            btn_ExcluirFunc.TabIndex = 21;
            btn_ExcluirFunc.Text = "Excluir Funcionário";
            btn_ExcluirFunc.UseVisualStyleBackColor = true;
            // 
            // btn_AltFunc
            // 
            btn_AltFunc.Location = new Point(483, 38);
            btn_AltFunc.Name = "btn_AltFunc";
            btn_AltFunc.Size = new Size(183, 23);
            btn_AltFunc.TabIndex = 20;
            btn_AltFunc.Text = "Alterar dados do Funcionário";
            btn_AltFunc.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(839, 347);
            dataGridView1.TabIndex = 19;
            // 
            // txt_filtro
            // 
            txt_filtro.Location = new Point(16, 38);
            txt_filtro.Name = "txt_filtro";
            txt_filtro.Size = new Size(272, 23);
            txt_filtro.TabIndex = 18;
            // 
            // btn_PesquisaFuncAlt
            // 
            btn_PesquisaFuncAlt.Location = new Point(294, 38);
            btn_PesquisaFuncAlt.Name = "btn_PesquisaFuncAlt";
            btn_PesquisaFuncAlt.Size = new Size(183, 23);
            btn_PesquisaFuncAlt.TabIndex = 17;
            btn_PesquisaFuncAlt.Text = "Pesquisar Funcionário";
            btn_PesquisaFuncAlt.UseVisualStyleBackColor = true;
            // 
            // EditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 434);
            Controls.Add(btn_ExcluirFunc);
            Controls.Add(btn_AltFunc);
            Controls.Add(dataGridView1);
            Controls.Add(txt_filtro);
            Controls.Add(btn_PesquisaFuncAlt);
            Controls.Add(menuStrip1);
            Name = "EditarFuncionario";
            Text = "EditarFuncionario";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private DataGridView dataGridView1;
        private TextBox txt_filtro;
    }
}