namespace Projeto_TCC
{
    partial class frm4Cozinheiros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4Cozinheiros));
            this.dgvCozinha = new System.Windows.Forms.DataGridView();
            this.clmCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPróximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCozinha)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCozinha
            // 
            this.dgvCozinha.AllowUserToAddRows = false;
            this.dgvCozinha.AllowUserToDeleteRows = false;
            this.dgvCozinha.AllowUserToOrderColumns = true;
            this.dgvCozinha.AllowUserToResizeColumns = false;
            this.dgvCozinha.AllowUserToResizeRows = false;
            this.dgvCozinha.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvCozinha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCozinha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCod,
            this.clmMesa,
            this.clmPrato,
            this.clmDetalhes});
            this.dgvCozinha.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCozinha.Location = new System.Drawing.Point(252, 250);
            this.dgvCozinha.MultiSelect = false;
            this.dgvCozinha.Name = "dgvCozinha";
            this.dgvCozinha.ReadOnly = true;
            this.dgvCozinha.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            this.dgvCozinha.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCozinha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCozinha.Size = new System.Drawing.Size(784, 239);
            this.dgvCozinha.TabIndex = 23;
            this.dgvCozinha.TabStop = false;
            // 
            // clmCod
            // 
            this.clmCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCod.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCod.HeaderText = "Cod";
            this.clmCod.Name = "clmCod";
            this.clmCod.ReadOnly = true;
            this.clmCod.Width = 59;
            // 
            // clmMesa
            // 
            this.clmMesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmMesa.HeaderText = "Mesa";
            this.clmMesa.MinimumWidth = 100;
            this.clmMesa.Name = "clmMesa";
            this.clmMesa.ReadOnly = true;
            // 
            // clmPrato
            // 
            this.clmPrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmPrato.HeaderText = "Prato";
            this.clmPrato.MinimumWidth = 150;
            this.clmPrato.Name = "clmPrato";
            this.clmPrato.ReadOnly = true;
            this.clmPrato.Width = 150;
            // 
            // clmDetalhes
            // 
            this.clmDetalhes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDetalhes.HeaderText = "Detalhes";
            this.clmDetalhes.MinimumWidth = 415;
            this.clmDetalhes.Name = "clmDetalhes";
            this.clmDetalhes.ReadOnly = true;
            this.clmDetalhes.Width = 415;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVoltar.Location = new System.Drawing.Point(600, 615);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 33);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPróximo
            // 
            this.btnPróximo.BackColor = System.Drawing.Color.White;
            this.btnPróximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPróximo.FlatAppearance.BorderSize = 0;
            this.btnPróximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPróximo.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPróximo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPróximo.Location = new System.Drawing.Point(551, 525);
            this.btnPróximo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPróximo.Name = "btnPróximo";
            this.btnPróximo.Size = new System.Drawing.Size(241, 47);
            this.btnPróximo.TabIndex = 21;
            this.btnPróximo.Text = "Próximo Pedido";
            this.btnPróximo.UseVisualStyleBackColor = false;
            this.btnPróximo.Click += new System.EventHandler(this.btnPróximo_Click);
            // 
            // frm4Cozinheiros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::Projeto_TCC.Properties.Resources.Cozinha;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.dgvCozinha);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPróximo);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm4Cozinheiros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Cozinha (Em andamento)";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm4Cozinheiros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCozinha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCozinha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPróximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetalhes;
    }
}