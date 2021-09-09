using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;

namespace Projeto_TCC
{
    public enum HttpOperacoes
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    static class Program
    {
        // Funções e Eventos Globais

        #region Banco de Dados

        // public static MySqlConnection objConnec
        // public static MySqlCommand objCommand
        // public static MySqlDataReader objDtReader
        // public static string nomebdLogin, nomebdProd, nomebdFunc, nomebdPed
        // public static string arquivo

        // public static void ExecutarComandoBD(string comando)
        // public static void FinalizarComandoBD()
        // public static void CarregarDataGridView(DataGridView dgvDados, string banco, Action addLinhas)
        // public static int GerarNumeroAleatorio(int min, int max, string banco)

        public static MySqlConnection objConnec = new MySqlConnection();
        public static MySqlCommand objCommand = new MySqlCommand();
        public static MySqlDataReader objDtReader;

        public static string nomebdLogin = "LoginBD", nomebdProd = "ProdutosBD",
            nomebdFunc = "FuncionariosBD", nomebdPed = "PedidosBD";

        public static string arquivo = String.Format(@"{0}\BancoDeDados.txt", Application.StartupPath);

        public static void ExecutarComandoBD(string comando)
        {
            objCommand.CommandText = comando;
            objCommand.Connection = objConnec;
            objDtReader = objCommand.ExecuteReader();
        }

        public static void FinalizarComandoBD()
        {
            if (objDtReader.IsClosed == false)
            {
                objDtReader.Close();
            }
        }

        public static void CarregarDataGridView(DataGridView dgvDados, string banco, Action addLinhas, Action LimparTextBox, TextBox txtCod)
        {
            dgvDados.Rows.Clear();

            try
            {
                ExecutarComandoBD("Select * from " + banco + ";");

                if (objDtReader.HasRows == false)
                {
                    MessageBox.Show("Tabela Inexistente!",
                                    " *** CARREGAR DADOS DA TABELA *** ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    while (objDtReader.Read())
                    {
                        addLinhas();
                    }
                }
            }
            catch (Exception ex)
            {
                MensagemDeErroCatch(ex);
            }

            FinalizarComandoBD();

            LimparTextBox();

            txtCod.Clear();
            txtCod.Focus();
        }

        public static int GerarNumeroAleatorio(int min, int max, string banco)
        {
            var numList = Enumerable.Range(min, max).ToList();

            Random random = new Random();

            int num = 0;

            try
            {
                ExecutarComandoBD("Select Codigo from " + banco + ";");

                while (objDtReader.Read())
                {
                    numList.Add(Convert.ToInt32(objDtReader["Codigo"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MensagemDeErroCatch(ex);
            }

            FinalizarComandoBD();

            while ((numList.Contains(num)) == false)
            {
                num = random.Next(min, max);
            }

            return num;
        }

        #endregion

        #region Ler e Escrever BancoDeDados.txt

        // public static void LerTXT()
        // public static void GerarTXT_CriarTabelas(StreamWriter sw)
        // public static void GerarTXTBase()
        // public static void GerarTXTBase_InserirValoresBase(StreamWriter sw)
        // public static void GerarTXT()
        // public static void GerarTXT_InserirValores(StreamWriter sw, string nomeBanco)
        // public static string GerarEspacoVazio(int txtLength)
        // public static string Valores(string nomeBanco)

        public static void LerTXT()
        {
            int aux = 0;

            try
            {
                FileStream fs = new FileStream(arquivo, FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(fs, Encoding.UTF8);

                ExecutarComandoBD(sr.ReadToEnd().ToString());

                FinalizarComandoBD();

                sr.Close();
            }
            catch (IOException ex1)
            {
                if (aux == 0)
                {
                    GerarTXTBase();

                    DialogoInicio();
                }
                else
                {
                    aux = 1;
                    MensagemDeErroCatch(ex1);
                }
            }
            catch (Exception ex2)
            {
                MensagemDeErroCatch(ex2);
            }
        }

        public static void GerarTXT_CriarTabelas(StreamWriter sw)
        {
            sw.WriteLine("Create database if not exists RestauranteBD;");
            sw.WriteLine("");

            sw.WriteLine("Use RestauranteBD;");
            sw.WriteLine("");

            sw.WriteLine("drop table if exists " + nomebdLogin + ";");
            sw.WriteLine("drop table if exists " + nomebdProd + ";");
            sw.WriteLine("drop table if exists " + nomebdFunc + ";");
            sw.WriteLine("drop table if exists " + nomebdPed + ";");
            sw.WriteLine("");

            sw.WriteLine("Create table " + nomebdLogin);
            sw.WriteLine("(");
            sw.WriteLine("    Codigo  int(10)      not null primary key,");
            sw.WriteLine("    Usuario Varchar(100) not null,");
            sw.WriteLine("    Senha   Varchar(32)  not null");
            sw.WriteLine(");");
            sw.WriteLine("");

            sw.WriteLine("Create table " + nomebdProd);
            sw.WriteLine("(");
            sw.WriteLine("    Codigo      int(10)      not null primary key,");
            sw.WriteLine("    Produto     Varchar(20)  not null,");
            sw.WriteLine("    Descricao   Varchar(100) not null,");
            sw.WriteLine("    PrecoCompra float(10,2)  not null,");
            sw.WriteLine("    PrecoVenda  float(10,2)  not null,");
            sw.WriteLine("    Qtde        int(10)      not null,");
            sw.WriteLine("    Total       float(10,2)  not null");
            sw.WriteLine(");");
            sw.WriteLine("");

            sw.WriteLine("Create table " + nomebdFunc);
            sw.WriteLine("(");
            sw.WriteLine("    Codigo   int(10)      not null primary key,");
            sw.WriteLine("    Nome     Varchar(100) not null,");
            sw.WriteLine("    Funcao   Varchar(45)  not null,");
            sw.WriteLine("    CPF      char(14)     not null,");
            sw.WriteLine("    CEP      char(9)      not null,");
            sw.WriteLine("    NResid   int(10)      not null,");
            sw.WriteLine("    Endereco Varchar(100) not null,");
            sw.WriteLine("    Bairro   Varchar(100) not null,");
            sw.WriteLine("    Cidade   Varchar(100) not null,");
            sw.WriteLine("    Estado   char(2)      not null,");
            sw.WriteLine("    Telefone char(13)     not null,");
            sw.WriteLine("    Email    Varchar(64)  not null");
            sw.WriteLine(");");
            sw.WriteLine("");

            sw.WriteLine("Create table " + nomebdPed);
            sw.WriteLine("(");
            sw.WriteLine("    Codigo   int(10)      not null primary key,");
            sw.WriteLine("    Data     char(10)     not null,");
            sw.WriteLine("    Hora     char(5)      not null,");
            sw.WriteLine("    NomeCli  Varchar(100) not null");
            sw.WriteLine(");");
            sw.WriteLine("");
        }

        public static void GerarTXTBase()
        {
            using (StreamWriter sw = File.CreateText(arquivo))
            {
                GerarTXT_CriarTabelas(sw);

                GerarTXTBase_InserirValoresBase(sw);
            }

            FileStream fs = new FileStream(arquivo, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs, Encoding.UTF8);

            ExecutarComandoBD(sr.ReadToEnd().ToString());

            FinalizarComandoBD();

            sr.Close();
        }

        public static void GerarTXTBase_InserirValoresBase(StreamWriter sw)
        {
            sw.WriteLine("Insert into LoginBD Values");
            sw.WriteLine("(1, 'ROSA','123'),");
            sw.WriteLine("(2, 'ANDRE', '321'),");
            sw.WriteLine("(3, 'VOVODOBAILE', 'QWERTY'),");
            sw.WriteLine("(4, 'RONALDINHO43', '30-11-1996'),");
            sw.WriteLine("(5, 'SOPADELETRINHAS', 'OMGPLSDST');");
            sw.WriteLine("");

            sw.WriteLine("Insert into ProdutosBD Values");
            sw.WriteLine("(1, 'BATATA',                'BATATA PRE-FRITA 1.1 KG GOLDEN FOODS',                12.5,   18.75,  2,      37.5),");
            sw.WriteLine("(2, 'BATATA', 'BATATA PRE-FRITA 2.0 KG CHEF', 15.9, 23.85, 2, 47.7),");
            sw.WriteLine("(3, 'FRANGO', 'FRANGO A PASSARINHO 1 KG SEARA', 8, 12, 5, 60),");
            sw.WriteLine("(4, 'FRANGO', 'FRANGO COXA 1 KG', 9, 13.5, 14, 189),");
            sw.WriteLine("(5, 'FRANGO', 'FRANGO COXINHA DE ASAS 1 KG SEARA', 11.9, 17.85, 15, 267.75);");
            sw.WriteLine("");

            sw.WriteLine("Insert into FuncionariosBD Values");
            sw.WriteLine("(1, 'ROBERTO RAUL MIGUEL ASSUNCAO',              'ADMINISTRADOR',  '452.724.937-10', '65635-065', 146,    'RUA VINTE E CINCO',                    'VILA BANDEIRANTE',           'TIMON',                 'MA',  '(98)5880-2633', 'ROBERTO.RAUL@BOL.COM'),");
            sw.WriteLine("(2, 'NELSON MATHEUS PORTO', 'GARCOM', '298.428.365-17', '60741-420', 334, 'RUA JAPI', 'SERRINHA', 'FORTALEZA', 'CE', '(65)4980-3343', 'NELSONMP@GMAIL.COM'),");
            sw.WriteLine("(3, 'THEO KEVIN DA MATA', 'FUNCIONARIO', '778.862.123-47', '21670-010', 920, 'PRAÇA CARMELA DUTRA', 'GUADALUPE', 'RIO DE JANEIRO', 'RJ', '(63)6827-0082', 'THEOPARASEMPRE@HOTMAIL.COM'),");
            sw.WriteLine("(4, 'ERICK BRYAN NATHAN FIGUEIREDO', 'GARCOM', '366.512.816-15', '67033-280', 1192, 'PASSAGEM SOL NASCENTE', 'PATO MACHO', 'ANANINDEUA', 'PA', '(68)1008-7120', 'BRY.FIGUEIREDO@YAHOO.COM.BR'),");
            sw.WriteLine("(5, 'IGOR BENTO MURILO NUNES', 'FUNCIONARIO', '129.422.854-43', '85860-100', 658, 'TRAVESSA PATI', 'VILA RESIDENCIAL A', 'FOZ DO IGUAÇU', 'PR', '(48)1318-2093', 'IGOR.YOGURTE@ETEC.SP.GOV.BR');");
            sw.WriteLine("");

            sw.WriteLine("Insert into PedidosBD Values");
            sw.WriteLine("(1, '23/04/2019', '21:51', 'BENTO PEDRO HENRIQUE'),");
            sw.WriteLine("(2, '12/06/2019', '13:42', 'CALEB BRUNO BARBOSA'),");
            sw.WriteLine("(3, '26/05/2019', '15:33', 'MATHEUS ENRICO FREITAS'),");
            sw.WriteLine("(4, '29/03/2019', '07:24', 'CAUA JOSE BRUNO PEREIRA'),");
            sw.WriteLine("(5, '08/10/2019', '19:15', 'ANDERSON HEITOR SANTOS');");
        }

        public static void GerarTXT()
        {
            try
            {
                if (File.Exists(arquivo))
                {
                    File.Delete(arquivo);
                }

                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    GerarTXT_CriarTabelas(sw);

                    GerarTXT_InserirValores(sw, nomebdLogin);

                    GerarTXT_InserirValores(sw, nomebdProd);

                    GerarTXT_InserirValores(sw, nomebdFunc);

                    GerarTXT_InserirValores(sw, nomebdPed);
                }
            }
            catch (Exception ex)
            {
                MensagemDeErroCatch(ex);
            }
        }

        public static void GerarTXT_InserirValores(StreamWriter sw, string nomeBanco)
        {
            int max = 0;

            string pontuacao = ",";

            try
            {
                // Pesquisar maior valor
                ExecutarComandoBD("Select max(Codigo) from " + nomeBanco + ";");

                while (objDtReader.Read())
                {
                    max = Convert.ToInt32(objDtReader["max(Codigo)"].ToString());
                }

                FinalizarComandoBD();

                // Pesquisar todos os dados para escrever no arquivo
                ExecutarComandoBD("Select * from " + nomeBanco + ";");

                sw.WriteLine("Insert into " + nomeBanco + " Values");

                while (objDtReader.Read())
                {
                    if (Convert.ToInt32(objDtReader["Codigo"].ToString()) == max)
                    {
                        pontuacao = ";";
                    }

                    sw.WriteLine(Valores(nomeBanco) + pontuacao);
                }

                sw.WriteLine("");
            }
            catch (Exception ex)
            {
                MensagemDeErroCatch(ex);
            }

            FinalizarComandoBD();
        }

        public static string GerarEspacoVazio(int txtLength)
        {
            if (txtLength < 0)
            {
                return "";
            }
            else
            {
                string espaco = "";

                for (int k = 0; k <= txtLength; k++)
                {
                    espaco += " ";
                }

                return espaco;
            }
        }

        public static string Valores(string nomeBanco)
        {
            string resultado = "";

            if (nomeBanco == nomebdLogin)
            {
                resultado = ("(" + GerarEspacoVazio(7 - objDtReader["Codigo"].ToString().Length) + objDtReader["Codigo"].ToString() + ","
                        + " '" + objDtReader["Usuario"].ToString() + "'," + GerarEspacoVazio(20 - objDtReader["Usuario"].ToString().Length)
                        + " '" + objDtReader["Senha"].ToString() + "')");
            }
            else if (nomeBanco == nomebdProd)
            {
                resultado = ("(" + GerarEspacoVazio(7 - objDtReader["Codigo"].ToString().Length) + objDtReader["Codigo"].ToString() + ","
                    + " '" + objDtReader["Produto"].ToString()   + "'," + GerarEspacoVazio(20 - objDtReader["Produto"].ToString().Length)
                    + " '" + objDtReader["Descricao"].ToString() + "'," + GerarEspacoVazio(50 - objDtReader["Descricao"].ToString().Length)
                    + " "  + objDtReader["PrecoCompra"].ToString().Replace(",", ".") + "," + GerarEspacoVazio(5 - objDtReader["PrecoCompra"].ToString().Replace(",", ".").Length)
                    + " "  + objDtReader["PrecoVenda"].ToString().Replace(",", ".") + "," + GerarEspacoVazio(5 - objDtReader["PrecoVenda"].ToString().Replace(",", ".").Length)
                    + " "  + objDtReader["Qtde"].ToString()      + "," + GerarEspacoVazio(5 - objDtReader["Qtde"].ToString().Length)
                    + " " + objDtReader["Total"].ToString().Replace(",", ".") + ")");
            }
            else if (nomeBanco == nomebdFunc)
            {
                resultado= ("(" + GerarEspacoVazio(7 - objDtReader["Codigo"].ToString().Length) + objDtReader["Codigo"].ToString() + ","
                        + " '" + objDtReader["Nome"].ToString() + "'," + GerarEspacoVazio(40 - objDtReader["Nome"].ToString().Length)
                        + " '" + objDtReader["Funcao"].ToString() + "'," + GerarEspacoVazio(13 - objDtReader["Funcao"].ToString().Length)
                        + " '" + objDtReader["CPF"].ToString() + "',"
                        + " '" + objDtReader["CEP"].ToString() + "',"
                        + " " + objDtReader["NResid"].ToString() + "," + GerarEspacoVazio(5 - objDtReader["NResid"].ToString().Length)
                        + " '" + objDtReader["Endereco"].ToString() + "'," + GerarEspacoVazio(35 - objDtReader["Endereco"].ToString().Length)
                        + " '" + objDtReader["Bairro"].ToString() + "'," + GerarEspacoVazio(25 - objDtReader["Bairro"].ToString().Length)
                        + " '" + objDtReader["Cidade"].ToString() + "'," + GerarEspacoVazio(20 - objDtReader["Cidade"].ToString().Length)
                        + " '" + objDtReader["Estado"].ToString() + "'," + GerarEspacoVazio(2 - objDtReader["Estado"].ToString().Length)
                        + " '" + objDtReader["Telefone"].ToString() + "',"
                        + " '" + objDtReader["Email"].ToString() + "')");
            }
            else if (nomeBanco == nomebdPed)
            {
                resultado = ("(" + GerarEspacoVazio(7 - objDtReader["Codigo"].ToString().Length) + objDtReader["Codigo"].ToString() + ","
                        + " '" + objDtReader["Data"].ToString() + "',"
                        + " '" + objDtReader["Hora"].ToString() + "',"
                        + " '" + objDtReader["NomeCli"].ToString() + "')");
            }

            return resultado;
        }

        #endregion

        #region MessageBoxes

        // public static void MensagemDeErroCatch(Exception ex)
        // public static void MensagemSucesso(string tarefa)
        // public static void MensagemPreencherCampos()
        // public static void DialogoInicio()

        public static void MensagemDeErroCatch(Exception ex)
        {
            MessageBox.Show("Erro ==> " + ex.Message,
                            " *** ERRO *** ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public static void MensagemSucesso(string tarefa)
        {
            if (tarefa == "Cadastro")
            {
                MessageBox.Show(tarefa + " realizado com sucesso!",
                            " *** " + tarefa.ToUpper() + " DE DADOS *** ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(tarefa + " realizada com sucesso!",
                            " *** " + tarefa.ToUpper() + " DE DADOS *** ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        public static void MensagemPreencherCampos()
        {
            MessageBox.Show("Certifique-se de que todos os campos foram preenchidos e tente novamente.",
                         " *** AVISO *** ",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation);
        }

        public static void DialogoInicio()
        {
            MessageBox.Show("Bem-Vindo!",
                            " *** INÍCIO *** ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            MessageBox.Show("Esta deve ser sua primeira vez utilizando este programa.",
                            " *** INÍCIO *** ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            MessageBox.Show("Para iniciar, clique em \"Login\" e digite como nome de usuário \"ROSA\" e senha \"123\"",
                            " *** INÍCIO *** ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            MessageBox.Show("Desta forma, você poderá ver como o programa funciona sem precisar fornecer seus dados para cadastro.",
                            " *** INÍCIO *** ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            MessageBox.Show("Lembre-se: digite ROSA e 123 para acessar programa. Recomendamos que anote esses dados em algum lugar.",
                            " *** INÍCIO *** ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            MessageBox.Show("Lhe desejamos um ótimo trabalho!",
                            " *** INÍCIO *** ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        #endregion

        #region Botões

        // public static void BtnPesquisar(TextBox txtCod, string banco, Action atribuirDados, Action limpar)
        // public static void BtnCadastrar(TextBox txtCod, string banco, string comando, Action limpar)
        // public static void BtnAlterar(TextBox txtCod, string banco, string comando)
        // public static void BtnExcluir(TextBox txtCod, string banco)
        // public static void BtnSair()

        public static void BtnPesquisar(TextBox txtCod, string banco, Action atribuirDados, Action limpar)
        {
            if (txtCod.Text != "")
            {
                limpar();

                try
                {
                    ExecutarComandoBD("Select * from " + banco + " where Codigo='" + txtCod.Text + "'; ");

                    if (objDtReader.HasRows == false)
                    {
                        MessageBox.Show("Código Inexistente!",
                                        " *** CONSULTA DE DADOS *** ",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        while (objDtReader.Read())
                        {
                            atribuirDados();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MensagemDeErroCatch(ex);
                }

                FinalizarComandoBD();
            }
        }

        public static void BtnCadastrar(int cod, string banco, string comando)
        {
            try
            {
                ExecutarComandoBD("Select * from " + banco + " where Codigo='" + cod.ToString() + "'; ");

                if (objDtReader.HasRows)
                {
                    MessageBox.Show("Esse código já está sendo utilizado. \n\n" +
                                    "Digite outro código e tente novamente.",
                                    " *** CADASTRO *** ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    FinalizarComandoBD();

                    ExecutarComandoBD(comando);

                    FinalizarComandoBD();

                    MensagemSucesso("Cadastro");
                }
            }
            catch (Exception ex)
            {
                MensagemDeErroCatch(ex);
            }

            FinalizarComandoBD();
        }

        public static void BtnAlterar(TextBox txtCod, string banco, string comando)
        {
            if (MessageBox.Show("Realmente deseja alterar os dados de código "
                    + Convert.ToInt32(txtCod.Text) + " ?",
                    " ****** ALTERAR DADOS ****** ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ExecutarComandoBD("Select * from " + banco + " where Codigo='" + txtCod.Text + "'; ");

                    if (objDtReader.HasRows == false)
                    {
                        MessageBox.Show("O código digitado não foi encontrado. \n\n" +
                                        "Digite outro código e tente novamente.",
                                        " *** ALTERAR DADOS *** ",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        FinalizarComandoBD();

                        ExecutarComandoBD(comando);

                        FinalizarComandoBD();

                        MensagemSucesso("Alteração");
                    }
                }
                catch (Exception ex)
                {
                    MensagemDeErroCatch(ex);
                }

                FinalizarComandoBD();
            }
        }

        public static void BtnExcluir(TextBox txtCod, string banco, Action limpar)
        {
            if (MessageBox.Show("Realmente deseja excluir os dados do código "
                                + Convert.ToInt32(txtCod.Text) + " ?",
                                " ****** EXCLUIR DADOS ****** ",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)

            {
                try
                {
                    ExecutarComandoBD("Select * from " + banco + " where Codigo='" + txtCod.Text + "'; ");

                    if (objDtReader.HasRows == false)
                    {
                        MessageBox.Show("O código digitado não foi encontrado. \n\n" +
                                        "Digite outro código e tente novamente.",
                                        " *** EXCLUIR DADOS *** ",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        FinalizarComandoBD();

                        objCommand.CommandText = "Delete from " + banco + " where Codigo='" + txtCod.Text + "';";
                        objCommand.Connection = objConnec;
                        objCommand.ExecuteNonQuery();

                        limpar();

                        MensagemSucesso("Exclusão");
                    }
                }
                catch (Exception ex)
                {
                    MensagemDeErroCatch(ex);
                }

                FinalizarComandoBD();
            }
        }

        public static void BtnSair()
        {
            if (MessageBox.Show("Deseja sair do programa? \n\n" +
                                "Obs: As modificações serão salvas.",
                                " ****** SAIR DO PROGRAMA ****** ",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GerarTXT();

                Application.Exit();
            }
        }

        #endregion

        #region Eventos KeyPress e FormClosing

        // public static void KeyPress_Letra
        // public static void KeyPress_LetraEspaco
        // public static void KeyPress_Num
        // public static void KeyPress_NumLetraEspaco
        // public static void KeyPress_NumPonto
        // public static void KeyPress_Email
        // public static void FormClosing(object sender, FormClosingEventArgs e)

        public static void KeyPress_Letra(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public static void KeyPress_LetraEspaco(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        public static void KeyPress_Num(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public static void KeyPress_NumLetraEspaco(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))
                && (!char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public static void KeyPress_NumPonto(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public static void KeyPress_Email(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))
                && (!char.IsLetter(e.KeyChar)) && (e.KeyChar != '@') && (e.KeyChar != '.')
                && (e.KeyChar != '-') && (e.KeyChar != '_'))
            {
                e.Handled = true;
            }
        }

        public static void FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Deseja sair do programa? \n\n" +
                                    "Obs: As modificações serão salvas.",
                                    " ****** SAIR DO PROGRAMA ****** ",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GerarTXT();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                GerarTXT();
                Application.Exit();
            }
        }

        #endregion

        #region Buscar CEP

        // public static string Link
        // public static HttpOperacoes HttpMetodo
        // public static string BuscarCEP(TextBox txtCEP)
        // public static string GetIntervaloDeTexto(string strTotal, string strInicio, string strFinal)

        public static string Link { get; set; }

        public static HttpOperacoes HttpMetodo { get; set; }

        public static string BuscarCEP(TextBox txtCEP)
        {
            string strResposta = "";

            try
            {
                Link = "https://viacep.com.br/ws/" + txtCEP.Text + "/json/";

                HttpMetodo = HttpOperacoes.GET;

                HttpWebRequest webRequest = WebRequest.Create(Link) as HttpWebRequest;

                webRequest.Method = HttpMetodo.ToString();

                using (HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse)
                {
                    if (webResponse.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("error code: " + webResponse.StatusCode);
                    }

                    using (Stream responseStream = webResponse.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResposta = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strResposta;
        }

        public static string GetIntervaloDeTexto(string strTotal, string strInicio, string strFinal)
        {
            int comeco, fim;

            if (strTotal.Contains(strInicio) && strTotal.Contains(strFinal))
            {
                comeco = strTotal.IndexOf(strInicio, 0) + strInicio.Length;

                fim = strTotal.IndexOf(strFinal, comeco);

                return strTotal.Substring(comeco, fim - comeco);
                // Retorna excluindo strInicio e strFinal
                // Exemplo: GetIntervaloDeTexto("ABCDEFG", "B", "F") => "CDE"
            }
            else
            {
                return "";
            }
        }

        #endregion

        #region Validar CPF

        // public static bool ValidarCPF(string CPF)

        public static bool ValidarCPF(string CPF)
        {
            // Para entender como é feito o cálculo de validação de um CPF,
            // visite o site https://laennder.com/como-e-feito-o-calculo-de-validacao-cpf/

            int[] peso1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };      // Usado para o penúltimo dígito
            int[] peso2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 }; // Usado para o último dígito
            string inicioCPF = "";                                        // 9 primeiros dígitos
            string finalCPF = "";                                         // 2 últimos dígitos
            int soma = 0;                                                 // Soma da multiplicação entre os dígitos do CPF e os pesos acima
            int resto = 0;                                                // Resto da divisão da soma por 11. Ex: 35 % 11 resulta em 2

            CPF = CPF.Trim().Replace(".", "").Replace("-", "");

            inicioCPF = CPF.Substring(0, 9);

            for (int k = 0; k < 9; k++)
            {
                soma += int.Parse(inicioCPF[k].ToString()) * peso1[k];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            finalCPF = resto.ToString();

            inicioCPF += finalCPF;

            soma = 0;

            for (int k = 0; k < 10; k++)
            {
                soma += int.Parse(inicioCPF[k].ToString()) * peso2[k];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            finalCPF += resto.ToString();

            return CPF.EndsWith(finalCPF);
        }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                objConnec.ConnectionString = "Server=127.0.0.1;" +
                                             "User id=root;" +
                                             "Password=etec";

                objConnec.Open();

                LerTXT();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frm1TelaPrincipal());
            }
            catch (Exception ex)
            {
                MensagemDeErroCatch(ex);
            }
        }
    }
}
