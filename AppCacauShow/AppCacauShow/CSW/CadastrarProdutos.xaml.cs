using System;
using System.Collections.Generic;
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
using MySql.Data.MySqlClient;


namespace AppCacauShow.CSW
{
    /// <summary>
    /// Lógica interna para CadastrarProdutos.xaml
    /// </summary>
    public partial class CadastrarProdutos : Window
    {

        private MySqlConnection conexao;

        private MySqlCommand comando;

        public CadastrarProdutos()
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

     
        

        private void btnSalvar_Click_1(object sender, RoutedEventArgs e)
        {

                    var nome = txtNome.Text;
                    var valorU = valorUnit.Text;
                    DateTime dataSelecionada = new DateTime(2023, 6, 19);
                    dtpVencimento.SelectedDate = dataSelecionada;
                    var codigo = txtCodigo.Text;
                    var descricao = txtDescricao.Text;  


                    string query = "INSERT INTO Produto (nome_pro, codigo_pro, data_venc_pro, valor_unit_pro, descricao_pro) VALUES (@_nome,  @_codigo, @_data_venc, @_valor_unit, @_descricao)";
                    var comando = new MySqlCommand(query, conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_valor_unit", valorU);
                    comando.Parameters.AddWithValue("@_data_venc", dataSelecionada);
                    comando.Parameters.AddWithValue("@_codigo", codigo);
                    comando.Parameters.AddWithValue("@_descricao", descricao);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!");
          
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
            ConsultarFornecedores forn = new ConsultarFornecedores();
            forn.Show();
            this.Close();
        }

        private void Caixa1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
