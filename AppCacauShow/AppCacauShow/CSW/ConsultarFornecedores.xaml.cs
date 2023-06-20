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
    /// Lógica interna para ConsultarFornecedores.xaml
    /// </summary>
    public partial class ConsultarFornecedores : Window
    {

        private MySqlConnection conexao;

        private MySqlCommand comando;
        public ConsultarFornecedores()
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
            string query = "Select * From Fornecedor";
            var comando = new MySqlCommand(query, conexao);
            var adaptador = new MySqlDataAdapter(comando);

            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);
            dgvFornecedores.ItemsSource = tabela.DefaultView;




        }

        private void PersonalizarColunas()
        {
            dgvFornecedores.Columns[0].Header = "ID";
            dgvFornecedores.Columns[1].Header = "Nome";
            dgvFornecedores.Columns[2].Header = "Email";
            dgvFornecedores.Columns[3].Header = "CNPJ";
            dgvFornecedores.Columns[4].Header = "Telefone";
            dgvFornecedores.Columns[5].Header = "Endereço";
            dgvFornecedores.Columns[6].Header = "CEP";
            dgvFornecedores.Columns[7].Header = "UF";
            dgvFornecedores.Columns[8].Header = "Bairro";
            dgvFornecedores.Columns[9].Header = "Município";
        }

        private void btnCadasFor(object sender, RoutedEventArgs e)
        {

        }
    }
}
