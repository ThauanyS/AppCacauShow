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
    /// Lógica interna para ConsultarFuncionarios.xaml
    /// </summary>
    public partial class ConsultarFuncionarios : Window
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;
        public ConsultarFuncionarios()
        {
            InitializeComponent();
            Conexao();
            CarregarDados();
            PersonalizarColunas();
        }


        private void Conexao()
        {
            string conexaoString = "server=localhost;database=Soft_CacauShow;user=root;password=root;port=3306";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();

        }

        private void CarregarDados()
        {


            Conexao();
            string query = "Select * From Funcionario";
            var comando = new MySqlCommand(query, conexao);
            var adaptador = new MySqlDataAdapter(comando);

            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);
            dgvFuncionarios.ItemsSource = tabela.DefaultView;




        }

        private void PersonalizarColunas()
        {
            dgvFuncionarios.Columns[0].Header = "ID";
            dgvFuncionarios.Columns[1].Header = "Nome";
            dgvFuncionarios.Columns[2].Header = "Data de Nascimento";
            dgvFuncionarios.Columns[3].Header = "RG";
            dgvFuncionarios.Columns[4].Header = "CPF";
            dgvFuncionarios.Columns[5].Header = "Email";
            dgvFuncionarios.Columns[6].Header = "Função";
            dgvFuncionarios.Columns[7].Header = "Contato";
            dgvFuncionarios.Columns[8].Header = "Endereço";
            dgvFuncionarios.Columns[9].Header = "CEP";
            dgvFuncionarios.Columns[10].Header = "UF";
            dgvFuncionarios.Columns[11].Header = "Bairro";
            dgvFuncionarios.Columns[12].Header = "Município";
        }

        private void Caixa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCadastroFunc(object sender, RoutedEventArgs e)
        {
            CadastrarFuncionario funcionario = new CadastrarFuncionario();
            funcionario.Show();
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
