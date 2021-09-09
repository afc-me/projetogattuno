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
    public partial class frm4Financas : Form
    {
        private void LimparTextBox()
        {
            // Não há campos para limpar...
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

        public frm4Financas()
        {
            InitializeComponent();
        }

        private void frm4Financas_Load(object sender, EventArgs e)
        {
            decimal gasto = 0, ganho = 0;

            Program.CarregarDataGridView(dgvProdutos, Program.nomebdProd, AdicionarLinhasDataGrid, LimparTextBox, txtGanho);

            Program.ExecutarComandoBD("Select sum(all PrecoCompra * Qtde) from " + Program.nomebdProd + ";");

            while (Program.objDtReader.Read())
            {
                gasto = Convert.ToDecimal(Program.objDtReader["sum(all PrecoCompra * Qtde)"].ToString());
                txtGasto.Text = "Gasto: R$ " + (Convert.ToDecimal(string.Format("{0:0.00}", Program.objDtReader["sum(all PrecoCompra * Qtde)"])));
            }

            Program.FinalizarComandoBD();

            Program.ExecutarComandoBD("Select Sum(all Total) from " + Program.nomebdProd + ";");

            while (Program.objDtReader.Read())
            {
                ganho = Convert.ToDecimal(Program.objDtReader["Sum(all Total)"].ToString());
                txtGanho.Text = "Ganho: R$ " + (Convert.ToDecimal(string.Format("{0:0.00}", Program.objDtReader["Sum(all Total)"])));
            }

            Program.FinalizarComandoBD();

            txtLucroTotal.Text = "Lucro Total: R$ " + (ganho - gasto);

            Program.ExecutarComandoBD("Select avg(all PrecoCompra) from " + Program.nomebdProd + ";");

            while (Program.objDtReader.Read())
            {
                txtMediaPrecoCompra.Text = "Média (Compra): R$ " + (Convert.ToDecimal(string.Format("{0:0.00}", Program.objDtReader["avg(all PrecoCompra)"])));
            }

            Program.FinalizarComandoBD();


            Program.ExecutarComandoBD("Select avg(all PrecoVenda) from " + Program.nomebdProd + ";");

            while (Program.objDtReader.Read())
            {
                txtMediaPrecoVenda.Text = "Média (Venda): R$ " + (Convert.ToDecimal(string.Format("{0:0.00}", Program.objDtReader["avg(all PrecoVenda)"])));
            }

            Program.FinalizarComandoBD();

            Program.ExecutarComandoBD("Select avg(all Total) from " + Program.nomebdProd + ";");

            while (Program.objDtReader.Read())
            {
                txtMediaTotal.Text = "Média (Total): R$ " + (Convert.ToDecimal(string.Format("{0:0.00}", Program.objDtReader["avg(all Total)"])));
            }

            Program.FinalizarComandoBD();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
