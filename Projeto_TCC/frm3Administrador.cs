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
    public partial class frm3Administrador : Form
    {
        #region Método de Inicialização do Form

        public frm3Administrador()
        {
            InitializeComponent();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botões

        // private void btnPedidos_Click      
        // private void btnProdutos_Click     
        // private void btnFunc_Click         
        // private void btnSair_Click         

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

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frm4Funcionarios func = new frm4Funcionarios();
            func.ShowDialog();
        }

        private void btnFinancas_Click(object sender, EventArgs e)
        {
            frm4Financas fin = new frm4Financas();
            fin.ShowDialog();
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

        private void frm3Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FormClosing(sender, e);
        }

        #endregion
    }
}
