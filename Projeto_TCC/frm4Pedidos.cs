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
    public partial class frm4Pedidos : Form
    {
        #region Principais Variáveis e Funções

        // private void LimparTextBox()
        // private void Timer()
        // private void AdicionarLinhasDataGrid()
        // private void AtribuirDados_DGVtoTextBox()
        // private void AtribuirDados_BDtoTextBox()

        // private void PedCadastrar()
        // private void PedAlterar()

        private void LimparTextBox()
        {
            txtData.Clear();
            txtHora.Clear();
            txtNome.Clear();
        }

        private void Timer()
        {
            if (txtCod.Text == "")
            {
                LimparTextBox();

                btnPesquisar.Enabled = false;
                btnExcluir.Enabled = false;

                txtData.Enabled  = false;
                txtHora.Enabled  = false;
                txtNome.Enabled  = false;
            }
            else
            {
                btnPesquisar.Enabled = true;
                btnExcluir.Enabled = true;

                txtData.Enabled  = true;
                txtHora.Enabled  = true;
                txtNome.Enabled  = true;
            }

            if (((txtCod.Text != "") && (txtNome.Text != "")) == false)
            {
                btnIncluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
            else
            {
                btnIncluir.Enabled = true;
                btnAlterar.Enabled = true;
            }
        }

        private void AdicionarLinhasDataGrid()
        {
            dgvPedido.Rows.Add
                (
                Convert.ToInt32(Program.objDtReader["Codigo"].ToString()),
                Convert.ToDateTime(Program.objDtReader["Data"].ToString()),
                Convert.ToDateTime(Program.objDtReader["Hora"].ToString()).ToShortTimeString(),
                Program.objDtReader["NomeCli"].ToString()
                );
        }

        private void AtribuirDados_DGVtoTextBox()
        {
            try
            {
                txtCod.Text = dgvPedido.CurrentRow.Cells[0].Value.ToString();
                txtData.Text = Convert.ToDateTime(dgvPedido.CurrentRow.Cells[1].Value).ToShortDateString();
                txtHora.Text = Convert.ToDateTime(dgvPedido.CurrentRow.Cells[2].Value).ToShortTimeString();
                txtNome.Text = dgvPedido.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                Program.MensagemDeErroCatch(ex);
            }
        }

        private void AtribuirDados_BDtoTextBox()
        {
            txtData.Text = Program.objDtReader["Data"].ToString();
            txtHora.Text = Program.objDtReader["Hora"].ToString();
            txtNome.Text = Program.objDtReader["NomeCli"].ToString();
        }

        private void PedCadastrar()
        {
            if ((txtCod.Text != "") && (txtNome.Text != ""))
            {
                txtData.Text = DateTime.Today.ToString("dd/MM/yyyy");
                txtHora.Text = DateTime.Now.ToString("HH:mm");

                string comandoBD = "Insert into " + Program.nomebdPed + " Values " +
                                   "(" +
                                   "'" + txtCod.Text + "', " +
                                   "'" + txtData.Text + "', " +
                                   "'" + txtHora.Text + "', " +
                                   "'" + txtNome.Text + "'" +
                                   ");";

                Program.BtnCadastrar(Convert.ToInt32(txtCod.Text), Program.nomebdPed, comandoBD);

                Program.CarregarDataGridView(dgvPedido, Program.nomebdPed, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
            }
            else
            {
                Program.MensagemPreencherCampos();
            }
        }

        private void PedAlterar()
        {
            if ((txtCod.Text != "") && (txtNome.Text != ""))
            {
                string comandoBD = "Update " + Program.nomebdPed + " set " +
                                   "Codigo="   + "'" + txtCod.Text     + "', " +
                                   "Data="     + "'" + txtData.Text          + "', " +
                                   "Hora="     + "'" + txtHora.Text          + "', " +
                                   "NomeCli="  + "'" + txtNome.Text          + "' " +
                                   "where Codigo=" + "'" + txtCod.Text + "'";

                Program.BtnAlterar(txtCod, Program.nomebdPed, comandoBD);

                Program.CarregarDataGridView(dgvPedido, Program.nomebdPed, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
            }
            else
            {
                Program.MensagemPreencherCampos();
            }
        }

        #endregion

        #region Método de Inicialização do Form

        public frm4Pedidos()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            Program.CarregarDataGridView(dgvPedido, Program.nomebdPed, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
        }

        #endregion

        #region Botões

        // private void btnPesquisar_Click           
        // private void btnIncluir_Click             
        // private void btnAlterar_Click             
        // private void btnExcluir_Click             
        // private void btnLimpar_Click                
        // private void btnVoltar_Click              

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Program.BtnPesquisar(txtCod, Program.nomebdPed, AtribuirDados_BDtoTextBox, LimparTextBox);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            PedCadastrar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            PedAlterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Program.BtnExcluir(txtCod, Program.nomebdPed, LimparTextBox);

            Program.CarregarDataGridView(dgvPedido, Program.nomebdPed, AdicionarLinhasDataGrid, LimparTextBox, txtCod);
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

        // dgvPedido_CellClick
        // dgvPedido_SelectionChanged
        // timer1_Tick

        private void dgvPedido_SelectionChanged(object sender, EventArgs e)
        {
            AtribuirDados_DGVtoTextBox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer();
        }

        #endregion

        #region Eventos KeyDown e KeyPress

        // private void txtCodPedido_KeyDown        

        // private void KeyPress_Num             
        // private void KeyPress_LetraEspaco           

        private void txtCodPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Program.BtnPesquisar(txtCod, Program.nomebdPed, AtribuirDados_BDtoTextBox, LimparTextBox);
            }

            if (e.KeyCode == Keys.Space)
            {
                LimparTextBox();

                txtCod.Text = (Program.GerarNumeroAleatorio(1, 99999999, Program.nomebdPed)).ToString();
            }
        }

        private void KeyPress_Num(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_Num(sender, e);
        }

        private void KeyPress_LetraEspaco(object sender, KeyPressEventArgs e)
        {
            Program.KeyPress_LetraEspaco(sender, e);

        }

        #endregion
    }
}
