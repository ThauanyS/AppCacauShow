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
    /// Lógica interna para Estoque.xaml
    /// </summary>
    public partial class Estoque : Window
    {

        private MySqlConnection conexao;

        private MySqlCommand comando;

        public Estoque()
        {
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
            
                try
                {
                    Conexao();
                    string query = "Select * From Produto";
                    var comando = new MySqlCommand(query, conexao);
                    var adaptador = new MySqlDataAdapter(comando);

                    DataTable tabela = new DataTable();

                    adaptador.Fill(tabela);
                    dgvEstoque.ItemsSource = tabela.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreram erros ao listar as informações!\n" + ex.Message);
                }
         

          
        }

        private void PersonalizarColunas()
        {
            dgvEstoque.Columns[0].Header = "ID";
            dgvEstoque.Columns[1].Header = "Nome";
            dgvEstoque.Columns[2].Header = "Código";
            dgvEstoque.Columns[3].Header = "Data de Vencimento";
            dgvEstoque.Columns[4].Header = "Valor Unitário";
            dgvEstoque.Columns[5].Header = "Descrição";
        }


        private void Estoque_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Funcionarios_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Caixa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Vendas1_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void Produto_Click(object sender, RoutedEventArgs e)
        {
            CadastrarProdutos produtos = new CadastrarProdutos();
            produtos.ShowDialog
                ();
        }
    }
}
