namespace SagitarioRHDesktop
{
    partial class CadastroEmpresa
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            btn_cadastroEmpresa = new Button();
            txt_telefone = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_email = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_titularEmpresa = new TextBox();
            txt_fantasia = new TextBox();
            txt_razaoSocial = new TextBox();
            txt_cnpj = new TextBox();
            menuStrip1 = new MenuStrip();
            cadastroEmpresaToolStripMenuItem = new ToolStripMenuItem();
            cadastroEmpresaToolStripMenuItem1 = new ToolStripMenuItem();
            selecionarEmpresaToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            admitirFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            folhaDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(btn_cadastroEmpresa);
            groupBox1.Controls.Add(txt_telefone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_titularEmpresa);
            groupBox1.Controls.Add(txt_fantasia);
            groupBox1.Controls.Add(txt_razaoSocial);
            groupBox1.Controls.Add(txt_cnpj);
            groupBox1.Location = new Point(112, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 352);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox_CadastroEmp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 162);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 17;
            label8.Text = "Usuário:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(369, 162);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 16;
            label7.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(417, 159);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(159, 23);
            txtSenha.TabIndex = 15;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(115, 159);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(159, 23);
            txtUsuario.TabIndex = 14;
            // 
            // btn_cadastroEmpresa
            // 
            btn_cadastroEmpresa.Location = new Point(249, 274);
            btn_cadastroEmpresa.Name = "btn_cadastroEmpresa";
            btn_cadastroEmpresa.Size = new Size(139, 23);
            btn_cadastroEmpresa.TabIndex = 13;
            btn_cadastroEmpresa.Text = "Cadastrar Empresa";
            btn_cadastroEmpresa.UseVisualStyleBackColor = true;
            btn_cadastroEmpresa.Click += btn_cadastroEmpresa_Click;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(417, 113);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(159, 23);
            txt_telefone.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(357, 116);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 11;
            label6.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 113);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "E-mail:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(115, 113);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(159, 23);
            txt_email.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 27);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 8;
            label1.Text = "CNPJ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 74);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 7;
            label4.Text = "Titular Empresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 71);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 6;
            label3.Text = "Nome Fantasia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 30);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Razão Social:";
            // 
            // txt_titularEmpresa
            // 
            txt_titularEmpresa.Location = new Point(417, 71);
            txt_titularEmpresa.Name = "txt_titularEmpresa";
            txt_titularEmpresa.Size = new Size(159, 23);
            txt_titularEmpresa.TabIndex = 3;
            // 
            // txt_fantasia
            // 
            txt_fantasia.Location = new Point(115, 71);
            txt_fantasia.Name = "txt_fantasia";
            txt_fantasia.Size = new Size(159, 23);
            txt_fantasia.TabIndex = 2;
            // 
            // txt_razaoSocial
            // 
            txt_razaoSocial.Location = new Point(417, 27);
            txt_razaoSocial.Name = "txt_razaoSocial";
            txt_razaoSocial.Size = new Size(159, 23);
            txt_razaoSocial.TabIndex = 1;
            // 
            // txt_cnpj
            // 
            txt_cnpj.Location = new Point(115, 27);
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(159, 23);
            txt_cnpj.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroEmpresaToolStripMenuItem, funcionáriosToolStripMenuItem, folhaDePagamentoToolStripMenuItem, cadastroDeUsuáriosToolStripMenuItem, encerrarToolStripMenuItem });
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
            selecionarEmpresaToolStripMenuItem.Click += selecionarEmpresaToolStripMenuItem_Click;
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
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            cadastroDeUsuáriosToolStripMenuItem.Size = new Size(126, 20);
            cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de Gerente";
            cadastroDeUsuáriosToolStripMenuItem.Click += cadastroDeUsuáriosToolStripMenuItem_Click;
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(62, 20);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click;
            // 
            // CadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Name = "CadastroEmpresa";
            Text = "CadastroEmpresa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_titularEmpresa;
        private TextBox txt_fantasia;
        private TextBox txt_razaoSocial;
        private TextBox txt_cnpj;
        private Button btn_cadastroEmpresa;
        private TextBox txt_telefone;
        private Label label6;
        private Label label5;
        private TextBox txt_email;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroEmpresaToolStripMenuItem;
        private ToolStripMenuItem cadastroEmpresaToolStripMenuItem1;
        private ToolStripMenuItem selecionarEmpresaToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem admitirFuncionárioToolStripMenuItem;
        private ToolStripMenuItem folhaDePagamentoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private Label label8;
        private Label label7;
        private TextBox txtSenha;
        private TextBox txtUsuario;
    }
}