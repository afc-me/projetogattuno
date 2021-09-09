namespace Projeto_TCC
{
    partial class frm4Financas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4Financas));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.clmCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtLucroTotal = new System.Windows.Forms.TextBox();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.txtGanho = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtMediaTotal = new System.Windows.Forms.TextBox();
            this.txtMediaPrecoCompra = new System.Windows.Forms.TextBox();
            this.txtMediaPrecoVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCod,
            this.clmProduto,
            this.clmDesc,
            this.clmPreco,
            this.clmPrecoVenda,
            this.clmQtde,
            this.clmTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdutos.Location = new System.Drawing.Point(258, 225);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle10.NullValue = null;
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(797, 238);
            this.dgvProdutos.TabIndex = 50;
            this.dgvProdutos.TabStop = false;
            this.toolTip1.SetToolTip(this.dgvProdutos, "Tabela de produtos.\r\n\r\nClique no conteúdo de uma linha da tabela para que todos o" +
        "s campos abaixo sejam preenchidos de forma correspondente.");
            // 
            // clmCod
            // 
            this.clmCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.clmCod.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.clmPreco.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmPreco.HeaderText = "R$ Com.";
            this.clmPreco.Name = "clmPreco";
            this.clmPreco.ReadOnly = true;
            this.clmPreco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPreco.Width = 88;
            // 
            // clmPrecoVenda
            // 
            this.clmPrecoVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "C2";
            this.clmPrecoVenda.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmPrecoVenda.HeaderText = "R$ Ven.";
            this.clmPrecoVenda.Name = "clmPrecoVenda";
            this.clmPrecoVenda.ReadOnly = true;
            this.clmPrecoVenda.Width = 83;
            // 
            // clmQtde
            // 
            this.clmQtde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.clmQtde.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmQtde.HeaderText = "Qt";
            this.clmQtde.Name = "clmQtde";
            this.clmQtde.ReadOnly = true;
            this.clmQtde.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmQtde.Width = 50;
            // 
            // clmTotal
            // 
            this.clmTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            this.clmTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            this.clmTotal.Width = 66;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVoltar.Location = new System.Drawing.Point(594, 608);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 33);
            this.btnVoltar.TabIndex = 48;
            this.btnVoltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btnVoltar, "Retorna à tela anterior.");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtLucroTotal
            // 
            this.txtLucroTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLucroTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLucroTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLucroTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtLucroTotal.Location = new System.Drawing.Point(815, 492);
            this.txtLucroTotal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLucroTotal.MaxLength = 10;
            this.txtLucroTotal.Name = "txtLucroTotal";
            this.txtLucroTotal.ReadOnly = true;
            this.txtLucroTotal.ShortcutsEnabled = false;
            this.txtLucroTotal.Size = new System.Drawing.Size(229, 30);
            this.txtLucroTotal.TabIndex = 51;
            // 
            // txtGasto
            // 
            this.txtGasto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGasto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtGasto.Location = new System.Drawing.Point(275, 492);
            this.txtGasto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtGasto.MaxLength = 10;
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.ReadOnly = true;
            this.txtGasto.ShortcutsEnabled = false;
            this.txtGasto.Size = new System.Drawing.Size(229, 30);
            this.txtGasto.TabIndex = 50;
            // 
            // txtGanho
            // 
            this.txtGanho.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGanho.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtGanho.Location = new System.Drawing.Point(545, 492);
            this.txtGanho.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtGanho.MaxLength = 10;
            this.txtGanho.Name = "txtGanho";
            this.txtGanho.ReadOnly = true;
            this.txtGanho.ShortcutsEnabled = false;
            this.txtGanho.Size = new System.Drawing.Size(229, 30);
            this.txtGanho.TabIndex = 52;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
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
            // txtMediaTotal
            // 
            this.txtMediaTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMediaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMediaTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMediaTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtMediaTotal.Location = new System.Drawing.Point(815, 538);
            this.txtMediaTotal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMediaTotal.MaxLength = 10;
            this.txtMediaTotal.Name = "txtMediaTotal";
            this.txtMediaTotal.ReadOnly = true;
            this.txtMediaTotal.ShortcutsEnabled = false;
            this.txtMediaTotal.Size = new System.Drawing.Size(229, 30);
            this.txtMediaTotal.TabIndex = 54;
            // 
            // txtMediaPrecoCompra
            // 
            this.txtMediaPrecoCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMediaPrecoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMediaPrecoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMediaPrecoCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtMediaPrecoCompra.Location = new System.Drawing.Point(275, 538);
            this.txtMediaPrecoCompra.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMediaPrecoCompra.MaxLength = 10;
            this.txtMediaPrecoCompra.Name = "txtMediaPrecoCompra";
            this.txtMediaPrecoCompra.ReadOnly = true;
            this.txtMediaPrecoCompra.ShortcutsEnabled = false;
            this.txtMediaPrecoCompra.Size = new System.Drawing.Size(229, 30);
            this.txtMediaPrecoCompra.TabIndex = 53;
            // 
            // txtMediaPrecoVenda
            // 
            this.txtMediaPrecoVenda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMediaPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMediaPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMediaPrecoVenda.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtMediaPrecoVenda.Location = new System.Drawing.Point(545, 538);
            this.txtMediaPrecoVenda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMediaPrecoVenda.MaxLength = 10;
            this.txtMediaPrecoVenda.Name = "txtMediaPrecoVenda";
            this.txtMediaPrecoVenda.ReadOnly = true;
            this.txtMediaPrecoVenda.ShortcutsEnabled = false;
            this.txtMediaPrecoVenda.Size = new System.Drawing.Size(229, 30);
            this.txtMediaPrecoVenda.TabIndex = 55;
            // 
            // frm4Financas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(8)))), ((int)(((byte)(21)))));
            this.BackgroundImage = global::Projeto_TCC.Properties.Resources.Financas;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtMediaTotal);
            this.Controls.Add(this.txtMediaPrecoCompra);
            this.Controls.Add(this.txtMediaPrecoVenda);
            this.Controls.Add(this.txtLucroTotal);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.txtGanho);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm4Financas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm4Financas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm4Financas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtLucroTotal;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.TextBox txtGanho;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.TextBox txtMediaTotal;
        private System.Windows.Forms.TextBox txtMediaPrecoCompra;
        private System.Windows.Forms.TextBox txtMediaPrecoVenda;
    }
}