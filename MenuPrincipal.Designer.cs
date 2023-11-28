namespace SagitarioRHDesktop
{
    partial class MenuPrincipal
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
            folhaDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            cadastroGerenteEmpresasToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroEmpresaToolStripMenuItem, funcionáriosToolStripMenuItem, folhaDePagamentoToolStripMenuItem, cadastroGerenteEmpresasToolStripMenuItem, encerrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
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
            funcionáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { admitirFuncionárioToolStripMenuItem });
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(87, 20);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // admitirFuncionárioToolStripMenuItem
            // 
            admitirFuncionárioToolStripMenuItem.Name = "admitirFuncionárioToolStripMenuItem";
            admitirFuncionárioToolStripMenuItem.Size = new Size(180, 22);
            admitirFuncionárioToolStripMenuItem.Text = "Admitir funcionário";
            admitirFuncionárioToolStripMenuItem.Click += admitirFuncionárioToolStripMenuItem_Click;
            // 
            // folhaDePagamentoToolStripMenuItem
            // 
            folhaDePagamentoToolStripMenuItem.Name = "folhaDePagamentoToolStripMenuItem";
            folhaDePagamentoToolStripMenuItem.Size = new Size(128, 20);
            folhaDePagamentoToolStripMenuItem.Text = "Folha de Pagamento";
            folhaDePagamentoToolStripMenuItem.Click += folhaDePagamentoToolStripMenuItem_Click;
            // 
            // cadastroGerenteEmpresasToolStripMenuItem
            // 
            cadastroGerenteEmpresasToolStripMenuItem.Name = "cadastroGerenteEmpresasToolStripMenuItem";
            cadastroGerenteEmpresasToolStripMenuItem.Size = new Size(163, 20);
            cadastroGerenteEmpresasToolStripMenuItem.Text = "Cadastro Gerente Empresas";
            cadastroGerenteEmpresasToolStripMenuItem.Click += cadastroGerenteEmpresasToolStripMenuItem_Click;
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(62, 20);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroEmpresaToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem admitirFuncionárioToolStripMenuItem;
        private ToolStripMenuItem folhaDePagamentoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem cadastroEmpresaToolStripMenuItem1;
        private ToolStripMenuItem selecionarEmpresaToolStripMenuItem;
        private ToolStripMenuItem cadastroGerenteEmpresasToolStripMenuItem;
    }
}