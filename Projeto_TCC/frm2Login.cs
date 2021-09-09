using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC
{
    public partial class frm2Login : Form
    {
        #region Principais Variáveis e Funções

        // private void Login()                                         

        private void Login()
        {
            lblConfirmar.Text = "";
            int aux = 0, cod = 0;

            if ((txtUsuario.Text != "") && (txtSenha.Text != ""))
            {
                try
                {
                    Program.ExecutarComandoBD("Select Codigo from " + Program.nomebdLogin + " where Usuario='" + txtUsuario.Text + "' and Senha='" + txtSenha.Text + "';");

                    if (Program.objDtReader.HasRows == false)
                    {
                        aux = 1;

                        lblConfirmar.Text = "O usuário não foi encontrado...";

                        txtUsuario.Clear();
                        txtSenha.Clear();

                        txtUsuario.Focus();
                    }
                    else
                    {
                        while (Program.objDtReader.Read())
                        {
                            cod = Convert.ToInt32(Program.objDtReader["Codigo"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Program.MensagemDeErroCatch(ex);
                }

                Program.FinalizarComandoBD();

                if (aux != 1)
                {
                    try
                    {
                        Program.ExecutarComandoBD("Select Funcao from " + Program.nomebdFunc + " where Codigo=" + cod + ";");

                        while (Program.objDtReader.Read())
                        {
                            if (Program.objDtReader["Funcao"].ToString() == "ADMINISTRADOR")
                            {
                                Hide();
                                var frm3Administrador = new frm3Administrador();
                                frm3Administrador.Closed += (s, args) => Close();
                                frm3Administrador.Show();
                            }
                            else
                            {
                                Hide();
                                var frm3Funcionario = new frm3Funcionario();
                                frm3Funcionario.Closed += (s, args) => Close();
                                frm3Funcionario.Show();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Program.MensagemDeErroCatch(ex);
                    }

                    Program.FinalizarComandoBD();
                }
            }
            else
            {
                if ((txtUsuario.Text == "") && (txtSenha.Text != ""))
                {
                    lblConfirmar.Text = "Informe o nome de usuário!";
                    txtUsuario.Focus();
                }
                else if ((txtUsuario.Text != "") && (txtSenha.Text == ""))
                {
                    lblConfirmar.Text = "Informe a senha!";
                    txtSenha.Focus();
                }
                else if ((txtUsuario.Text == "") && (txtSenha.Text == ""))
                {
                    lblConfirmar.Text = "Informe usuário e senha!";
                    txtUsuario.Focus();
                }
            }
        }

        #endregion

        #region Método de Inicialização do Form

        public frm2Login()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botões

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Program.BtnSair();          
        }

        #endregion

        #region Eventos KeyDown e FormClosed

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void frm2Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FormClosing(sender, e);
        }

        #endregion
    }
}
