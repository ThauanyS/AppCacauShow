using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppCacauShow.CSW
{
    /// <summary>
    /// Lógica interna para CadastrarFornecedor.xaml
    /// </summary>
    public partial class CadastrarFornecedor : Window
    {

        private MySqlConnection conexao;

        private MySqlCommand comando;
        public CadastrarFornecedor()
        {
            InitializeComponent(); 
            Conexao();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=Soft_CacauShow;user=root;password=root;port=3306";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();

        }



        private void Estoque_Click(object sender, RoutedEventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
            this.Close();
        }

        private void Compras_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCompra compra = new CadastrarCompra();
            compra.Show();
            this.Close();
        }

        private void Funcionarios_Click(object sender, RoutedEventArgs e)
        {
            ConsultarFuncionarios func = new ConsultarFuncionarios();
            func.Show();
            this.Close();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string cnpj = txtCnpj.Text;
                string telefone = txtContato.Text;
                string endereco = txtEndereco.Text;
                string cep = txtCep.Text;
                string uf = txtUf.Text;
                string bairro = txtBairro.Text;
                string municipio = txtMunicipio.Text;

                string query = "INSERT INTO Fornecedor (nome_for, email_for, cnpj_for, telefone_for, endereco_for, cep_for, uf_for, bairro_for, municipio_for) VALUES (@_nome, @_email, @_cnpj, @_telefone, @_endereco, @_cep, @_uf, @_bairro, @_municipio)";
                MySqlCommand comando = new MySqlCommand(query, conexao);

                comando.Parameters.AddWithValue("@_nome", nome);
                comando.Parameters.AddWithValue("@_email", email);
                comando.Parameters.AddWithValue("@_cnpj", cnpj);
                comando.Parameters.AddWithValue("@_telefone", telefone);
                comando.Parameters.AddWithValue("@_endereco", endereco);
                comando.Parameters.AddWithValue("@_cep", cep);
                comando.Parameters.AddWithValue("@_uf", uf);
                comando.Parameters.AddWithValue("@_bairro", bairro);
                comando.Parameters.AddWithValue("@_municipio", municipio);

                comando.ExecuteNonQuery();

                txtNome.Text = "";
                txtEmail.Text = "";
                txtCnpj.Text = "";
                txtContato.Text = "";
                txtEndereco.Text = "";
                txtCep.Text = "";
                txtUf.Text = "";
                txtBairro.Text = "";
                txtMunicipio.Text = "";

                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Vendas1_Click(object sender, RoutedEventArgs e)
        {
            RealizarVenda ven = new RealizarVenda();
            ven.Show();
            this.Close();
        }
    }
}
