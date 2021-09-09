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
    public partial class frm2Cadastro : Form
    {
        #region Principais Variáveis e Funções

        // private void Cadastrar()
        // private void Timer()

        private void Cadastrar()
        {
            if ((txtNome.Text != "") && (txtCPF.Text != "")  && (txtCEP.Text != "") && (txtNResid.Text != "") 
                && (txtEndereco.Text != "") && (txtBairro.Text != "")  && (txtCidade.Text != "") 
                && (txtEstado.Text != "")  && (txtTelefone.Text != "")  && (txtEmail.Text != "")  
                && (txtUsuario.Text != "") && (txtSenha1.Text != "") && (txtSenha2.Text != ""))
            {
                if (txtSenha1.Text != txtSenha2.Text)
                {
                    MessageBox.Show("Senhas incompatíveis!",
                                    " *** CADASTRO *** ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else if (Program.ValidarCPF(txtCPF.Text) == false)
                {
                    MessageBox.Show("O CPF digitado é inválido! \n\n" +
                                    "Digite outro CPF e tente novamente...",
                                    " *** VALIDAÇÃO DE DADOS *** ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    int codLogFunc = Program.GerarNumeroAleatorio(1, 99999999, Program.nomebdFunc);

                    string comandoBD = "Insert into " + Program.nomebdFunc + " Values " +
                                        "(" +
                                        "'" + codLogFunc.ToString() + "', " +
                                        "'" + txtNome.Text + "', " +
                                        "'" + "FUNCIONARIO" + "', " +
                                        "'" + string.Format(@"{0:000\.000\.000\-00}", Convert.ToInt64(txtCPF.Text)) + "', " +
                                        "'" + string.Format(@"{0:00000\-000}", Convert.ToInt64(txtCEP.Text)) + "', " +
                                        "'" + txtNResid.Text + "', " +
                                        "'" + txtEndereco.Text + "', " +
                                        "'" + txtBairro.Text + "', " +
                                        "'" + txtCidade.Text + "', " +
                                        "'" + txtEstado.Text + "', " +
                                        "'" + string.Format(@"{0:\(00\)0000\-0000}", Convert.ToInt64(txtTelefone.Text)) + "', " +
                                        "'" + txtEmail.Text + "'" +
                                        ");";

                    Program.BtnCadastrar(codLogFunc, Program.nomebdFunc, comandoBD);

                    comandoBD = "Insert into " + Program.nomebdLogin + " Values " +
                                 "(" +
                                 "'" + codLogFunc.ToString() + "', " +
                                 "'" + txtUsuario.Text  + "', " +
                                 "'" + txtSenha1.Text   + "'" +
                                 ");";

                    Program.BtnCadastrar(codLogFunc, Program.nomebdLogin, comandoBD);
                }
            }
            else
            {
                Program.MensagemPreencherCampos();
            }
        }

        private void Timer()
        {
            if ((txtNome.Text != "") && (txtCPF.Text != "") && (txtCEP.Text != "") && (txtNResid.Text != "")
                && (txtEndereco.Text != "") && (txtBairro.Text != "") && (txtCidade.Text != "")
                && (txtEstado.Text != "") && (txtTelefone.Text != "") && (txtEmail.Text != "")
                && (txtUsuario.Text != "") && (txtSenha1.Text != "") && (txtSenha2.Text != ""))
            {
                btnCadastrarFunc.Enabled = true;
            }
            else
            {
                btnCadastrarFunc.Enabled = false;
            }
        }

        #endregion

        #region Método de Inicialização do Form

        public frm2Cadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        { 

        }

        #endregion

        #region Botões e Timer

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer();
        }

        #endregion

        #region Eventos Leave e KeyPress

        // private void txtCEP_Leave
        // private void txtCPF_Leave
        // private void txtTelefone_Leave
        // private void txtEstado_Leave

        // private void KeyPress_Letra
        // private void KeyPress_Num
        // private void KeyPress_NumLetraEspaco
        // private void KeyPress_Email

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (txtCEP.Text != "")
            {
                if (txtCEP.TextLength < 8)
                {
                    MessageBox.Show("O número do CEP é composto por 8 dígitos.",
                                    " *** AVISO *** ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);

                    txtCEP.Focus();
                }
                else
                {
                    string CEP = Program.BuscarCEP(txtCEP).Replace("\"", "").Replace(",", "").ToUpper();

                    // "{  CEP: 04068 - 030  LOGRADOURO: RUA TAPIXINGUI  COMPLEMENTO:   BAIRRO: PLANALTO PAULISTA
                    // LOCALIDADE: SÃO PAULO  UF: SP  UNIDADE:   IBGE: 3550308  GIA: 1004}"

                    txtEndereco.Text = Program.GetIntervaloDeTexto(CEP, "LOGRADOURO: ", "  COMPLEMENTO");
                    txtBairro.Text = Program.GetIntervaloDeTexto(CEP, "BAIRRO: ", "  LOCALIDADE");
                    txtCidade.Text = Program.GetIntervaloDeTexto(CEP, "LOCALIDADE: ", "  UF");
                    txtEstado.Text = Program.GetIntervaloDeTexto(CEP, "UF: ", "  UNIDADE");

                    if ((txtEndereco.Text == "") && (txtBairro.Text == "") && (txtCidade.Text == "") && (txtEstado.Text == ""))
                    {
                        if (MessageBox.Show("O CEP digitado não foi encontrado. \n\n" +
                                            "Confira o número do CEP fornecido e responda: \n\n" +
                                            "Este número está correto? \n\n" +
                                            "- Se sim, deverá preencher os campos manualmente; \n" +
                                            "- Se não, deverá digitar o CEP corretamente;",
                                            " *** PESQUISA AUTOMÁTICA DO CEP *** ",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            txtCEP.Enabled = false;

                            txtEndereco.ReadOnly = false;
                            txtBairro.ReadOnly = false;
                            txtCidade.ReadOnly = false;
                            txtEstado.ReadOnly = false;

                            txtEndereco.BackColor = Color.White;
                            txtBairro.BackColor = Color.White;
                            txtCidade.BackColor = Color.White;
                            txtEstado.BackColor = Color.White;
                        }
                        else
                        {
                            txtCEP.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CEP localizado com sucesso!",
                                        " *** PESQUISA AUTOMÁTICA DO CEP *** ",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        txtEndereco.ReadOnly = true;
                        txtBairro.ReadOnly = true;
                        txtCidade.ReadOnly = true;
                        txtEstado.ReadOnly = true;

                        txtEndereco.BackColor = Color.Gainsboro;
                        txtBairro.BackColor = Color.Gainsboro;
                        txtCidade.BackColor = Color.Gainsboro;
                        txtEstado.BackColor = Color.Gainsboro;

                        txtCEP.Enabled = false;
                    }
                }
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if ((txtCPF.TextLength < 11) && (txtCPF.Text != ""))
            {
                MessageBox.Show("O número do CPF é composto por 11 dígitos.",
                                " *** AVISO *** ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txtCPF.Focus();
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if ((txtTelefone.TextLength < 10) && (txtTelefone.Text != ""))
            {
                MessageBox.Show("O número do telefone fixo é composto por 10 dígitos: \n\n" +
                                "- 2 dígitos para o DDD; \n" +
                                "- 8 dígitos para o número;",
                                " *** AVISO *** ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txtTelefone.Focus();
            }
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            if (txtEstado.TextLength == 1)
            {
                MessageBox.Show("A sigla do estado é formada por 2 letras.",
                                " *** AVISO *** ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txtEstado.Focus();
            }
        }

        private void KeyPress_Letra(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_Letra(sender, e);
        }

        private void KeyPress_Num(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_Num(sender, e);
        }

        private void KeyPress_NumLetraEspaco(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_NumLetraEspaco(sender, e);
        }

        private void KeyPress_Email(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_Email(sender, e);
        }

        #endregion
    }
}
