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
    public partial class frm3Funcionario : Form
    {
        #region Método de Inicialização do Form

        public frm3Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionário_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botões

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frm4Pedidos ped = new frm4Pedidos();
            ped.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frm4Produtos pro = new frm4Produtos();
            pro.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            var frm2Login = new frm2Login();
            frm2Login.Closed += (s, args) => Close();
            frm2Login.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Program.BtnSair();
        }

        #endregion

        #region Evento FormClosing

        private void frm3Funcionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FormClosing(sender, e);
        }

        #endregion
    }
}
