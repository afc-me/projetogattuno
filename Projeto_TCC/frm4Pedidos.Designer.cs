namespace Projeto_TCC
{
    partial class frm4Pedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4Pedidos));
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.clmCodPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoraPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomeCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AllowUserToOrderColumns = true;
            this.dgvPedido.AllowUserToResizeColumns = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodPed,
            this.clmDataPed,
            this.clmHoraPed,
            this.clmNomeCli});
            this.dgvPedido.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPedido.Location = new System.Drawing.Point(786, 230);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            this.dgvPedido.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(435, 376);
            this.dgvPedido.TabIndex = 20;
            this.dgvPedido.TabStop = false;
            this.toolTip1.SetToolTip(this.dgvPedido, "Tabela de pedidos.\r\n\r\nClique no conteúdo de uma linha da tabela \r\npara preencher " +
        "todos os campos ao lado.");
            this.dgvPedido.SelectionChanged += new System.EventHandler(this.dgvPedido_SelectionChanged);
            // 
            // clmCodPed
            // 
            this.clmCodPed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.clmCodPed.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCodPed.FillWeight = 10F;
            this.clmCodPed.Frozen = true;
            this.clmCodPed.HeaderText = "Cod";
            this.clmCodPed.Name = "clmCodPed";
            this.clmCodPed.ReadOnly = true;
            this.clmCodPed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCodPed.Width = 59;
            // 
            // clmDataPed
            // 
            this.clmDataPed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.clmDataPed.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmDataPed.FillWeight = 10F;
            this.clmDataPed.HeaderText = "Dt";
            this.clmDataPed.Name = "clmDataPed";
            this.clmDataPed.ReadOnly = true;
            this.clmDataPed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmDataPed.Width = 49;
            // 
            // clmHoraPed
            // 
            this.clmHoraPed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "T";
            dataGridViewCellStyle4.NullValue = null;
            this.clmHoraPed.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmHoraPed.FillWeight = 10F;
            this.clmHoraPed.HeaderText = "Hr";
            this.clmHoraPed.MinimumWidth = 41;
            this.clmHoraPed.Name = "clmHoraPed";
            this.clmHoraPed.ReadOnly = true;
            this.clmHoraPed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmHoraPed.Width = 49;
            // 
            // clmNomeCli
            // 
            this.clmNomeCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNomeCli.FillWeight = 10F;
            this.clmNomeCli.HeaderText = "Cli";
            this.clmNomeCli.MinimumWidth = 200;
            this.clmNomeCli.Name = "clmNomeCli";
            this.clmNomeCli.ReadOnly = true;
            this.clmNomeCli.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmNomeCli.Width = 200;
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.White;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtCod.Location = new System.Drawing.Point(88, 319);
            this.txtCod.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCod.MaxLength = 8;
            this.txtCod.Name = "txtCod";
            this.txtCod.ShortcutsEnabled = false;
            this.txtCod.Size = new System.Drawing.Size(254, 30);
            this.txtCod.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCod, resources.GetString("txtCod.ToolTip"));
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodPedido_KeyDown);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Num);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.Gainsboro;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtData.Location = new System.Drawing.Point(93, 408);
            this.txtData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(116, 30);
            this.txtData.TabIndex = 2;
            this.txtData.TabStop = false;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtData, resources.GetString("txtData.ToolTip"));
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHora.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtHora.Location = new System.Drawing.Point(264, 408);
            this.txtHora.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtHora.MaxLength = 8;
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(78, 30);
            this.txtHora.TabIndex = 3;
            this.txtHora.TabStop = false;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtHora, resources.GetString("txtHora.ToolTip"));
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(8)))), ((int)(((byte)(21)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVoltar.Location = new System.Drawing.Point(1029, 641);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 33);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "&Voltar";
            this.toolTip1.SetToolTip(this.btnVoltar, "Retorna à tela anterior.");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(8)))), ((int)(((byte)(21)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLimpar.Location = new System.Drawing.Point(208, 628);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(140, 33);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.toolTip1.SetToolTip(this.btnLimpar, "Limpa todos os campos.");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(8)))), ((int)(((byte)(21)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExcluir.Location = new System.Drawing.Point(441, 628);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(140, 33);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "&Excluir";
            this.toolTip1.SetToolTip(this.btnExcluir, "Exclui uma linha da tabela especificada pelo código do pedido.\r\n\r\nO campo \'Código" +
        "\' no bloco \'Dados do Pedido\' deve ser preenchido primeiro.");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(8)))), ((int)(((byte)(21)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPesquisar.Location = new System.Drawing.Point(93, 548);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(140, 33);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "&Pesquisar";
            this.toolTip1.SetToolTip(this.btnPesquisar, resources.GetString("btnPesquisar.ToolTip"));
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(8)))), ((int)(((byte)(21)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAlterar.Location = new System.Drawing.Point(543, 548);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(140, 33);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "&Alterar";
            this.toolTip1.SetToolTip(this.btnAlterar, resources.GetString("btnAlterar.ToolTip"));
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(8)))), ((int)(((byte)(21)))));
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnIncluir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnIncluir.Location = new System.Drawing.Point(313, 548);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(140, 33);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "&Incluir";
            this.toolTip1.SetToolTip(this.btnIncluir, resources.GetString("btnIncluir.ToolTip"));
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(429, 319);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ShortcutsEnabled = false;
            this.txtNome.Size = new System.Drawing.Size(254, 30);
            this.txtNome.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNome, "Nome do cliente.\r\n\r\nSão permitidos apenas:\r\n  - Letras (A, B, C...);");
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_LetraEspaco);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
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
            // frm4Pedidos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::Projeto_TCC.Properties.Resources.Pedidos21;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(441, 628);
            this.MaximizeBox = false;
            this.Name = "frm4Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoraPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomeCli;
    }
}