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
    public partial class frm4Funcionarios : Form
    {
        #region Principais Variáveis e Funções

        // private void LimparTextBox()
        // private void Timer()
        // private void AdicionarLinhasDataGrid()
        // private void AtribuirDados_DGVtoTextBox()
        // private void AtribuirDados_BDtoTextBox()

        // private void FuncAlterar()

        private void LimparTextBox()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNResid.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEstado.Clear();

            cbxFuncao.SelectedItem = null;
        }

        private void Timer()
        {
            if (txtCod.Text == "")
            {
                LimparTextBox();
            }

            if (txtCod.Text == "")
            {
                LimparTextBox();

                btnPesquisarFunc.Enabled = false;
                btnAlterarFunc.Enabled   = false;
                btnExcluirFunc.Enabled   = false;
                
                txtNome.Enabled     = false;
                txtCPF.Enabled      = false;
                txtNResid.Enabled   = false;
                txtTelefone.Enabled = false;
                txtCEP.Enabled      = false;
                txtEndereco.Enabled = false;
                txtBairro.Enabled   = false;
                txtCidade.Enabled   = false;
                txtEstado.Enabled   = false;
                txtEmail.Enabled    = false;
                cbxFuncao.Enabled   = false;
            }
            else
            {
                btnPesquisarFunc.Enabled = true;
                btnAlterarFunc.Enabled   = true;
                btnExcluirFunc.Enabled   = true;

                txtNome.Enabled     = true;
                txtCPF.Enabled      = true;
                txtNResid.Enabled   = true;
                txtTelefone.Enabled = true;
                txtCEP.Enabled      = true;
                txtEndereco.Enabled = true;
                txtBairro.Enabled   = true;
                txtCidade.Enabled   = true;
                txtEstado.Enabled   = true;
                txtEmail.Enabled    = true;
                cbxFuncao.Enabled   = true;
            }
        }

        private void AdicionarLinhasDataGrid()
        {
            dgvFunc.Rows.Add
                (
                Convert.ToInt32(Program.objDtReader["Codigo"].ToString()),
                Program.objDtReader["Nome"].ToString(),
                Program.objDtReader["Funcao"].ToString(),
                Program.objDtReader["CPF"].ToString(),
                Program.objDtReader["CEP"].ToString(),
                Convert.ToInt32(Program.objDtReader["NResid"].ToString()),
                Program.objDtReader["Endereco"].ToString(),
                Program.objDtReader["Bairro"].ToString(),
                Program.objDtReader["Cidade"].ToString(),
                Program.objDtReader["Estado"].ToString(),
                Program.objDtReader["Telefone"].ToString(),
                Program.objDtReader["Email"].ToString()
                );
        }

        private void AtribuirDados_DGVtoTextBox()
        {
            try
            {
                txtCod.Text      = dgvFunc.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text     = dgvFunc.CurrentRow.Cells[1].Value.ToString();
                cbxFuncao.Text   = dgvFunc.CurrentRow.Cells[2].Value.ToString();
                txtCPF.Text      = dgvFunc.CurrentRow.Cells[3].Value.ToString();
                txtCEP.Text      = dgvFunc.CurrentRow.Cells[4].Value.ToString();
                txtNResid.Text   = dgvFunc.CurrentRow.Cells[5].Value.ToString();
                txtEndereco.Text = dgvFunc.CurrentRow.Cells[6].Value.ToString();
                txtBairro.Text   = dgvFunc.CurrentRow.Cells[7].Value.ToString();
                txtCidade.Text   = dgvFunc.CurrentRow.Cells[8].Value.ToString();
                txtEstado.Text   = dgvFunc.CurrentRow.Cells[9].Value.ToString();
                txtTelefone.Text = dgvFunc.CurrentRow.Cells[10].Value.ToString();
                txtEmail.Text    = dgvFunc.CurrentRow.Cells[11].Value.ToString();
            }
            catch (Exception ex)
            {
                Program.MensagemDeErroCatch(ex);
            }
        }

        private void AtribuirDados_BDtoTextBox()
        {
            txtNome.Text     = Program.objDtReader["Nome"].ToString();
            txtCPF.Text      = Program.objDtReader["CPF"].ToString();
            cbxFuncao.Text   = Program.objDtReader["Funcao"].ToString();
            txtCEP.Text      = Program.objDtReader["CEP"].ToString();
            txtEndereco.Text = Program.objDtReader["Endereco"].ToString();
            txtBairro.Text   = Program.objDtReader["Bairro"].ToString();
            txtCidade.Text   = Program.objDtReader["Cidade"].ToString();
            txtEstado.Text   = Program.objDtReader["Estado"].ToString();
            txtNResid.Text   = Program.objDtReader["NResid"].ToString();
            txtTelefone.Text = Program.objDtReader["Telefone"].ToString();
            txtEmail.Text    = Program.objDtReader["Email"].ToString();
        }

        private void FuncAlterar()
        {
            if ((txtCod.Text != "") && (txtNome.Text != "") && (cbxFuncao.Text != ""))
            {
                string comandoBD = "Update " + Program.nomebdFunc + " set " +
                                   "Funcao=" + "'" + cbxFuncao.Text + "' " +
                                   "where Codigo=" + "'" + txtCod.Text + "'";

                Program.BtnAlterar(txtCod, Program.nomebdFunc, comandoBD);

                Program.CarregarDataGridView(dgvFunc, Program.nomebdFunc, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
            }
            else
            {
                Program.MensagemPreencherCampos();
            }
        }

        #endregion

        #region Método de Inicialização do Form

        public frm4Funcionarios()
        {
            InitializeComponent();
        }

        private void frm4Funcionarios_Load(object sender, EventArgs e)
        {
            Program.CarregarDataGridView(dgvFunc, Program.nomebdFunc, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
        }

        #endregion

        #region Botões

        // private void btnPesquisarFunc_Click   
        // private void btnAlterarFunc_Click     
        // private void btnExcluirFunc_Click     
        // private void btnLimpar_Click          
        // private void btnVoltar_Click          

        private void btnPesquisarFunc_Click(object sender, EventArgs e)
        {
            Program.BtnPesquisar(txtCod, Program.nomebdFunc, AtribuirDados_BDtoTextBox, LimparTextBox);
        }

        private void btnAlterarFunc_Click(object sender, EventArgs e)
        {
            FuncAlterar();
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            Program.BtnExcluir(txtCod, Program.nomebdFunc, LimparTextBox);

            Program.BtnExcluir(txtCod, Program.nomebdLogin, LimparTextBox);

            Program.CarregarDataGridView(dgvFunc, Program.nomebdFunc, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region DataGridView e Timer

        // dgvPedido_SelectionChanged
        // timer1_Tick

        private void dgvFunc_SelectionChanged(object sender, EventArgs e)
        {
            AtribuirDados_DGVtoTextBox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer();
        }

        #endregion

        #region Eventos KeyDown e KeyPress

        // private void txtCod_KeyDown        

        // private void KeyPress_Num                  

        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Program.BtnPesquisar(txtCod, Program.nomebdFunc, AtribuirDados_BDtoTextBox, LimparTextBox);
            }
        }

        private void KeyPress_Num(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_Num(sender, e);
        }


        #endregion
    }
}
