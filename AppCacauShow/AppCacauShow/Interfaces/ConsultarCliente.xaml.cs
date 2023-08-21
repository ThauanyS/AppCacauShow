using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica interna para ConsultarCliente.xaml
    /// </summary>
    public partial class ConsultarCliente : Window
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;
        public ConsultarCliente()
        {
            InitializeComponent();
            Conexao();
            CarregarDados();
            PersonalizarColunas();
        }


        private void Conexao()
        {
            string conexaoString = "server=localhost;database=Soft_CacauShow;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();

        }

        private void CarregarDados()
        {


            Conexao();
            string query = "Select * From Cliente";
            var comando = new MySqlCommand(query, conexao);
            var adaptador = new MySqlDataAdapter(comando);

            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);
            dgvListarCliente.ItemsSource = tabela.DefaultView;

        }

        private void PersonalizarColunas()
        {
            if (dgvListarCliente.Columns.Count >= 12)
            {
                dgvListarCliente.Columns[0].Header = "ID";
                dgvListarCliente.Columns[1].Header = "Nome";
                dgvListarCliente.Columns[2].Header = "Data de Nascimento";
                dgvListarCliente.Columns[3].Header = "RG";
                dgvListarCliente.Columns[4].Header = "CPF";
                dgvListarCliente.Columns[5].Header = "Email";
                dgvListarCliente.Columns[6].Header = "Contato";
                dgvListarCliente.Columns[7].Header = "Endereço";
                dgvListarCliente.Columns[8].Header = "CEP";
                dgvListarCliente.Columns[9].Header = "UF";
                dgvListarCliente.Columns[10].Header = "Bairro";
                dgvListarCliente.Columns[11].Header = "Município";
            }
        }
  

        private void cli_click(object sender, RoutedEventArgs e)
        {
            CadastrarCliente cliente = new CadastrarCliente();
            cliente.Show();
            this.Close();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}