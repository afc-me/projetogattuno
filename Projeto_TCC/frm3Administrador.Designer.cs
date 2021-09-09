namespace Projeto_TCC
{
    partial class frm3Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3Administrador));
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinancas = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.White;
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnPedidos.Location = new System.Drawing.Point(587, 284);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(140, 33);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.White;
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnProdutos.Location = new System.Drawing.Point(587, 364);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(140, 33);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.White;
            this.btnFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnFunc.Location = new System.Drawing.Point(587, 450);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(140, 33);
            this.btnFunc.TabIndex = 3;
            this.btnFunc.Text = "Funcionários";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnSair.Location = new System.Drawing.Point(690, 620);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(140, 33);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFinancas
            // 
            this.btnFinancas.BackColor = System.Drawing.Color.White;
            this.btnFinancas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinancas.FlatAppearance.BorderSize = 0;
            this.btnFinancas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancas.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnFinancas.Location = new System.Drawing.Point(587, 530);
            this.btnFinancas.Name = "btnFinancas";
            this.btnFinancas.Size = new System.Drawing.Size(140, 33);
            this.btnFinancas.TabIndex = 4;
            this.btnFinancas.Text = "Finanças";
            this.btnFinancas.UseVisualStyleBackColor = false;
            this.btnFinancas.Click += new System.EventHandler(this.btnFinancas_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnVoltar.Location = new System.Drawing.Point(485, 620);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 33);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frm3Administrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Projeto_TCC.Properties.Resources.Admin;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFinancas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm3Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Acesso (Administrador)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm3Administrador_FormClosing);
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinancas;
        private System.Windows.Forms.Button btnVoltar;
    }
}