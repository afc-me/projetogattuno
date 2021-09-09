namespace Projeto_TCC
{
    partial class frm4Funcionarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4Funcionarios));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.clmCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNResid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNResid = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.btnAlterarFunc = new System.Windows.Forms.Button();
            this.btnPesquisarFunc = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 25000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.Location = new System.Drawing.Point(640, 597);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEstado.MaxLength = 45;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(55, 30);
            this.txtEstado.TabIndex = 66;
            this.txtEstado.TabStop = false;
            this.toolTip1.SetToolTip(this.txtEstado, "Cidade onde mora o funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n" +
        "  - Letras (A, B, C...);\r\n  - Espaços (   );");
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.AllowUserToOrderColumns = true;
            this.dgvFunc.AllowUserToResizeColumns = false;
            this.dgvFunc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFunc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFunc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFunc.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCod,
            this.clmNome,
            this.clmFuncao,
            this.clmCPF,
            this.clmCEP,
            this.clmNResid,
            this.clmEndereco,
            this.clmBairro,
            this.clmCidade,
            this.clmEstado,
            this.clmTelefone,
            this.clmEmail});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFunc.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFunc.Location = new System.Drawing.Point(795, 355);
            this.dgvFunc.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFunc.MultiSelect = false;
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            this.dgvFunc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunc.Size = new System.Drawing.Size(418, 187);
            this.dgvFunc.TabIndex = 65;
            this.dgvFunc.TabStop = false;
            this.toolTip1.SetToolTip(this.dgvFunc, "Tabela de Funcionários.\r\n\r\nClique no conteúdo de uma linha da tabela para que tod" +
        "os os campos abaixo sejam preenchidos de forma correspondente.\r\n");
            this.dgvFunc.SelectionChanged += new System.EventHandler(this.dgvFunc_SelectionChanged);
            // 
            // clmCod
            // 
            this.clmCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.clmCod.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCod.Frozen = true;
            this.clmCod.HeaderText = "Cod";
            this.clmCod.MaxInputLength = 10;
            this.clmCod.MinimumWidth = 2;
            this.clmCod.Name = "clmCod";
            this.clmCod.ReadOnly = true;
            this.clmCod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCod.Width = 59;
            // 
            // clmNome
            // 
            this.clmNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNome.HeaderText = "Nome";
            this.clmNome.MaxInputLength = 100;
            this.clmNome.MinimumWidth = 2;
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmNome.Width = 72;
            // 
            // clmFuncao
            // 
            this.clmFuncao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFuncao.HeaderText = "Func";
            this.clmFuncao.MinimumWidth = 2;
            this.clmFuncao.Name = "clmFuncao";
            this.clmFuncao.ReadOnly = true;
            this.clmFuncao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmFuncao.Width = 64;
            // 
            // clmCPF
            // 
            this.clmCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCPF.HeaderText = "CPF";
            this.clmCPF.MaxInputLength = 20;
            this.clmCPF.MinimumWidth = 2;
            this.clmCPF.Name = "clmCPF";
            this.clmCPF.ReadOnly = true;
            this.clmCPF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCPF.Width = 58;
            // 
            // clmCEP
            // 
            this.clmCEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCEP.HeaderText = "CEP";
            this.clmCEP.MaxInputLength = 20;
            this.clmCEP.MinimumWidth = 2;
            this.clmCEP.Name = "clmCEP";
            this.clmCEP.ReadOnly = true;
            this.clmCEP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCEP.Width = 59;
            // 
            // clmNResid
            // 
            this.clmNResid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmNResid.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmNResid.FillWeight = 20F;
            this.clmNResid.HeaderText = "NRes";
            this.clmNResid.MinimumWidth = 2;
            this.clmNResid.Name = "clmNResid";
            this.clmNResid.ReadOnly = true;
            this.clmNResid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmNResid.Width = 68;
            // 
            // clmEndereco
            // 
            this.clmEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEndereco.HeaderText = "End";
            this.clmEndereco.MinimumWidth = 2;
            this.clmEndereco.Name = "clmEndereco";
            this.clmEndereco.ReadOnly = true;
            this.clmEndereco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmEndereco.Width = 58;
            // 
            // clmBairro
            // 
            this.clmBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmBairro.HeaderText = "Bair";
            this.clmBairro.MinimumWidth = 2;
            this.clmBairro.Name = "clmBairro";
            this.clmBairro.ReadOnly = true;
            this.clmBairro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmBairro.Width = 60;
            // 
            // clmCidade
            // 
            this.clmCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCidade.HeaderText = "Cid";
            this.clmCidade.MinimumWidth = 2;
            this.clmCidade.Name = "clmCidade";
            this.clmCidade.ReadOnly = true;
            this.clmCidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCidade.Width = 55;
            // 
            // clmEstado
            // 
            this.clmEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEstado.HeaderText = "Est";
            this.clmEstado.MinimumWidth = 2;
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            this.clmEstado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmEstado.Width = 54;
            // 
            // clmTelefone
            // 
            this.clmTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTelefone.HeaderText = "Tel";
            this.clmTelefone.MinimumWidth = 2;
            this.clmTelefone.Name = "clmTelefone";
            this.clmTelefone.ReadOnly = true;
            this.clmTelefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmTelefone.Width = 53;
            // 
            // clmEmail
            // 
            this.clmEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEmail.HeaderText = "E-Mail";
            this.clmEmail.MinimumWidth = 2;
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmEmail.Width = 76;
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.BackColor = System.Drawing.Color.White;
            this.cbxFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFuncao.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.cbxFuncao.ForeColor = System.Drawing.Color.Black;
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Items.AddRange(new object[] {
            "GARCOM",
            "COZINHEIRO",
            "FUNCIONARIO",
            "ADMINISTRADOR"});
            this.cbxFuncao.Location = new System.Drawing.Point(1031, 305);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(169, 27);
            this.cbxFuncao.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbxFuncao, "Função exercida pelo funcionário.");
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(88, 400);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(254, 30);
            this.txtEmail.TabIndex = 63;
            this.txtEmail.TabStop = false;
            this.toolTip1.SetToolTip(this.txtEmail, "E-mail do funcionário disponível para contato.\r\n\r\nSão permitidos apenas:\r\n  - Núm" +
        "eros (0 - 9);\r\n  - Letras (A, B, C...);\r\n  - Arrobas ( @ );\r\n  - Pontos ( . );\r\n" +
        "  - Hífens ( - );");
            // 
            // txtNResid
            // 
            this.txtNResid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNResid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNResid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNResid.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtNResid.ForeColor = System.Drawing.Color.Black;
            this.txtNResid.Location = new System.Drawing.Point(638, 499);
            this.txtNResid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNResid.MaxLength = 10;
            this.txtNResid.Name = "txtNResid";
            this.txtNResid.ReadOnly = true;
            this.txtNResid.Size = new System.Drawing.Size(55, 30);
            this.txtNResid.TabIndex = 53;
            this.txtNResid.TabStop = false;
            this.toolTip1.SetToolTip(this.txtNResid, "Número da residência do funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - " +
        "9);");
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(439, 400);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEndereco.MaxLength = 45;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(254, 30);
            this.txtEndereco.TabIndex = 56;
            this.txtEndereco.TabStop = false;
            this.toolTip1.SetToolTip(this.txtEndereco, "Endereço (rua, praça, quadra, beco, etc.) do funcionário.\r\n\r\nSão permitidos apena" +
        "s:\r\n  - Números (0 - 9);\r\n  - Letras (A, B, C...);\r\n  - Espaços (   );");
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVoltar.Location = new System.Drawing.Point(1049, 632);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 33);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "&Voltar";
            this.toolTip1.SetToolTip(this.btnVoltar, "Retorna à tela anterior.");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.Location = new System.Drawing.Point(439, 597);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCidade.MaxLength = 45;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(161, 30);
            this.txtCidade.TabIndex = 58;
            this.txtCidade.TabStop = false;
            this.toolTip1.SetToolTip(this.txtCidade, "Cidade onde mora o funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n" +
        "  - Letras (A, B, C...);\r\n  - Espaços (   );");
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(439, 499);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBairro.MaxLength = 45;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(161, 30);
            this.txtBairro.TabIndex = 57;
            this.txtBairro.TabStop = false;
            this.toolTip1.SetToolTip(this.txtBairro, "Bairro onde mora o funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n" +
        "  - Letras (A, B, C...);\r\n  - Espaços (   );");
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(88, 499);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCPF.MaxLength = 20;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(254, 30);
            this.txtCPF.TabIndex = 52;
            this.txtCPF.TabStop = false;
            this.toolTip1.SetToolTip(this.txtCPF, "RG do funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n  - Letras (A" +
        ", B, C...);");
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluirFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirFunc.FlatAppearance.BorderSize = 0;
            this.btnExcluirFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFunc.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnExcluirFunc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExcluirFunc.Location = new System.Drawing.Point(823, 632);
            this.btnExcluirFunc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(140, 33);
            this.btnExcluirFunc.TabIndex = 5;
            this.btnExcluirFunc.Text = "&Excluir";
            this.toolTip1.SetToolTip(this.btnExcluirFunc, "Exclui uma linha da tabela especificada pelo código do funcionário.\r\n\r\nO campo \'C" +
        "ódigo\' deve ser preenchido primeiro.\r\n");
            this.btnExcluirFunc.UseVisualStyleBackColor = false;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            // 
            // btnAlterarFunc
            // 
            this.btnAlterarFunc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterarFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarFunc.FlatAppearance.BorderSize = 0;
            this.btnAlterarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarFunc.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnAlterarFunc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAlterarFunc.Location = new System.Drawing.Point(1049, 570);
            this.btnAlterarFunc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAlterarFunc.Name = "btnAlterarFunc";
            this.btnAlterarFunc.Size = new System.Drawing.Size(140, 33);
            this.btnAlterarFunc.TabIndex = 4;
            this.btnAlterarFunc.Text = "&Alterar";
            this.toolTip1.SetToolTip(this.btnAlterarFunc, resources.GetString("btnAlterarFunc.ToolTip"));
            this.btnAlterarFunc.UseVisualStyleBackColor = false;
            this.btnAlterarFunc.Click += new System.EventHandler(this.btnAlterarFunc_Click);
            // 
            // btnPesquisarFunc
            // 
            this.btnPesquisarFunc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarFunc.FlatAppearance.BorderSize = 0;
            this.btnPesquisarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarFunc.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnPesquisarFunc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPesquisarFunc.Location = new System.Drawing.Point(823, 570);
            this.btnPesquisarFunc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPesquisarFunc.Name = "btnPesquisarFunc";
            this.btnPesquisarFunc.Size = new System.Drawing.Size(140, 33);
            this.btnPesquisarFunc.TabIndex = 3;
            this.btnPesquisarFunc.Text = "&Pesquisar";
            this.toolTip1.SetToolTip(this.btnPesquisarFunc, resources.GetString("btnPesquisarFunc.ToolTip"));
            this.btnPesquisarFunc.UseVisualStyleBackColor = false;
            this.btnPesquisarFunc.Click += new System.EventHandler(this.btnPesquisarFunc_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(88, 305);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(254, 30);
            this.txtNome.TabIndex = 51;
            this.txtNome.TabStop = false;
            this.toolTip1.SetToolTip(this.txtNome, "Nome do funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Letras (A, B, C...);");
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCEP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtCEP.ForeColor = System.Drawing.Color.Black;
            this.txtCEP.Location = new System.Drawing.Point(439, 305);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCEP.MaxLength = 20;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.ReadOnly = true;
            this.txtCEP.Size = new System.Drawing.Size(254, 30);
            this.txtCEP.TabIndex = 55;
            this.txtCEP.TabStop = false;
            this.toolTip1.SetToolTip(this.txtCEP, "CEP do funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);");
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.White;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtCod.ForeColor = System.Drawing.Color.Black;
            this.txtCod.Location = new System.Drawing.Point(810, 305);
            this.txtCod.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCod.MaxLength = 8;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(169, 30);
            this.txtCod.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCod, resources.GetString("txtCod.ToolTip"));
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Num);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone.Location = new System.Drawing.Point(88, 597);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTelefone.MaxLength = 20;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(254, 30);
            this.txtTelefone.TabIndex = 54;
            this.txtTelefone.TabStop = false;
            this.toolTip1.SetToolTip(this.txtTelefone, "Telefone fixo do funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);");
            // 
            // frm4Funcionarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::Projeto_TCC.Properties.Resources.Funcionários2;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.cbxFuncao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNResid);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnExcluirFunc);
            this.Controls.Add(this.btnAlterarFunc);
            this.Controls.Add(this.btnPesquisarFunc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtTelefone);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm4Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualização de Funcionários";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm4Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.ComboBox cbxFuncao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNResid;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Button btnAlterarFunc;
        private System.Windows.Forms.Button btnPesquisarFunc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNResid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
    }
}