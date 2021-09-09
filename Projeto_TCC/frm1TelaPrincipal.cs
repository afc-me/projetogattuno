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
    public partial class frm1TelaPrincipal : Form
    {
        #region Método de Inicialização do Form

        public frm1TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botões

        // private void btnLogin_Click
        // private void btnCadastro_Click

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            var frm2Login = new frm2Login();
            frm2Login.Closed += (s, args) => Close();
            frm2Login.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frm2Cadastro cad = new frm2Cadastro();
            cad.ShowDialog();
        }

        #endregion

        #region Evento FormClosing

        private void frm1TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FormClosing(sender, e);
        }

        #endregion
    }
}
