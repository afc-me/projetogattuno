namespace Projeto_TCC
{
    partial class frm2Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2Cadastro));
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNResid = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFunc.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFunc.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnCadastrarFunc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCadastrarFunc.Location = new System.Drawing.Point(821, 632);
            this.btnCadastrarFunc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(140, 33);
            this.btnCadastrarFunc.TabIndex = 10;
            this.btnCadastrarFunc.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.btnCadastrarFunc, "Realiza o cadastro dos dados especificados na tabela de funcionários.\r\n\r\nTodos os" +
        " campos devem ser preenchidos primeiro.");
            this.btnCadastrarFunc.UseVisualStyleBackColor = false;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVoltar.Location = new System.Drawing.Point(1047, 632);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 33);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btnVoltar, "Retorna à tela anterior.");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtSenha2
            // 
            this.txtSenha2.BackColor = System.Drawing.Color.White;
            this.txtSenha2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtSenha2.ForeColor = System.Drawing.Color.Black;
            this.txtSenha2.Location = new System.Drawing.Point(873, 500);
            this.txtSenha2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSenha2.MaxLength = 32;
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.ShortcutsEnabled = false;
            this.txtSenha2.Size = new System.Drawing.Size(254, 30);
            this.txtSenha2.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtSenha2, "Digite sua senha novamente.");
            // 
            // txtSenha1
            // 
            this.txtSenha1.BackColor = System.Drawing.Color.White;
            this.txtSenha1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtSenha1.ForeColor = System.Drawing.Color.Black;
            this.txtSenha1.Location = new System.Drawing.Point(873, 396);
            this.txtSenha1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSenha1.MaxLength = 32;
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.PasswordChar = '*';
            this.txtSenha1.ShortcutsEnabled = false;
            this.txtSenha1.Size = new System.Drawing.Size(254, 30);
            this.txtSenha1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtSenha1, "Digite sua senha.");
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(873, 293);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUsuario.MaxLength = 45;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(254, 30);
            this.txtUsuario.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtUsuario, "Nome virtual do funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n  -" +
        " Letras (A, B, C...);");
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
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(90, 402);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmail.MaxLength = 64;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(254, 30);
            this.txtEmail.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtEmail, "E-mail do funcionário disponível para contato.\r\n\r\nSão permitidos apenas:\r\n  - Núm" +
        "eros (0 - 9);\r\n  - Letras (A, B, C...);\r\n  - Arrobas ( @ );\r\n  - Pontos ( . );\r\n" +
        "  - Hífens ( - );");
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Email);
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(90, 500);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ShortcutsEnabled = false;
            this.txtCPF.Size = new System.Drawing.Size(254, 30);
            this.txtCPF.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtCPF, "CPF do funcionário (11 dígitos).\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);");
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Num);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(438, 402);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEndereco.MaxLength = 45;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.ShortcutsEnabled = false;
            this.txtEndereco.Size = new System.Drawing.Size(254, 30);
            this.txtEndereco.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtEndereco, "Endereço (rua, praça, quadra, beco, etc.) do funcionário.\r\n\r\nSão permitidos apena" +
        "s:\r\n  - Números (0 - 9);\r\n  - Letras (A, B, C...);\r\n  - Espaços (   );");
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_NumLetraEspaco);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(90, 306);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ShortcutsEnabled = false;
            this.txtNome.Size = new System.Drawing.Size(254, 30);
            this.txtNome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNome, "Nome do funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Letras (A, B, C...);");
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_NumLetraEspaco);
            // 
            // txtNResid
            // 
            this.txtNResid.BackColor = System.Drawing.Color.White;
            this.txtNResid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNResid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNResid.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtNResid.ForeColor = System.Drawing.Color.Black;
            this.txtNResid.Location = new System.Drawing.Point(637, 500);
            this.txtNResid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNResid.MaxLength = 6;
            this.txtNResid.Name = "txtNResid";
            this.txtNResid.ShortcutsEnabled = false;
            this.txtNResid.Size = new System.Drawing.Size(55, 30);
            this.txtNResid.TabIndex = 6;
            this.txtNResid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtNResid, "Número da residência do funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - " +
        "9);");
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.White;
            this.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCEP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtCEP.ForeColor = System.Drawing.Color.Black;
            this.txtCEP.Location = new System.Drawing.Point(438, 306);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCEP.MaxLength = 8;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.ShortcutsEnabled = false;
            this.txtCEP.Size = new System.Drawing.Size(254, 30);
            this.txtCEP.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtCEP, resources.GetString("txtCEP.ToolTip"));
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Num);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone.Location = new System.Drawing.Point(90, 598);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTelefone.MaxLength = 10;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ShortcutsEnabled = false;
            this.txtTelefone.Size = new System.Drawing.Size(254, 30);
            this.txtTelefone.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtTelefone, "Telefone fixo do funcionário (10 dígitos);\r\n\r\nSão permitidos apenas:\r\n  - Números" +
        " (0 - 9);");
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Num);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.Location = new System.Drawing.Point(438, 598);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCidade.MaxLength = 45;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.ShortcutsEnabled = false;
            this.txtCidade.Size = new System.Drawing.Size(161, 30);
            this.txtCidade.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtCidade, "Cidade onde mora o funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n" +
        "  - Letras (A, B, C...);\r\n  - Espaços (   );");
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_NumLetraEspaco);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(438, 500);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBairro.MaxLength = 45;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.ShortcutsEnabled = false;
            this.txtBairro.Size = new System.Drawing.Size(161, 30);
            this.txtBairro.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtBairro, "Bairro onde mora o funcionário.\r\n\r\nSão permitidos apenas:\r\n  - Números (0 - 9);\r\n" +
        "  - Letras (A, B, C...);\r\n  - Espaços (   );");
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_NumLetraEspaco);
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.Location = new System.Drawing.Point(637, 598);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.ShortcutsEnabled = false;
            this.txtEstado.Size = new System.Drawing.Size(55, 30);
            this.txtEstado.TabIndex = 15;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtEstado, "Estado onde reside o funcionário (2 Letras).\r\n\r\nSão permitidos apenas:\r\n - Letras" +
        " (A - Z);");
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Letra);
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm2Cadastro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::Projeto_TCC.Properties.Resources.Cadastro21;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnCadastrarFunc);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNResid);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm2Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.toolTip1.SetToolTip(this, "Bem-vindo à tela de cadastro!\r\n\r\nSomente funcionários cadastrados aqui terão aces" +
        "so \r\nao programa.\r\n\r\nPreencha todos os campos para habilitar o cadastro.");
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNResid;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Timer timer1;
    }
}