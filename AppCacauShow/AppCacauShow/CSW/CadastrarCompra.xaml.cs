using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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
    /// Lógica interna para CadastrarCompra.xaml
    /// </summary>
    public partial class CadastrarCompra : Window
    {
        private MySqlConnection conexao;

        public CadastrarCompra()
        {
            InitializeComponent();
            Conexao();
            Fornecedor = new ObservableCollection<string>(ObterNomesClientes());
            DataContext = this;
        }

        public ObservableCollection<string> Fornecedor { get; set; }

        private List<string> ObterNomesClientes()
        {
            string connectionString = "server=localhost;database=Soft_CacauShow;user=root;password=root;port=3306";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT nome_for FROM Fornecedor";
                MySqlCommand comando = new MySqlCommand(query, conexao);

                conexao.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                List<string> nomesClientes = new List<string>();

                while (leitor.Read())
                {
                    string nomeCliente = leitor.GetString("nome_for");
                    nomesClientes.Add(nomeCliente);
                }

                return nomesClientes;
            }
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=Soft_CacauShow;user=root;password=root;port=3306";
            conexao = new MySqlConnection(conexaoString);

            conexao.Open();
        }




        private void Estoque_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Vendas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Compras_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Funcionarios_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Caixa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnForCadastro(object sender, RoutedEventArgs e)
        {
            ConsultarFornecedores fornecedor = new ConsultarFornecedores();
            fornecedor.ShowDialog();
        }

        private void cmbFornecedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CadastrarFornecedor1_Click(object sender, RoutedEventArgs e)
        {
            ConsultarFornecedores fornecedores =    new ConsultarFornecedores();
            fornecedores.ShowDialog();
        }

        private void Estoque1_Click(object sender, RoutedEventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
            this.Close();
        }

        private void Vendas1_Click(object sender, RoutedEventArgs e)
        {
            RealizarVenda ven = new RealizarVenda();
            ven.Show();
            this.Close();
        }

        private void Compras1_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCompra compra = new CadastrarCompra();
            compra.Show();
            this.Close();
        }

        private void Funcionarios1_Click(object sender, RoutedEventArgs e)
        {
            ConsultarFuncionarios func = new ConsultarFuncionarios();
            func.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
