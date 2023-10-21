namespace SagitarioRHDesktop
{
    partial class AdmitirFuncionario
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
            txt_FuncSenha = new TextBox();
            txt_FuncUsuario = new TextBox();
            btn_LimparInfoFunc = new Button();
            btn_ProxCadFunc = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            gp_plSaudeFunc = new GroupBox();
            rb_PlanSFuncNao = new RadioButton();
            rb_PlanSFuncSim = new RadioButton();
            gp_vlRefFunc = new GroupBox();
            rb_vrFuncNao = new RadioButton();
            rb_vrFuncSim = new RadioButton();
            label3 = new Label();
            txt_PlSaude = new TextBox();
            label6 = new Label();
            txt_funcValeRef = new TextBox();
            gp_InfoRemunFunc = new GroupBox();
            gp_vlTransFunc = new GroupBox();
            rb_vtFuncNao = new RadioButton();
            rb_vtFuncSim = new RadioButton();
            gp_adcPericFunc = new GroupBox();
            rb_PericFuncNao = new RadioButton();
            rb_PericFuncSim = new RadioButton();
            gp_PercInsalub = new GroupBox();
            rb_InsalFunc30 = new RadioButton();
            rb_InsalFunc10 = new RadioButton();
            rb_InsalFunc20 = new RadioButton();
            gp_AddInsalubFunc = new GroupBox();
            rb_InsalFuncNao = new RadioButton();
            rb_InsalFuncSim = new RadioButton();
            label2 = new Label();
            txt_funcDepent = new TextBox();
            lbl_salarioFunc = new Label();
            txt_salarioFunc = new TextBox();
            gp_InfoCargoFunc = new GroupBox();
            label8 = new Label();
            txt_IdEmpresa = new TextBox();
            lbl_DtAdmFunc = new Label();
            lbl_JornadaFunc = new Label();
            lbl_FuncaoFunc = new Label();
            lbl_SetorFunc = new Label();
            txt_jornadaFunc = new TextBox();
            txt_funcaoFunc = new TextBox();
            txt_dtAdmFunc = new TextBox();
            txt_setorFunc = new TextBox();
            gp_InfoContatoFunc = new GroupBox();
            txt_emailFunc = new TextBox();
            lbl_TelFunc = new Label();
            txt_telFunc = new TextBox();
            lbl_EmailFunc = new Label();
            gp_InfoPessoaisFunc = new GroupBox();
            lbl_CEPFunc = new Label();
            txt_cepFunc = new TextBox();
            lbl_NmCompletoFunc = new Label();
            lbl_PISFunc = new Label();
            lbl_CPFFunc = new Label();
            lbl_RGFunc = new Label();
            txt_pisFunc = new TextBox();
            txt_cpfFunc = new TextBox();
            txt_RgFunc = new TextBox();
            txt_NmCompletoFunc = new TextBox();
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
            groupBox3 = new GroupBox();
            label4 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gp_plSaudeFunc.SuspendLayout();
            gp_vlRefFunc.SuspendLayout();
            gp_InfoRemunFunc.SuspendLayout();
            gp_vlTransFunc.SuspendLayout();
            gp_adcPericFunc.SuspendLayout();
            gp_PercInsalub.SuspendLayout();
            gp_AddInsalubFunc.SuspendLayout();
            gp_InfoCargoFunc.SuspendLayout();
            gp_InfoContatoFunc.SuspendLayout();
            gp_InfoPessoaisFunc.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txt_FuncSenha
            // 
            txt_FuncSenha.Location = new Point(434, 27);
            txt_FuncSenha.Name = "txt_FuncSenha";
            txt_FuncSenha.PlaceholderText = "Ex: 12345";
            txt_FuncSenha.Size = new Size(206, 23);
            txt_FuncSenha.TabIndex = 31;
            // 
            // txt_FuncUsuario
            // 
            txt_FuncUsuario.Location = new Point(109, 27);
            txt_FuncUsuario.Name = "txt_FuncUsuario";
            txt_FuncUsuario.PlaceholderText = "Ex: john";
            txt_FuncUsuario.Size = new Size(206, 23);
            txt_FuncUsuario.TabIndex = 30;
            // 
            // btn_LimparInfoFunc
            // 
            btn_LimparInfoFunc.Location = new Point(254, 830);
            btn_LimparInfoFunc.Name = "btn_LimparInfoFunc";
            btn_LimparInfoFunc.Size = new Size(180, 23);
            btn_LimparInfoFunc.TabIndex = 33;
            btn_LimparInfoFunc.Text = "Limpar Infomações";
            btn_LimparInfoFunc.UseVisualStyleBackColor = true;
            btn_LimparInfoFunc.Click += btn_LimparInfoFunc_Click;
            // 
            // btn_ProxCadFunc
            // 
            btn_ProxCadFunc.Location = new Point(440, 830);
            btn_ProxCadFunc.Name = "btn_ProxCadFunc";
            btn_ProxCadFunc.Size = new Size(180, 23);
            btn_ProxCadFunc.TabIndex = 32;
            btn_ProxCadFunc.Text = "Cadastrar Funcionário";
            btn_ProxCadFunc.UseVisualStyleBackColor = true;
            btn_ProxCadFunc.Click += btn_ProxCadFunc_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(gp_plSaudeFunc);
            groupBox1.Controls.Add(gp_vlRefFunc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_PlSaude);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_funcValeRef);
            groupBox1.Location = new Point(14, 577);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(839, 148);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações de Desconto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Location = new Point(224, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 48);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "Coparticipativo:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(65, 21);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "Não";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 21);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sim";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // gp_plSaudeFunc
            // 
            gp_plSaudeFunc.Controls.Add(rb_PlanSFuncNao);
            gp_plSaudeFunc.Controls.Add(rb_PlanSFuncSim);
            gp_plSaudeFunc.Location = new Point(10, 84);
            gp_plSaudeFunc.Name = "gp_plSaudeFunc";
            gp_plSaudeFunc.Size = new Size(200, 48);
            gp_plSaudeFunc.TabIndex = 58;
            gp_plSaudeFunc.TabStop = false;
            gp_plSaudeFunc.Text = "Plano de Saúde:";
            // 
            // rb_PlanSFuncNao
            // 
            rb_PlanSFuncNao.AutoSize = true;
            rb_PlanSFuncNao.Location = new Point(68, 22);
            rb_PlanSFuncNao.Name = "rb_PlanSFuncNao";
            rb_PlanSFuncNao.Size = new Size(47, 19);
            rb_PlanSFuncNao.TabIndex = 26;
            rb_PlanSFuncNao.TabStop = true;
            rb_PlanSFuncNao.Text = "Não";
            rb_PlanSFuncNao.UseVisualStyleBackColor = true;
            // 
            // rb_PlanSFuncSim
            // 
            rb_PlanSFuncSim.AutoSize = true;
            rb_PlanSFuncSim.Location = new Point(17, 22);
            rb_PlanSFuncSim.Name = "rb_PlanSFuncSim";
            rb_PlanSFuncSim.Size = new Size(45, 19);
            rb_PlanSFuncSim.TabIndex = 25;
            rb_PlanSFuncSim.TabStop = true;
            rb_PlanSFuncSim.Text = "Sim";
            rb_PlanSFuncSim.UseVisualStyleBackColor = true;
            // 
            // gp_vlRefFunc
            // 
            gp_vlRefFunc.Controls.Add(rb_vrFuncNao);
            gp_vlRefFunc.Controls.Add(rb_vrFuncSim);
            gp_vlRefFunc.Location = new Point(10, 27);
            gp_vlRefFunc.Name = "gp_vlRefFunc";
            gp_vlRefFunc.Size = new Size(193, 51);
            gp_vlRefFunc.TabIndex = 57;
            gp_vlRefFunc.TabStop = false;
            gp_vlRefFunc.Text = "Vale Refeição:";
            // 
            // rb_vrFuncNao
            // 
            rb_vrFuncNao.AutoSize = true;
            rb_vrFuncNao.Location = new Point(73, 22);
            rb_vrFuncNao.Name = "rb_vrFuncNao";
            rb_vrFuncNao.Size = new Size(47, 19);
            rb_vrFuncNao.TabIndex = 23;
            rb_vrFuncNao.TabStop = true;
            rb_vrFuncNao.Text = "Não";
            rb_vrFuncNao.UseVisualStyleBackColor = true;
            // 
            // rb_vrFuncSim
            // 
            rb_vrFuncSim.AutoSize = true;
            rb_vrFuncSim.Location = new Point(22, 22);
            rb_vrFuncSim.Name = "rb_vrFuncSim";
            rb_vrFuncSim.Size = new Size(45, 19);
            rb_vrFuncSim.TabIndex = 22;
            rb_vrFuncSim.TabStop = true;
            rb_vrFuncSim.Text = "Sim";
            rb_vrFuncSim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 87);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 12;
            label3.Text = "Digite a %:";
            // 
            // txt_PlSaude
            // 
            txt_PlSaude.Location = new Point(522, 84);
            txt_PlSaude.Name = "txt_PlSaude";
            txt_PlSaude.PlaceholderText = "Ex: 6";
            txt_PlSaude.Size = new Size(206, 23);
            txt_PlSaude.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 30);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "Digite a %:";
            // 
            // txt_funcValeRef
            // 
            txt_funcValeRef.Location = new Point(279, 27);
            txt_funcValeRef.Name = "txt_funcValeRef";
            txt_funcValeRef.PlaceholderText = "Ex: 12";
            txt_funcValeRef.Size = new Size(145, 23);
            txt_funcValeRef.TabIndex = 24;
            // 
            // gp_InfoRemunFunc
            // 
            gp_InfoRemunFunc.Controls.Add(gp_vlTransFunc);
            gp_InfoRemunFunc.Controls.Add(gp_adcPericFunc);
            gp_InfoRemunFunc.Controls.Add(gp_PercInsalub);
            gp_InfoRemunFunc.Controls.Add(gp_AddInsalubFunc);
            gp_InfoRemunFunc.Controls.Add(label2);
            gp_InfoRemunFunc.Controls.Add(txt_funcDepent);
            gp_InfoRemunFunc.Controls.Add(lbl_salarioFunc);
            gp_InfoRemunFunc.Controls.Add(txt_salarioFunc);
            gp_InfoRemunFunc.Location = new Point(14, 396);
            gp_InfoRemunFunc.Name = "gp_InfoRemunFunc";
            gp_InfoRemunFunc.Size = new Size(839, 165);
            gp_InfoRemunFunc.TabIndex = 50;
            gp_InfoRemunFunc.TabStop = false;
            gp_InfoRemunFunc.Text = "Informações de Remuneração";
            // 
            // gp_vlTransFunc
            // 
            gp_vlTransFunc.Controls.Add(rb_vtFuncNao);
            gp_vlTransFunc.Controls.Add(rb_vtFuncSim);
            gp_vlTransFunc.Location = new Point(279, 93);
            gp_vlTransFunc.Name = "gp_vlTransFunc";
            gp_vlTransFunc.Size = new Size(217, 54);
            gp_vlTransFunc.TabIndex = 60;
            gp_vlTransFunc.TabStop = false;
            gp_vlTransFunc.Text = "Vale Transporte:";
            // 
            // rb_vtFuncNao
            // 
            rb_vtFuncNao.AutoSize = true;
            rb_vtFuncNao.Location = new Point(69, 22);
            rb_vtFuncNao.Name = "rb_vtFuncNao";
            rb_vtFuncNao.Size = new Size(47, 19);
            rb_vtFuncNao.TabIndex = 20;
            rb_vtFuncNao.TabStop = true;
            rb_vtFuncNao.Text = "Não";
            rb_vtFuncNao.UseVisualStyleBackColor = true;
            // 
            // rb_vtFuncSim
            // 
            rb_vtFuncSim.AutoSize = true;
            rb_vtFuncSim.Location = new Point(18, 22);
            rb_vtFuncSim.Name = "rb_vtFuncSim";
            rb_vtFuncSim.Size = new Size(45, 19);
            rb_vtFuncSim.TabIndex = 19;
            rb_vtFuncSim.TabStop = true;
            rb_vtFuncSim.Text = "Sim";
            rb_vtFuncSim.UseVisualStyleBackColor = true;
            // 
            // gp_adcPericFunc
            // 
            gp_adcPericFunc.Controls.Add(rb_PericFuncNao);
            gp_adcPericFunc.Controls.Add(rb_PericFuncSim);
            gp_adcPericFunc.Location = new Point(6, 96);
            gp_adcPericFunc.Name = "gp_adcPericFunc";
            gp_adcPericFunc.Size = new Size(266, 50);
            gp_adcPericFunc.TabIndex = 59;
            gp_adcPericFunc.TabStop = false;
            gp_adcPericFunc.Text = "Adc. Periculosidade:";
            // 
            // rb_PericFuncNao
            // 
            rb_PericFuncNao.AutoSize = true;
            rb_PericFuncNao.Location = new Point(65, 22);
            rb_PericFuncNao.Name = "rb_PericFuncNao";
            rb_PericFuncNao.Size = new Size(47, 19);
            rb_PericFuncNao.TabIndex = 18;
            rb_PericFuncNao.TabStop = true;
            rb_PericFuncNao.Text = "Não";
            rb_PericFuncNao.UseVisualStyleBackColor = true;
            // 
            // rb_PericFuncSim
            // 
            rb_PericFuncSim.AutoSize = true;
            rb_PericFuncSim.Location = new Point(14, 22);
            rb_PericFuncSim.Name = "rb_PericFuncSim";
            rb_PericFuncSim.Size = new Size(45, 19);
            rb_PericFuncSim.TabIndex = 17;
            rb_PericFuncSim.TabStop = true;
            rb_PericFuncSim.Text = "Sim";
            rb_PericFuncSim.UseVisualStyleBackColor = true;
            // 
            // gp_PercInsalub
            // 
            gp_PercInsalub.Controls.Add(rb_InsalFunc30);
            gp_PercInsalub.Controls.Add(rb_InsalFunc10);
            gp_PercInsalub.Controls.Add(rb_InsalFunc20);
            gp_PercInsalub.Location = new Point(549, 23);
            gp_PercInsalub.Name = "gp_PercInsalub";
            gp_PercInsalub.Size = new Size(284, 50);
            gp_PercInsalub.TabIndex = 58;
            gp_PercInsalub.TabStop = false;
            gp_PercInsalub.Text = "Selecione a %:";
            // 
            // rb_InsalFunc30
            // 
            rb_InsalFunc30.AutoSize = true;
            rb_InsalFunc30.Location = new Point(122, 23);
            rb_InsalFunc30.Name = "rb_InsalFunc30";
            rb_InsalFunc30.Size = new Size(47, 19);
            rb_InsalFunc30.TabIndex = 16;
            rb_InsalFunc30.TabStop = true;
            rb_InsalFunc30.Text = "30%";
            rb_InsalFunc30.UseVisualStyleBackColor = true;
            // 
            // rb_InsalFunc10
            // 
            rb_InsalFunc10.AutoSize = true;
            rb_InsalFunc10.Location = new Point(16, 23);
            rb_InsalFunc10.Name = "rb_InsalFunc10";
            rb_InsalFunc10.Size = new Size(47, 19);
            rb_InsalFunc10.TabIndex = 14;
            rb_InsalFunc10.TabStop = true;
            rb_InsalFunc10.Text = "10%";
            rb_InsalFunc10.UseVisualStyleBackColor = true;
            // 
            // rb_InsalFunc20
            // 
            rb_InsalFunc20.AutoSize = true;
            rb_InsalFunc20.Location = new Point(69, 23);
            rb_InsalFunc20.Name = "rb_InsalFunc20";
            rb_InsalFunc20.Size = new Size(47, 19);
            rb_InsalFunc20.TabIndex = 15;
            rb_InsalFunc20.TabStop = true;
            rb_InsalFunc20.Text = "20%";
            rb_InsalFunc20.UseVisualStyleBackColor = true;
            // 
            // gp_AddInsalubFunc
            // 
            gp_AddInsalubFunc.Controls.Add(rb_InsalFuncNao);
            gp_AddInsalubFunc.Controls.Add(rb_InsalFuncSim);
            gp_AddInsalubFunc.Location = new Point(309, 23);
            gp_AddInsalubFunc.Name = "gp_AddInsalubFunc";
            gp_AddInsalubFunc.Size = new Size(234, 50);
            gp_AddInsalubFunc.TabIndex = 57;
            gp_AddInsalubFunc.TabStop = false;
            gp_AddInsalubFunc.Text = "Adc. Insalubridade:";
            // 
            // rb_InsalFuncNao
            // 
            rb_InsalFuncNao.AutoSize = true;
            rb_InsalFuncNao.Location = new Point(68, 22);
            rb_InsalFuncNao.Name = "rb_InsalFuncNao";
            rb_InsalFuncNao.Size = new Size(47, 19);
            rb_InsalFuncNao.TabIndex = 13;
            rb_InsalFuncNao.TabStop = true;
            rb_InsalFuncNao.Text = "Não";
            rb_InsalFuncNao.UseVisualStyleBackColor = true;
            // 
            // rb_InsalFuncSim
            // 
            rb_InsalFuncSim.AutoSize = true;
            rb_InsalFuncSim.Location = new Point(17, 22);
            rb_InsalFuncSim.Name = "rb_InsalFuncSim";
            rb_InsalFuncSim.Size = new Size(45, 19);
            rb_InsalFuncSim.TabIndex = 12;
            rb_InsalFuncSim.TabStop = true;
            rb_InsalFuncSim.Text = "Sim";
            rb_InsalFuncSim.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 96);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 12;
            label2.Text = "N° de Filhos:";
            // 
            // txt_funcDepent
            // 
            txt_funcDepent.Location = new Point(587, 93);
            txt_funcDepent.Name = "txt_funcDepent";
            txt_funcDepent.Size = new Size(246, 23);
            txt_funcDepent.TabIndex = 21;
            // 
            // lbl_salarioFunc
            // 
            lbl_salarioFunc.AutoSize = true;
            lbl_salarioFunc.Location = new Point(10, 30);
            lbl_salarioFunc.Name = "lbl_salarioFunc";
            lbl_salarioFunc.Size = new Size(45, 15);
            lbl_salarioFunc.TabIndex = 8;
            lbl_salarioFunc.Text = "Salário:";
            // 
            // txt_salarioFunc
            // 
            txt_salarioFunc.Location = new Point(60, 27);
            txt_salarioFunc.Name = "txt_salarioFunc";
            txt_salarioFunc.Size = new Size(236, 23);
            txt_salarioFunc.TabIndex = 11;
            // 
            // gp_InfoCargoFunc
            // 
            gp_InfoCargoFunc.Controls.Add(label8);
            gp_InfoCargoFunc.Controls.Add(txt_IdEmpresa);
            gp_InfoCargoFunc.Controls.Add(lbl_DtAdmFunc);
            gp_InfoCargoFunc.Controls.Add(lbl_JornadaFunc);
            gp_InfoCargoFunc.Controls.Add(lbl_FuncaoFunc);
            gp_InfoCargoFunc.Controls.Add(lbl_SetorFunc);
            gp_InfoCargoFunc.Controls.Add(txt_jornadaFunc);
            gp_InfoCargoFunc.Controls.Add(txt_funcaoFunc);
            gp_InfoCargoFunc.Controls.Add(txt_dtAdmFunc);
            gp_InfoCargoFunc.Controls.Add(txt_setorFunc);
            gp_InfoCargoFunc.Location = new Point(14, 268);
            gp_InfoCargoFunc.Name = "gp_InfoCargoFunc";
            gp_InfoCargoFunc.Size = new Size(839, 116);
            gp_InfoCargoFunc.TabIndex = 48;
            gp_InfoCargoFunc.TabStop = false;
            gp_InfoCargoFunc.Text = "Informações de Cargo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(330, 30);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 10;
            label8.Text = "Id da Empresa:";
            // 
            // txt_IdEmpresa
            // 
            txt_IdEmpresa.Location = new Point(420, 27);
            txt_IdEmpresa.Name = "txt_IdEmpresa";
            txt_IdEmpresa.PlaceholderText = "Ex: 3";
            txt_IdEmpresa.Size = new Size(165, 23);
            txt_IdEmpresa.TabIndex = 7;
            // 
            // lbl_DtAdmFunc
            // 
            lbl_DtAdmFunc.AutoSize = true;
            lbl_DtAdmFunc.Location = new Point(10, 30);
            lbl_DtAdmFunc.Name = "lbl_DtAdmFunc";
            lbl_DtAdmFunc.Size = new Size(105, 15);
            lbl_DtAdmFunc.TabIndex = 8;
            lbl_DtAdmFunc.Text = "Data de Admissão:";
            // 
            // lbl_JornadaFunc
            // 
            lbl_JornadaFunc.AutoSize = true;
            lbl_JornadaFunc.Location = new Point(426, 74);
            lbl_JornadaFunc.Name = "lbl_JornadaFunc";
            lbl_JornadaFunc.Size = new Size(51, 15);
            lbl_JornadaFunc.TabIndex = 7;
            lbl_JornadaFunc.Text = "Jornada:";
            // 
            // lbl_FuncaoFunc
            // 
            lbl_FuncaoFunc.AutoSize = true;
            lbl_FuncaoFunc.Location = new Point(10, 72);
            lbl_FuncaoFunc.Name = "lbl_FuncaoFunc";
            lbl_FuncaoFunc.Size = new Size(49, 15);
            lbl_FuncaoFunc.TabIndex = 6;
            lbl_FuncaoFunc.Text = "Função:";
            // 
            // lbl_SetorFunc
            // 
            lbl_SetorFunc.AutoSize = true;
            lbl_SetorFunc.Location = new Point(591, 35);
            lbl_SetorFunc.Name = "lbl_SetorFunc";
            lbl_SetorFunc.Size = new Size(37, 15);
            lbl_SetorFunc.TabIndex = 5;
            lbl_SetorFunc.Text = "Setor:";
            // 
            // txt_jornadaFunc
            // 
            txt_jornadaFunc.Location = new Point(483, 69);
            txt_jornadaFunc.Name = "txt_jornadaFunc";
            txt_jornadaFunc.Size = new Size(342, 23);
            txt_jornadaFunc.TabIndex = 10;
            // 
            // txt_funcaoFunc
            // 
            txt_funcaoFunc.Location = new Point(65, 66);
            txt_funcaoFunc.Name = "txt_funcaoFunc";
            txt_funcaoFunc.Size = new Size(341, 23);
            txt_funcaoFunc.TabIndex = 9;
            // 
            // txt_dtAdmFunc
            // 
            txt_dtAdmFunc.Location = new Point(121, 27);
            txt_dtAdmFunc.Name = "txt_dtAdmFunc";
            txt_dtAdmFunc.PlaceholderText = "Ex: 2023-01-01";
            txt_dtAdmFunc.Size = new Size(195, 23);
            txt_dtAdmFunc.TabIndex = 6;
            // 
            // txt_setorFunc
            // 
            txt_setorFunc.Location = new Point(634, 27);
            txt_setorFunc.Name = "txt_setorFunc";
            txt_setorFunc.Size = new Size(191, 23);
            txt_setorFunc.TabIndex = 8;
            // 
            // gp_InfoContatoFunc
            // 
            gp_InfoContatoFunc.Controls.Add(txt_emailFunc);
            gp_InfoContatoFunc.Controls.Add(lbl_TelFunc);
            gp_InfoContatoFunc.Controls.Add(txt_telFunc);
            gp_InfoContatoFunc.Controls.Add(lbl_EmailFunc);
            gp_InfoContatoFunc.Location = new Point(14, 184);
            gp_InfoContatoFunc.Name = "gp_InfoContatoFunc";
            gp_InfoContatoFunc.Size = new Size(839, 78);
            gp_InfoContatoFunc.TabIndex = 49;
            gp_InfoContatoFunc.TabStop = false;
            gp_InfoContatoFunc.Text = "Informações de Contato";
            // 
            // txt_emailFunc
            // 
            txt_emailFunc.Location = new Point(60, 33);
            txt_emailFunc.Name = "txt_emailFunc";
            txt_emailFunc.PlaceholderText = "Ex: john@yahoo.com";
            txt_emailFunc.Size = new Size(346, 23);
            txt_emailFunc.TabIndex = 5;
            // 
            // lbl_TelFunc
            // 
            lbl_TelFunc.AutoSize = true;
            lbl_TelFunc.Location = new Point(424, 36);
            lbl_TelFunc.Name = "lbl_TelFunc";
            lbl_TelFunc.Size = new Size(54, 15);
            lbl_TelFunc.TabIndex = 17;
            lbl_TelFunc.Text = "Telefone:";
            // 
            // txt_telFunc
            // 
            txt_telFunc.Location = new Point(484, 33);
            txt_telFunc.Name = "txt_telFunc";
            txt_telFunc.PlaceholderText = "Ex: (12) 34567-8910";
            txt_telFunc.Size = new Size(341, 23);
            txt_telFunc.TabIndex = 6;
            // 
            // lbl_EmailFunc
            // 
            lbl_EmailFunc.AutoSize = true;
            lbl_EmailFunc.Location = new Point(10, 36);
            lbl_EmailFunc.Name = "lbl_EmailFunc";
            lbl_EmailFunc.Size = new Size(44, 15);
            lbl_EmailFunc.TabIndex = 7;
            lbl_EmailFunc.Text = "E-mail:";
            // 
            // gp_InfoPessoaisFunc
            // 
            gp_InfoPessoaisFunc.Controls.Add(lbl_CEPFunc);
            gp_InfoPessoaisFunc.Controls.Add(txt_cepFunc);
            gp_InfoPessoaisFunc.Controls.Add(lbl_NmCompletoFunc);
            gp_InfoPessoaisFunc.Controls.Add(lbl_PISFunc);
            gp_InfoPessoaisFunc.Controls.Add(lbl_CPFFunc);
            gp_InfoPessoaisFunc.Controls.Add(lbl_RGFunc);
            gp_InfoPessoaisFunc.Controls.Add(txt_pisFunc);
            gp_InfoPessoaisFunc.Controls.Add(txt_cpfFunc);
            gp_InfoPessoaisFunc.Controls.Add(txt_RgFunc);
            gp_InfoPessoaisFunc.Controls.Add(txt_NmCompletoFunc);
            gp_InfoPessoaisFunc.Location = new Point(14, 62);
            gp_InfoPessoaisFunc.Name = "gp_InfoPessoaisFunc";
            gp_InfoPessoaisFunc.Size = new Size(839, 116);
            gp_InfoPessoaisFunc.TabIndex = 47;
            gp_InfoPessoaisFunc.TabStop = false;
            gp_InfoPessoaisFunc.Text = "Informações Pessoais";
            // 
            // lbl_CEPFunc
            // 
            lbl_CEPFunc.AutoSize = true;
            lbl_CEPFunc.Location = new Point(424, 77);
            lbl_CEPFunc.Name = "lbl_CEPFunc";
            lbl_CEPFunc.Size = new Size(31, 15);
            lbl_CEPFunc.TabIndex = 17;
            lbl_CEPFunc.Text = "CEP:";
            // 
            // txt_cepFunc
            // 
            txt_cepFunc.Location = new Point(461, 71);
            txt_cepFunc.Name = "txt_cepFunc";
            txt_cepFunc.PlaceholderText = "Ex: 12345-678";
            txt_cepFunc.Size = new Size(364, 23);
            txt_cepFunc.TabIndex = 4;
            // 
            // lbl_NmCompletoFunc
            // 
            lbl_NmCompletoFunc.AutoSize = true;
            lbl_NmCompletoFunc.Location = new Point(10, 30);
            lbl_NmCompletoFunc.Name = "lbl_NmCompletoFunc";
            lbl_NmCompletoFunc.Size = new Size(99, 15);
            lbl_NmCompletoFunc.TabIndex = 8;
            lbl_NmCompletoFunc.Text = "Nome Completo:";
            // 
            // lbl_PISFunc
            // 
            lbl_PISFunc.AutoSize = true;
            lbl_PISFunc.Location = new Point(10, 74);
            lbl_PISFunc.Name = "lbl_PISFunc";
            lbl_PISFunc.Size = new Size(26, 15);
            lbl_PISFunc.TabIndex = 7;
            lbl_PISFunc.Text = "PIS:";
            // 
            // lbl_CPFFunc
            // 
            lbl_CPFFunc.AutoSize = true;
            lbl_CPFFunc.Location = new Point(588, 32);
            lbl_CPFFunc.Name = "lbl_CPFFunc";
            lbl_CPFFunc.Size = new Size(31, 15);
            lbl_CPFFunc.TabIndex = 6;
            lbl_CPFFunc.Text = "CPF:";
            // 
            // lbl_RGFunc
            // 
            lbl_RGFunc.AutoSize = true;
            lbl_RGFunc.Location = new Point(339, 30);
            lbl_RGFunc.Name = "lbl_RGFunc";
            lbl_RGFunc.Size = new Size(25, 15);
            lbl_RGFunc.TabIndex = 5;
            lbl_RGFunc.Text = "RG:";
            // 
            // txt_pisFunc
            // 
            txt_pisFunc.Location = new Point(42, 71);
            txt_pisFunc.Name = "txt_pisFunc";
            txt_pisFunc.PlaceholderText = "Ex: 123.45678.91-0";
            txt_pisFunc.Size = new Size(364, 23);
            txt_pisFunc.TabIndex = 3;
            // 
            // txt_cpfFunc
            // 
            txt_cpfFunc.Location = new Point(625, 27);
            txt_cpfFunc.MaxLength = 11;
            txt_cpfFunc.Name = "txt_cpfFunc";
            txt_cpfFunc.PlaceholderText = "Ex: 123.456.789-10";
            txt_cpfFunc.Size = new Size(200, 23);
            txt_cpfFunc.TabIndex = 2;
            txt_cpfFunc.UseWaitCursor = true;
            // 
            // txt_RgFunc
            // 
            txt_RgFunc.Location = new Point(370, 27);
            txt_RgFunc.Name = "txt_RgFunc";
            txt_RgFunc.PlaceholderText = "Ex: 123456789111";
            txt_RgFunc.Size = new Size(200, 23);
            txt_RgFunc.TabIndex = 1;
            // 
            // txt_NmCompletoFunc
            // 
            txt_NmCompletoFunc.Location = new Point(115, 27);
            txt_NmCompletoFunc.Name = "txt_NmCompletoFunc";
            txt_NmCompletoFunc.Size = new Size(200, 23);
            txt_NmCompletoFunc.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroEmpresaToolStripMenuItem, funcionáriosToolStripMenuItem, folhaDePagamentoToolStripMenuItem, cadastroDeUsuáriosToolStripMenuItem, encerrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(892, 24);
            menuStrip1.TabIndex = 56;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txt_FuncUsuario);
            groupBox3.Controls.Add(txt_FuncSenha);
            groupBox3.Location = new Point(14, 732);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(839, 71);
            groupBox3.TabIndex = 60;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informações de Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 30);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 61;
            label4.Text = "Digite uma senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 60;
            label1.Text = "Digite o usuário:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 33);
            label5.Name = "label5";
            label5.Size = new Size(168, 15);
            label5.TabIndex = 61;
            label5.Text = "Cadastro de Novo Funcionário";
            // 
            // AdmitirFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 881);
            Controls.Add(label5);
            Controls.Add(groupBox3);
            Controls.Add(menuStrip1);
            Controls.Add(btn_LimparInfoFunc);
            Controls.Add(btn_ProxCadFunc);
            Controls.Add(groupBox1);
            Controls.Add(gp_InfoRemunFunc);
            Controls.Add(gp_InfoCargoFunc);
            Controls.Add(gp_InfoContatoFunc);
            Controls.Add(gp_InfoPessoaisFunc);
            Name = "AdmitirFuncionario";
            Text = "AdmitirFuncionario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gp_plSaudeFunc.ResumeLayout(false);
            gp_plSaudeFunc.PerformLayout();
            gp_vlRefFunc.ResumeLayout(false);
            gp_vlRefFunc.PerformLayout();
            gp_InfoRemunFunc.ResumeLayout(false);
            gp_InfoRemunFunc.PerformLayout();
            gp_vlTransFunc.ResumeLayout(false);
            gp_vlTransFunc.PerformLayout();
            gp_adcPericFunc.ResumeLayout(false);
            gp_adcPericFunc.PerformLayout();
            gp_PercInsalub.ResumeLayout(false);
            gp_PercInsalub.PerformLayout();
            gp_AddInsalubFunc.ResumeLayout(false);
            gp_AddInsalubFunc.PerformLayout();
            gp_InfoCargoFunc.ResumeLayout(false);
            gp_InfoCargoFunc.PerformLayout();
            gp_InfoContatoFunc.ResumeLayout(false);
            gp_InfoContatoFunc.PerformLayout();
            gp_InfoPessoaisFunc.ResumeLayout(false);
            gp_InfoPessoaisFunc.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_FuncSenha;
        private TextBox txt_FuncUsuario;
        private Button btn_LimparInfoFunc;
        private Button btn_ProxCadFunc;
        private GroupBox groupBox1;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox txt_PlSaude;
        private RadioButton rb_PlanSFuncNao;
        private RadioButton rb_PlanSFuncSim;
        private RadioButton rb_vrFuncNao;
        private RadioButton rb_vrFuncSim;
        private Label label6;
        private TextBox txt_funcValeRef;
        private GroupBox gp_InfoRemunFunc;
        private Label label2;
        private RadioButton rb_vtFuncNao;
        private RadioButton rb_vtFuncSim;
        private TextBox txt_funcDepent;
        private RadioButton rb_PericFuncNao;
        private RadioButton rb_PericFuncSim;
        private RadioButton rb_InsalFunc30;
        private RadioButton rb_InsalFunc20;
        private RadioButton rb_InsalFunc10;
        private RadioButton rb_InsalFuncNao;
        private RadioButton rb_InsalFuncSim;
        private Label lbl_salarioFunc;
        private TextBox txt_salarioFunc;
        private GroupBox gp_InfoCargoFunc;
        private Label label8;
        private TextBox txt_IdEmpresa;
        private Label lbl_DtAdmFunc;
        private Label lbl_JornadaFunc;
        private Label lbl_FuncaoFunc;
        private Label lbl_SetorFunc;
        private TextBox txt_jornadaFunc;
        private TextBox txt_funcaoFunc;
        private TextBox txt_dtAdmFunc;
        private TextBox txt_setorFunc;
        private GroupBox gp_InfoContatoFunc;
        private TextBox txt_emailFunc;
        private Label lbl_TelFunc;
        private TextBox txt_telFunc;
        private Label lbl_EmailFunc;
        private GroupBox gp_InfoPessoaisFunc;
        private Label lbl_CEPFunc;
        private TextBox txt_cepFunc;
        private Label lbl_NmCompletoFunc;
        private Label lbl_PISFunc;
        private Label lbl_CPFFunc;
        private Label lbl_RGFunc;
        private TextBox txt_pisFunc;
        private TextBox txt_cpfFunc;
        private TextBox txt_RgFunc;
        private TextBox txt_NmCompletoFunc;
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
        private GroupBox gp_AddInsalubFunc;
        private GroupBox gp_vlTransFunc;
        private GroupBox gp_adcPericFunc;
        private GroupBox gp_PercInsalub;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox gp_plSaudeFunc;
        private GroupBox gp_vlRefFunc;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private Label label5;
    }
}