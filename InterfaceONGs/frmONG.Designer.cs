﻿namespace InterfaceONGs
{
    partial class frmONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmONG));
            this.mkdTelONG = new System.Windows.Forms.MaskedTextBox();
            this.lblTelONG = new System.Windows.Forms.Label();
            this.lblEmailONG = new System.Windows.Forms.Label();
            this.lblCNPJONG = new System.Windows.Forms.Label();
            this.lblNomeONG = new System.Windows.Forms.Label();
            this.ptbLogoONG = new System.Windows.Forms.PictureBox();
            this.lblInfoONG = new System.Windows.Forms.Label();
            this.lblCategorariaONG = new System.Windows.Forms.Label();
            this.txtNomeONG = new System.Windows.Forms.TextBox();
            this.txtEmailONG = new System.Windows.Forms.TextBox();
            this.txtComplementoONG = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumeroONG = new System.Windows.Forms.Label();
            this.txtEnderecoONG = new System.Windows.Forms.TextBox();
            this.lblEnderecoONG = new System.Windows.Forms.Label();
            this.txtSiteONG = new System.Windows.Forms.TextBox();
            this.lblSiteONG = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.cboCategoriaONG = new System.Windows.Forms.ComboBox();
            this.btnLimparONG = new System.Windows.Forms.Button();
            this.btnAlterarONG = new System.Windows.Forms.Button();
            this.btnCriarONG = new System.Windows.Forms.Button();
            this.mkdCNPJONG = new System.Windows.Forms.MaskedTextBox();
            this.lblSobreONG = new System.Windows.Forms.Label();
            this.txtsobreONG = new System.Windows.Forms.TextBox();
            this.btnHomeONG = new System.Windows.Forms.Button();
            this.txtCidadeONG = new System.Windows.Forms.TextBox();
            this.lblCidadeONG = new System.Windows.Forms.Label();
            this.mkdCEPONG = new System.Windows.Forms.MaskedTextBox();
            this.lblCEPONG = new System.Windows.Forms.Label();
            this.txtBairroONG = new System.Windows.Forms.TextBox();
            this.lblBairroONG = new System.Windows.Forms.Label();
            this.mkdNumONG = new System.Windows.Forms.MaskedTextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtSenhaONG = new System.Windows.Forms.TextBox();
            this.lblSenhaONG = new System.Windows.Forms.Label();
            this.cbbRedeSocial = new System.Windows.Forms.ComboBox();
            this.lblRedeSocial = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoONG)).BeginInit();
            this.SuspendLayout();
            // 
            // mkdTelONG
            // 
            this.mkdTelONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkdTelONG.Location = new System.Drawing.Point(405, 260);
            this.mkdTelONG.Mask = "(00)00000-0000";
            this.mkdTelONG.Name = "mkdTelONG";
            this.mkdTelONG.Size = new System.Drawing.Size(124, 26);
            this.mkdTelONG.TabIndex = 3;
            this.mkdTelONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdTelFixo_KeyDown);
            // 
            // lblTelONG
            // 
            this.lblTelONG.AutoSize = true;
            this.lblTelONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTelONG.Location = new System.Drawing.Point(292, 261);
            this.lblTelONG.Name = "lblTelONG";
            this.lblTelONG.Size = new System.Drawing.Size(89, 25);
            this.lblTelONG.TabIndex = 40;
            this.lblTelONG.Text = "Telefone";
            // 
            // lblEmailONG
            // 
            this.lblEmailONG.AutoSize = true;
            this.lblEmailONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEmailONG.Location = new System.Drawing.Point(364, 216);
            this.lblEmailONG.Name = "lblEmailONG";
            this.lblEmailONG.Size = new System.Drawing.Size(67, 25);
            this.lblEmailONG.TabIndex = 38;
            this.lblEmailONG.Text = "E-mail";
            // 
            // lblCNPJONG
            // 
            this.lblCNPJONG.AutoSize = true;
            this.lblCNPJONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCNPJONG.Location = new System.Drawing.Point(550, 261);
            this.lblCNPJONG.Name = "lblCNPJONG";
            this.lblCNPJONG.Size = new System.Drawing.Size(65, 25);
            this.lblCNPJONG.TabIndex = 35;
            this.lblCNPJONG.Text = "CNPJ";
            // 
            // lblNomeONG
            // 
            this.lblNomeONG.AutoSize = true;
            this.lblNomeONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNomeONG.Location = new System.Drawing.Point(14, 216);
            this.lblNomeONG.Name = "lblNomeONG";
            this.lblNomeONG.Size = new System.Drawing.Size(64, 25);
            this.lblNomeONG.TabIndex = 34;
            this.lblNomeONG.Text = "Nome";
            // 
            // ptbLogoONG
            // 
            this.ptbLogoONG.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogoONG.Image")));
            this.ptbLogoONG.Location = new System.Drawing.Point(207, -21);
            this.ptbLogoONG.Name = "ptbLogoONG";
            this.ptbLogoONG.Size = new System.Drawing.Size(427, 133);
            this.ptbLogoONG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogoONG.TabIndex = 44;
            this.ptbLogoONG.TabStop = false;
            // 
            // lblInfoONG
            // 
            this.lblInfoONG.AutoSize = true;
            this.lblInfoONG.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoONG.Location = new System.Drawing.Point(291, 93);
            this.lblInfoONG.Name = "lblInfoONG";
            this.lblInfoONG.Size = new System.Drawing.Size(259, 34);
            this.lblInfoONG.TabIndex = 45;
            this.lblInfoONG.Text = "Cadastro de ONG";
            // 
            // lblCategorariaONG
            // 
            this.lblCategorariaONG.AutoSize = true;
            this.lblCategorariaONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCategorariaONG.Location = new System.Drawing.Point(14, 379);
            this.lblCategorariaONG.Name = "lblCategorariaONG";
            this.lblCategorariaONG.Size = new System.Drawing.Size(97, 25);
            this.lblCategorariaONG.TabIndex = 47;
            this.lblCategorariaONG.Text = "Categoria";
            // 
            // txtNomeONG
            // 
            this.txtNomeONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeONG.Location = new System.Drawing.Point(127, 215);
            this.txtNomeONG.Name = "txtNomeONG";
            this.txtNomeONG.Size = new System.Drawing.Size(231, 26);
            this.txtNomeONG.TabIndex = 0;
            this.txtNomeONG.TextChanged += new System.EventHandler(this.txtNomeONG_TextChanged);
            this.txtNomeONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // txtEmailONG
            // 
            this.txtEmailONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmailONG.Location = new System.Drawing.Point(437, 215);
            this.txtEmailONG.MaxLength = 40;
            this.txtEmailONG.Name = "txtEmailONG";
            this.txtEmailONG.Size = new System.Drawing.Size(231, 26);
            this.txtEmailONG.TabIndex = 1;
            this.txtEmailONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtComplementoONG
            // 
            this.txtComplementoONG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplementoONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtComplementoONG.Location = new System.Drawing.Point(680, 300);
            this.txtComplementoONG.Margin = new System.Windows.Forms.Padding(5);
            this.txtComplementoONG.MaxLength = 50;
            this.txtComplementoONG.Name = "txtComplementoONG";
            this.txtComplementoONG.Size = new System.Drawing.Size(159, 19);
            this.txtComplementoONG.TabIndex = 7;
            this.txtComplementoONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComplemento_KeyDown);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblComplemento.Location = new System.Drawing.Point(549, 297);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(134, 25);
            this.lblComplemento.TabIndex = 56;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumeroONG
            // 
            this.lblNumeroONG.AutoSize = true;
            this.lblNumeroONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNumeroONG.Location = new System.Drawing.Point(411, 297);
            this.lblNumeroONG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroONG.Name = "lblNumeroONG";
            this.lblNumeroONG.Size = new System.Drawing.Size(33, 25);
            this.lblNumeroONG.TabIndex = 55;
            this.lblNumeroONG.Text = "Nº";
            // 
            // txtEnderecoONG
            // 
            this.txtEnderecoONG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnderecoONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEnderecoONG.Location = new System.Drawing.Point(127, 300);
            this.txtEnderecoONG.Margin = new System.Windows.Forms.Padding(5);
            this.txtEnderecoONG.MaxLength = 50;
            this.txtEnderecoONG.Name = "txtEnderecoONG";
            this.txtEnderecoONG.Size = new System.Drawing.Size(274, 19);
            this.txtEnderecoONG.TabIndex = 5;
            this.txtEnderecoONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndereco_KeyDown);
            // 
            // lblEnderecoONG
            // 
            this.lblEnderecoONG.AutoSize = true;
            this.lblEnderecoONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEnderecoONG.Location = new System.Drawing.Point(14, 297);
            this.lblEnderecoONG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEnderecoONG.Name = "lblEnderecoONG";
            this.lblEnderecoONG.Size = new System.Drawing.Size(96, 25);
            this.lblEnderecoONG.TabIndex = 54;
            this.lblEnderecoONG.Text = "Endereço";
            // 
            // txtSiteONG
            // 
            this.txtSiteONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSiteONG.Location = new System.Drawing.Point(127, 420);
            this.txtSiteONG.Name = "txtSiteONG";
            this.txtSiteONG.Size = new System.Drawing.Size(248, 26);
            this.txtSiteONG.TabIndex = 13;
            this.txtSiteONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSite_KeyDown);
            // 
            // lblSiteONG
            // 
            this.lblSiteONG.AutoSize = true;
            this.lblSiteONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSiteONG.Location = new System.Drawing.Point(14, 421);
            this.lblSiteONG.Name = "lblSiteONG";
            this.lblSiteONG.Size = new System.Drawing.Size(46, 25);
            this.lblSiteONG.TabIndex = 61;
            this.lblSiteONG.Text = "Site";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUrl.Location = new System.Drawing.Point(420, 462);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(231, 26);
            this.txtUrl.TabIndex = 15;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblURL.Location = new System.Drawing.Point(364, 459);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(50, 25);
            this.lblURL.TabIndex = 63;
            this.lblURL.Text = "URL";
            // 
            // cboCategoriaONG
            // 
            this.cboCategoriaONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCategoriaONG.FormattingEnabled = true;
            this.cboCategoriaONG.Items.AddRange(new object[] {
            "Meio Ambiente",
            "Animais\t",
            "Seres Humanos",
            "Genêro",
            "Escolar"});
            this.cboCategoriaONG.Location = new System.Drawing.Point(127, 377);
            this.cboCategoriaONG.Name = "cboCategoriaONG";
            this.cboCategoriaONG.Size = new System.Drawing.Size(188, 28);
            this.cboCategoriaONG.TabIndex = 11;
            this.cboCategoriaONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCategoria_KeyDown);
            // 
            // btnLimparONG
            // 
            this.btnLimparONG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparONG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimparONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimparONG.Location = new System.Drawing.Point(439, 506);
            this.btnLimparONG.Name = "btnLimparONG";
            this.btnLimparONG.Size = new System.Drawing.Size(85, 35);
            this.btnLimparONG.TabIndex = 18;
            this.btnLimparONG.Text = "Limpar";
            this.btnLimparONG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimparONG.UseVisualStyleBackColor = true;
            this.btnLimparONG.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterarONG
            // 
            this.btnAlterarONG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarONG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlterarONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterarONG.Location = new System.Drawing.Point(245, 506);
            this.btnAlterarONG.Name = "btnAlterarONG";
            this.btnAlterarONG.Size = new System.Drawing.Size(85, 35);
            this.btnAlterarONG.TabIndex = 17;
            this.btnAlterarONG.Text = "Alterar";
            this.btnAlterarONG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarONG.UseVisualStyleBackColor = true;
            this.btnAlterarONG.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCriarONG
            // 
            this.btnCriarONG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarONG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCriarONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCriarONG.Location = new System.Drawing.Point(145, 506);
            this.btnCriarONG.Name = "btnCriarONG";
            this.btnCriarONG.Size = new System.Drawing.Size(85, 35);
            this.btnCriarONG.TabIndex = 16;
            this.btnCriarONG.Text = "Confirmar";
            this.btnCriarONG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCriarONG.UseVisualStyleBackColor = true;
            this.btnCriarONG.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // mkdCNPJONG
            // 
            this.mkdCNPJONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkdCNPJONG.Location = new System.Drawing.Point(621, 260);
            this.mkdCNPJONG.Mask = "00,000,000/0000-00";
            this.mkdCNPJONG.Name = "mkdCNPJONG";
            this.mkdCNPJONG.Size = new System.Drawing.Size(160, 26);
            this.mkdCNPJONG.TabIndex = 4;
            this.mkdCNPJONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdCNPJ_KeyDown);
            // 
            // lblSobreONG
            // 
            this.lblSobreONG.AutoSize = true;
            this.lblSobreONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSobreONG.Location = new System.Drawing.Point(339, 379);
            this.lblSobreONG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSobreONG.Name = "lblSobreONG";
            this.lblSobreONG.Size = new System.Drawing.Size(131, 25);
            this.lblSobreONG.TabIndex = 69;
            this.lblSobreONG.Text = "Sobre a ONG";
            // 
            // txtsobreONG
            // 
            this.txtsobreONG.Location = new System.Drawing.Point(487, 381);
            this.txtsobreONG.Name = "txtsobreONG";
            this.txtsobreONG.Size = new System.Drawing.Size(354, 20);
            this.txtsobreONG.TabIndex = 12;
            this.txtsobreONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsobreONG_KeyDown);
            // 
            // btnHomeONG
            // 
            this.btnHomeONG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeONG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHomeONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeONG.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHomeONG.Location = new System.Drawing.Point(621, 506);
            this.btnHomeONG.Name = "btnHomeONG";
            this.btnHomeONG.Size = new System.Drawing.Size(123, 35);
            this.btnHomeONG.TabIndex = 20;
            this.btnHomeONG.Text = "Página Inicial";
            this.btnHomeONG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomeONG.UseVisualStyleBackColor = true;
            this.btnHomeONG.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtCidadeONG
            // 
            this.txtCidadeONG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidadeONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCidadeONG.Location = new System.Drawing.Point(629, 342);
            this.txtCidadeONG.Margin = new System.Windows.Forms.Padding(5);
            this.txtCidadeONG.MaxLength = 50;
            this.txtCidadeONG.Name = "txtCidadeONG";
            this.txtCidadeONG.Size = new System.Drawing.Size(201, 19);
            this.txtCidadeONG.TabIndex = 10;
            this.txtCidadeONG.TabStop = false;
            // 
            // lblCidadeONG
            // 
            this.lblCidadeONG.AutoSize = true;
            this.lblCidadeONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCidadeONG.Location = new System.Drawing.Point(544, 339);
            this.lblCidadeONG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCidadeONG.Name = "lblCidadeONG";
            this.lblCidadeONG.Size = new System.Drawing.Size(75, 25);
            this.lblCidadeONG.TabIndex = 81;
            this.lblCidadeONG.Text = "Cidade";
            // 
            // mkdCEPONG
            // 
            this.mkdCEPONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkdCEPONG.Location = new System.Drawing.Point(127, 338);
            this.mkdCEPONG.Mask = "00000-000";
            this.mkdCEPONG.Name = "mkdCEPONG";
            this.mkdCEPONG.Size = new System.Drawing.Size(88, 26);
            this.mkdCEPONG.TabIndex = 8;
            this.mkdCEPONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdCEP_KeyDown);
            this.mkdCEPONG.Leave += new System.EventHandler(this.mkdCEP_Leave);
            // 
            // lblCEPONG
            // 
            this.lblCEPONG.AutoSize = true;
            this.lblCEPONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCEPONG.Location = new System.Drawing.Point(14, 339);
            this.lblCEPONG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCEPONG.Name = "lblCEPONG";
            this.lblCEPONG.Size = new System.Drawing.Size(53, 25);
            this.lblCEPONG.TabIndex = 80;
            this.lblCEPONG.Text = "CEP";
            // 
            // txtBairroONG
            // 
            this.txtBairroONG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairroONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBairroONG.Location = new System.Drawing.Point(325, 342);
            this.txtBairroONG.Margin = new System.Windows.Forms.Padding(5);
            this.txtBairroONG.MaxLength = 50;
            this.txtBairroONG.Name = "txtBairroONG";
            this.txtBairroONG.Size = new System.Drawing.Size(201, 19);
            this.txtBairroONG.TabIndex = 9;
            this.txtBairroONG.TabStop = false;
            // 
            // lblBairroONG
            // 
            this.lblBairroONG.AutoSize = true;
            this.lblBairroONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBairroONG.Location = new System.Drawing.Point(252, 339);
            this.lblBairroONG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBairroONG.Name = "lblBairroONG";
            this.lblBairroONG.Size = new System.Drawing.Size(63, 25);
            this.lblBairroONG.TabIndex = 79;
            this.lblBairroONG.Text = "Bairro";
            // 
            // mkdNumONG
            // 
            this.mkdNumONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkdNumONG.Location = new System.Drawing.Point(448, 296);
            this.mkdNumONG.Mask = "00000";
            this.mkdNumONG.Name = "mkdNumONG";
            this.mkdNumONG.Size = new System.Drawing.Size(55, 26);
            this.mkdNumONG.TabIndex = 6;
            this.mkdNumONG.ValidatingType = typeof(int);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeletar.Location = new System.Drawing.Point(530, 506);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(85, 35);
            this.btnDeletar.TabIndex = 19;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtSenhaONG
            // 
            this.txtSenhaONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSenhaONG.Location = new System.Drawing.Point(127, 258);
            this.txtSenhaONG.MaxLength = 40;
            this.txtSenhaONG.Name = "txtSenhaONG";
            this.txtSenhaONG.PasswordChar = '*';
            this.txtSenhaONG.Size = new System.Drawing.Size(156, 26);
            this.txtSenhaONG.TabIndex = 2;
            this.txtSenhaONG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenhaONG_KeyDown);
            // 
            // lblSenhaONG
            // 
            this.lblSenhaONG.AutoSize = true;
            this.lblSenhaONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSenhaONG.Location = new System.Drawing.Point(14, 259);
            this.lblSenhaONG.Name = "lblSenhaONG";
            this.lblSenhaONG.Size = new System.Drawing.Size(70, 25);
            this.lblSenhaONG.TabIndex = 85;
            this.lblSenhaONG.Text = "Senha";
            // 
            // cbbRedeSocial
            // 
            this.cbbRedeSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbRedeSocial.FormattingEnabled = true;
            this.cbbRedeSocial.Items.AddRange(new object[] {
            "Instagram",
            "Linkdln",
            "Facebook",
            "Twitter"});
            this.cbbRedeSocial.Location = new System.Drawing.Point(127, 460);
            this.cbbRedeSocial.Name = "cbbRedeSocial";
            this.cbbRedeSocial.Size = new System.Drawing.Size(188, 28);
            this.cbbRedeSocial.TabIndex = 14;
            // 
            // lblRedeSocial
            // 
            this.lblRedeSocial.AutoSize = true;
            this.lblRedeSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRedeSocial.Location = new System.Drawing.Point(14, 463);
            this.lblRedeSocial.Name = "lblRedeSocial";
            this.lblRedeSocial.Size = new System.Drawing.Size(97, 25);
            this.lblRedeSocial.TabIndex = 87;
            this.lblRedeSocial.Text = "Categoria";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(344, 506);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 35);
            this.btnPesquisar.TabIndex = 88;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(847, 543);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbbRedeSocial);
            this.Controls.Add(this.lblRedeSocial);
            this.Controls.Add(this.txtSenhaONG);
            this.Controls.Add(this.lblSenhaONG);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.mkdNumONG);
            this.Controls.Add(this.txtCidadeONG);
            this.Controls.Add(this.lblCidadeONG);
            this.Controls.Add(this.mkdCEPONG);
            this.Controls.Add(this.lblCEPONG);
            this.Controls.Add(this.txtBairroONG);
            this.Controls.Add(this.lblBairroONG);
            this.Controls.Add(this.btnHomeONG);
            this.Controls.Add(this.txtsobreONG);
            this.Controls.Add(this.lblSobreONG);
            this.Controls.Add(this.mkdCNPJONG);
            this.Controls.Add(this.btnLimparONG);
            this.Controls.Add(this.btnAlterarONG);
            this.Controls.Add(this.btnCriarONG);
            this.Controls.Add(this.cboCategoriaONG);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtSiteONG);
            this.Controls.Add(this.lblSiteONG);
            this.Controls.Add(this.txtComplementoONG);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumeroONG);
            this.Controls.Add(this.txtEnderecoONG);
            this.Controls.Add(this.lblEnderecoONG);
            this.Controls.Add(this.txtEmailONG);
            this.Controls.Add(this.txtNomeONG);
            this.Controls.Add(this.lblCategorariaONG);
            this.Controls.Add(this.lblInfoONG);
            this.Controls.Add(this.ptbLogoONG);
            this.Controls.Add(this.mkdTelONG);
            this.Controls.Add(this.lblTelONG);
            this.Controls.Add(this.lblEmailONG);
            this.Controls.Add(this.lblCNPJONG);
            this.Controls.Add(this.lblNomeONG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro-ONG";
            this.Load += new System.EventHandler(this.frmONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mkdTelONG;
        private System.Windows.Forms.Label lblTelONG;
        private System.Windows.Forms.Label lblEmailONG;
        private System.Windows.Forms.Label lblCNPJONG;
        private System.Windows.Forms.Label lblNomeONG;
        private System.Windows.Forms.PictureBox ptbLogoONG;
        private System.Windows.Forms.Label lblInfoONG;
        private System.Windows.Forms.Label lblCategorariaONG;
        private System.Windows.Forms.TextBox txtNomeONG;
        private System.Windows.Forms.TextBox txtEmailONG;
        private System.Windows.Forms.TextBox txtComplementoONG;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumeroONG;
        private System.Windows.Forms.TextBox txtEnderecoONG;
        private System.Windows.Forms.Label lblEnderecoONG;
        private System.Windows.Forms.TextBox txtSiteONG;
        private System.Windows.Forms.Label lblSiteONG;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.ComboBox cboCategoriaONG;
        private System.Windows.Forms.Button btnLimparONG;
        private System.Windows.Forms.Button btnAlterarONG;
        private System.Windows.Forms.Button btnCriarONG;
        private System.Windows.Forms.MaskedTextBox mkdCNPJONG;
        private System.Windows.Forms.Label lblSobreONG;
        private System.Windows.Forms.TextBox txtsobreONG;
        private System.Windows.Forms.Button btnHomeONG;
        private System.Windows.Forms.TextBox txtCidadeONG;
        private System.Windows.Forms.Label lblCidadeONG;
        private System.Windows.Forms.MaskedTextBox mkdCEPONG;
        private System.Windows.Forms.Label lblCEPONG;
        private System.Windows.Forms.TextBox txtBairroONG;
        private System.Windows.Forms.Label lblBairroONG;
        private System.Windows.Forms.MaskedTextBox mkdNumONG;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtSenhaONG;
        private System.Windows.Forms.Label lblSenhaONG;
        private System.Windows.Forms.ComboBox cbbRedeSocial;
        private System.Windows.Forms.Label lblRedeSocial;
        private System.Windows.Forms.Button btnPesquisar;
    }
}