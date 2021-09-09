namespace Projeto_TCC
{
    partial class frm4Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4Produtos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.clmCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
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
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnCadastrarProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(321, 582);
            this.btnCadastrarProduto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(147, 33);
            this.btnCadastrarProduto.TabIndex = 43;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.btnCadastrarProduto, "Inclui os dados especificados na tabela de produtos.\r\n\r\nTodos os campos devem ser" +
        " preenchidos primeiro.\r\n\r\nObs: Você deve preencher o campo \'Código\' para habilit" +
        "ar os outros campos.");
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtDesc.Location = new System.Drawing.Point(90, 506);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ShortcutsEnabled = false;
            this.txtDesc.Size = new System.Drawing.Size(605, 30);
            this.txtDesc.TabIndex = 39;
            this.toolTip1.SetToolTip(this.txtDesc, "Descrição detalhada do produto, especificando tamanho, peso, marca, etc.\r\n\r\nSão p" +
        "ermitidos apenas:\r\n  - Números (0 - 9);\r\n  - Letras (A, B, C...);");
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_NumLetraEspaco);
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarProduto.FlatAppearance.BorderSize = 0;
            this.btnAlterarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnAlterarProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAlterarProduto.Location = new System.Drawing.Point(548, 582);
            this.btnAlterarProduto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(147, 33);
            this.btnAlterarProduto.TabIndex = 44;
            this.btnAlterarProduto.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btnAlterarProduto, resources.GetString("btnAlterarProduto.ToolTip"));
            this.btnAlterarProduto.UseVisualStyleBackColor = false;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProduto.FlatAppearance.BorderSize = 0;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnExcluirProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExcluirProduto.Location = new System.Drawing.Point(210, 641);
            this.btnExcluirProduto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(147, 33);
            this.btnExcluirProduto.TabIndex = 45;
            this.btnExcluirProduto.Text = "Excluir";
            this.toolTip1.SetToolTip(this.btnExcluirProduto, "Exclui uma linha da tabela especificada pelo código do produto.\r\n\r\nO campo \'Códig" +
        "o\' deve ser preenchido primeiro.");
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtProduto.Location = new System.Drawing.Point(90, 412);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtProduto.MaxLength = 20;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ShortcutsEnabled = false;
            this.txtProduto.Size = new System.Drawing.Size(605, 30);
            this.txtProduto.TabIndex = 38;
            this.toolTip1.SetToolTip(this.txtProduto, "Nome do produto.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n  - Letras (A, " +
        "B, C...);");
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_NumLetraEspaco);
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtPrecoCompra.Location = new System.Drawing.Point(588, 320);
            this.txtPrecoCompra.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPrecoCompra.MaxLength = 10;
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.ShortcutsEnabled = false;
            this.txtPrecoCompra.Size = new System.Drawing.Size(98, 30);
            this.txtPrecoCompra.TabIndex = 40;
            this.toolTip1.SetToolTip(this.txtPrecoCompra, "Preço de compra do produto.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n  - " +
        "Pontos (.);");
            this.txtPrecoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_NumPonto);
            // 
            // txtCod
            // 
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtCod.Location = new System.Drawing.Point(90, 320);
            this.txtCod.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCod.MaxLength = 8;
            this.txtCod.Name = "txtCod";
            this.txtCod.ShortcutsEnabled = false;
            this.txtCod.Size = new System.Drawing.Size(254, 30);
            this.txtCod.TabIndex = 37;
            this.toolTip1.SetToolTip(this.txtCod, resources.GetString("txtCod.ToolTip"));
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Num);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarProduto.FlatAppearance.BorderSize = 0;
            this.btnPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnPesquisarProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(90, 582);
            this.btnPesquisarProduto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(147, 33);
            this.btnPesquisarProduto.TabIndex = 42;
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.btnPesquisarProduto, resources.GetString("btnPesquisarProduto.ToolTip"));
            this.btnPesquisarProduto.UseVisualStyleBackColor = false;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtde.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtQtde.Location = new System.Drawing.Point(399, 320);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtQtde.MaxLength = 10;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.ShortcutsEnabled = false;
            this.txtQtde.Size = new System.Drawing.Size(134, 30);
            this.txtQtde.TabIndex = 41;
            this.toolTip1.SetToolTip(this.txtQtde, "Quantidade do produto em estoque.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);" +
        "");
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Num);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 12F);
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCod,
            this.clmProduto,
            this.clmDesc,
            this.clmPreco,
            this.clmPrecoVenda,
            this.clmQtde,
            this.clmTotal});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdutos.Location = new System.Drawing.Point(784, 229);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.NullValue = null;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle20.NullValue = null;
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(435, 376);
            this.dgvProdutos.TabIndex = 48;
            this.dgvProdutos.TabStop = false;
            this.toolTip1.SetToolTip(this.dgvProdutos, "Tabela de produtos.\r\n\r\nClique no conteúdo de uma linha da tabela para que todos o" +
        "s campos abaixo sejam preenchidos de forma correspondente.");
            this.dgvProdutos.SelectionChanged += new System.EventHandler(this.dgvProdutos_SelectionChanged);
            // 
            // clmCod
            // 
            this.clmCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = null;
            this.clmCod.DefaultCellStyle = dataGridViewCellStyle13;
            this.clmCod.Frozen = true;
            this.clmCod.HeaderText = "Cod";
            this.clmCod.Name = "clmCod";
            this.clmCod.ReadOnly = true;
            this.clmCod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCod.Width = 59;
            // 
            // clmProduto
            // 
            this.clmProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmProduto.HeaderText = "Prod";
            this.clmProduto.Name = "clmProduto";
            this.clmProduto.ReadOnly = true;
            this.clmProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProduto.Width = 63;
            // 
            // clmDesc
            // 
            this.clmDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDesc.HeaderText = "Desc";
            this.clmDesc.Name = "clmDesc";
            this.clmDesc.ReadOnly = true;
            this.clmDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmDesc.Width = 66;
            // 
            // clmPreco
            // 
            this.clmPreco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.clmPreco.DefaultCellStyle = dataGridViewCellStyle14;
            this.clmPreco.HeaderText = "R$ Com.";
            this.clmPreco.Name = "clmPreco";
            this.clmPreco.ReadOnly = true;
            this.clmPreco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPreco.Width = 88;
            // 
            // clmPrecoVenda
            // 
            this.clmPrecoVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Format = "C2";
            this.clmPrecoVenda.DefaultCellStyle = dataGridViewCellStyle15;
            this.clmPrecoVenda.HeaderText = "R$ Ven.";
            this.clmPrecoVenda.Name = "clmPrecoVenda";
            this.clmPrecoVenda.ReadOnly = true;
            this.clmPrecoVenda.Width = 83;
            // 
            // clmQtde
            // 
            this.clmQtde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N0";
            dataGridViewCellStyle16.NullValue = null;
            this.clmQtde.DefaultCellStyle = dataGridViewCellStyle16;
            this.clmQtde.HeaderText = "Qt";
            this.clmQtde.Name = "clmQtde";
            this.clmQtde.ReadOnly = true;
            this.clmQtde.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmQtde.Width = 50;
            // 
            // clmTotal
            // 
            this.clmTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "C2";
            this.clmTotal.DefaultCellStyle = dataGridViewCellStyle17;
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            this.clmTotal.Width = 66;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLimpar.Location = new System.Drawing.Point(436, 641);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 33);
            this.btnLimpar.TabIndex = 46;
            this.btnLimpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.btnLimpar, "Limpa todos os campos.");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVoltar.Location = new System.Drawing.Point(1028, 641);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 33);
            this.btnVoltar.TabIndex = 47;
            this.btnVoltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btnVoltar, "Retorna à tela anterior.");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoVenda.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtPrecoVenda.Location = new System.Drawing.Point(588, 229);
            this.txtPrecoVenda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPrecoVenda.MaxLength = 10;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.ShortcutsEnabled = false;
            this.txtPrecoVenda.Size = new System.Drawing.Size(98, 30);
            this.txtPrecoVenda.TabIndex = 49;
            this.toolTip1.SetToolTip(this.txtPrecoVenda, "Preço de compra do produto.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n  - " +
        "Pontos (.);");
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_NumPonto);
            // 
            // frm4Produtos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::Projeto_TCC.Properties.Resources.Produtos2;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnAlterarProduto);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtPrecoCompra);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm4Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm4Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
    }
}

