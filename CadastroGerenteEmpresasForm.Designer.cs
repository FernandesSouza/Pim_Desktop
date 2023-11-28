namespace SagitarioRHDesktop
{
    partial class CadastroGerenteEmpresasForm
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
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btn_cadastro = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_empresa = new TextBox();
            txt_nome = new TextBox();
            txt_senha = new TextBox();
            txt_usuario = new TextBox();
            txt_sobrenome = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroEmpresaToolStripMenuItem, funcionáriosToolStripMenuItem, folhaDePagamentoToolStripMenuItem, encerrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "FunPrincipal";
            // 
            // cadastroEmpresaToolStripMenuItem
            // 
            cadastroEmpresaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroEmpresaToolStripMenuItem1, selecionarEmpresaToolStripMenuItem });
            cadastroEmpresaToolStripMenuItem.Name = "cadastroEmpresaToolStripMenuItem";
            cadastroEmpresaToolStripMenuItem.Size = new Size(67, 20);
            cadastroEmpresaToolStripMenuItem.Text = " Empresa";
            cadastroEmpresaToolStripMenuItem.Click += cadastroEmpresaToolStripMenuItem_Click;
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
            selecionarEmpresaToolStripMenuItem.Click += selecionarEmpresaToolStripMenuItem_Click_1;
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { admitirFuncionárioToolStripMenuItem });
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(87, 20);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // admitirFuncionárioToolStripMenuItem
            // 
            admitirFuncionárioToolStripMenuItem.Name = "admitirFuncionárioToolStripMenuItem";
            admitirFuncionárioToolStripMenuItem.Size = new Size(178, 22);
            admitirFuncionárioToolStripMenuItem.Text = "Admitir funcionário";
            admitirFuncionárioToolStripMenuItem.Click += admitirFuncionárioToolStripMenuItem_Click;
            // 
            // folhaDePagamentoToolStripMenuItem
            // 
            folhaDePagamentoToolStripMenuItem.Name = "folhaDePagamentoToolStripMenuItem";
            folhaDePagamentoToolStripMenuItem.Size = new Size(128, 20);
            folhaDePagamentoToolStripMenuItem.Text = "Folha de Pagamento";
            folhaDePagamentoToolStripMenuItem.Click += folhaDePagamentoToolStripMenuItem_Click_1;
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(62, 20);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_cadastro);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_empresa);
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Controls.Add(txt_sobrenome);
            groupBox1.Location = new Point(191, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 281);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "CadGerente";
            // 
            // btn_cadastro
            // 
            btn_cadastro.Location = new Point(126, 214);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(123, 23);
            btn_cadastro.TabIndex = 11;
            btn_cadastro.Text = "Finalizar Cadastro";
            btn_cadastro.UseVisualStyleBackColor = true;
            btn_cadastro.Click += btn_cadastro_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 19);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 10;
            label6.Text = "CADASTRO DE GERENTES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 171);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "IdEmpresa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 147);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 118);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 89);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 6;
            label2.Text = "Sobrenome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 60);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // txt_empresa
            // 
            txt_empresa.Location = new Point(144, 168);
            txt_empresa.Name = "txt_empresa";
            txt_empresa.Size = new Size(100, 23);
            txt_empresa.TabIndex = 4;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(144, 52);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 3;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(144, 139);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 2;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(144, 110);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 1;
            // 
            // txt_sobrenome
            // 
            txt_sobrenome.Location = new Point(144, 81);
            txt_sobrenome.Name = "txt_sobrenome";
            txt_sobrenome.Size = new Size(100, 23);
            txt_sobrenome.TabIndex = 0;
            // 
            // CadastroGerenteEmpresasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "CadastroGerenteEmpresasForm";
            Text = "CadastroGerenteEmpresasForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ToolStripMenuItem folhaDePagamentoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btn_cadastro;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_empresa;
        private TextBox txt_nome;
        private TextBox txt_senha;
        private TextBox txt_usuario;
        private TextBox txt_sobrenome;
    }
}