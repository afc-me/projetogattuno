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
    public partial class frm4Produtos : Form
    {
        #region Principais Variáveis e Funções

        // private void LimparTextBox()
        // private void Timer()
        // private void AdicionarLinhasDataGrid()
        // private void AtribuirDados_DGVtoTextBox()
        // private void AtribuirDados_BDtoTextBox()

        // private void ProCadastrar()
        // private void ProAlterar()

        private void LimparTextBox()
        {
            txtProduto.Clear();
            txtDesc.Clear();
            txtPrecoCompra.Clear();
            txtPrecoVenda.Clear();
            txtQtde.Clear();
        }

        private void Timer()
        {
            txtPrecoCompra.Text = txtPrecoCompra.Text.Replace(",", ".");
            txtPrecoVenda.Text = txtPrecoVenda.Text.Replace(",", ".");

            if (txtCod.Text == "")
            {
                LimparTextBox();

                btnPesquisarProduto.Enabled = false;
                btnExcluirProduto.Enabled = false;

                txtProduto.Enabled = false;
                txtDesc.Enabled = false;
                txtPrecoCompra.Enabled = false;
                txtPrecoVenda.Enabled = false;
                txtQtde.Enabled = false;
            }
            else
            {
                btnPesquisarProduto.Enabled = true;
                btnExcluirProduto.Enabled = true;

                txtProduto.Enabled = true;
                txtDesc.Enabled = true;
                txtPrecoCompra.Enabled = true;
                txtPrecoVenda.Enabled = true;
                txtQtde.Enabled = true;
            }

            if ((txtCod.Text != "") && (txtProduto.Text != "") && (txtDesc.Text != "")
                && (txtPrecoCompra.Text != "") && (txtPrecoVenda.Text != "") && (txtQtde.Text != ""))
            {
                btnCadastrarProduto.Enabled = true;
                btnAlterarProduto.Enabled = true;
            }
            else
            {
                btnCadastrarProduto.Enabled = false;
                btnAlterarProduto.Enabled = false;
            }
        }

        private void AdicionarLinhasDataGrid()
        {
            dgvProdutos.Rows.Add
                (
                Convert.ToInt32(Program.objDtReader["Codigo"].ToString()),
                Program.objDtReader["Produto"].ToString(),
                Program.objDtReader["Descricao"].ToString(),
                Convert.ToDecimal(string.Format("{0:0.00}", Program.objDtReader["PrecoCompra"]).ToString()),
                Convert.ToDecimal(string.Format("{0:0.00}", Program.objDtReader["PrecoVenda"]).ToString()),
                Convert.ToInt32(Program.objDtReader["Qtde"].ToString()),
                Convert.ToDecimal(string.Format("{0:0.00}", Program.objDtReader["Total"]).ToString())
                );
        }

        private void AtribuirDados_DGVtoTextBox()
        {
            try
            {
                txtCod.Text         = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
                txtProduto.Text     = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                txtDesc.Text        = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                txtPrecoCompra.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
                txtPrecoVenda.Text  = dgvProdutos.CurrentRow.Cells[4].Value.ToString();
                txtQtde.Text        = dgvProdutos.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                Program.MensagemDeErroCatch(ex);
            }
        }

        private void AtribuirDados_BDtoTextBox()
        {
            txtProduto.Text = Program.objDtReader["Produto"].ToString();
            txtDesc.Text = Program.objDtReader["Descricao"].ToString();
            txtPrecoCompra.Text = string.Format("{0:0.00}", Program.objDtReader["PrecoCompra"]).ToString();
            txtPrecoVenda.Text = string.Format("{0:0.00}", Program.objDtReader["PrecoVenda"]).ToString();
            txtQtde.Text = Program.objDtReader["Qtde"].ToString();
        }

        private void ProCadastrar()
        {
            if ((txtCod.Text != "") && (txtProduto.Text != "") && (txtDesc.Text != "")
                && (txtPrecoCompra.Text != "" && (txtPrecoVenda.Text != "") && (txtQtde.Text != "")))
            {
                string comandoBD = "Insert into " + Program.nomebdProd + " Values " +
                                   "(" +
                                   "'" + txtCod.Text + "', " +
                                   "'" + txtProduto.Text + "', " +
                                   "'" + txtDesc.Text + "', " +
                                   "'" + txtPrecoCompra.Text + "', " +
                                   "'" + txtPrecoVenda.Text + "', " +
                                   "'" + txtQtde.Text + "', " +
                                   "'" + (Convert.ToDouble(txtPrecoVenda.Text) * Convert.ToDouble(txtQtde.Text)) + "'" +
                                   ");";

                Program.BtnCadastrar(Convert.ToInt32(txtCod.Text), Program.nomebdProd, comandoBD);

                Program.CarregarDataGridView(dgvProdutos, Program.nomebdProd, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
            }
            else
            {
                Program.MensagemPreencherCampos();
            }
        }

        private void ProAlterar()
        {
            if ((txtCod.Text != "") && (txtProduto.Text != "") && (txtDesc.Text != "")
                && (txtPrecoCompra.Text != "") && (txtPrecoVenda.Text != "") && (txtQtde.Text != ""))
            {
                string comandoBD = "Update " + Program.nomebdProd + " set " +
                                   "Codigo=" + "'" + txtCod.Text + "', " +
                                   "Produto=" + "'" + txtProduto.Text + "', " +
                                   "Descricao=" + "'" + txtDesc.Text + "', " +
                                   "PrecoCompra=" + "'" + txtPrecoCompra.Text + "', " +
                                   "PrecoVenda=" + "'" + txtPrecoVenda.Text + "', " +
                                   "Qtde=" + "'" + txtQtde.Text + "', " +
                                   "Total=" + "'" + (Convert.ToDouble(txtPrecoVenda.Text) * Convert.ToDouble(txtQtde.Text)) + "' " +
                                   "where Codigo=" + "'" + txtCod.Text + "'";

                Program.BtnAlterar(txtCod, Program.nomebdProd, comandoBD);

                Program.CarregarDataGridView(dgvProdutos, Program.nomebdProd, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
            }
            else
            {
                Program.MensagemPreencherCampos();
            }
        }

        #endregion

        #region Método de Inicialização do Form

        public frm4Produtos()
        {
            InitializeComponent();
        }

        private void frm4Produtos_Load(object sender, EventArgs e)
        {
            Program.CarregarDataGridView(dgvProdutos, Program.nomebdProd, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
        }

        #endregion

        #region Botões

        // private void btnPesquisarProduto_Click   
        // private void btnCadastrarProduto_Click   
        // private void btnAlterarProduto_Click     
        // private void btnExcluirProduto_Click     
        // private void btnLimpar_Click             
        // private void btnVoltar_Click             

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            Program.BtnPesquisar(txtCod, Program.nomebdProd, AtribuirDados_BDtoTextBox, LimparTextBox);
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            ProCadastrar();
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            ProAlterar();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            Program.BtnExcluir(txtCod, Program.nomebdProd, LimparTextBox);

            Program.CarregarDataGridView(dgvProdutos, Program.nomebdProd, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTextBox();

            txtCod.Clear();
            txtCod.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region DataGridView e Timer

        // dgvPedido_SelectionChanged
        // timer1_Tick

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            AtribuirDados_DGVtoTextBox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer();
        }

        #endregion

        #region Eventos KeyDown e KeyPress

        // private void txtCodigo_KeyDown       

        // private void KeyPress_Num              
        // private void KeyPress_NumLetraEspaco         
        // private void KeyPress_NumPonto         

        public void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Program.BtnPesquisar(txtCod, Program.nomebdProd, AtribuirDados_BDtoTextBox, LimparTextBox);
            }

            if (e.KeyCode == Keys.Space)
            {
                LimparTextBox();

                txtCod.Text = (Program.GerarNumeroAleatorio(1, 99999999, Program.nomebdProd)).ToString();
            }
        }

        private void KeyPress_Num(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_Num(sender, e);
        }

        private void KeyPress_NumLetraEspaco(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_NumLetraEspaco(sender, e);
        }

        private void KeyPress_NumPonto(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_NumPonto(sender, e);
        }

        #endregion
    }
}
