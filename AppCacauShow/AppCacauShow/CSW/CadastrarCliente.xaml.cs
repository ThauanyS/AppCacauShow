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
    /// Lógica interna para CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;

        public CadastrarCliente()
        {
            InitializeComponent();
            Conexao();

        }


        private void Conexao()
        {
            string conexaoString = "server=localhost;database=Soft_CacauShow;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }


        private void btnSalvar(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                DateTime dataNascimento = dtpDataNascimento.SelectedDate ?? DateTime.MinValue;
                string rg = txtRG.Text;
                string cpf = txtCPF.Text;
                string email = txtEmail.Text;
                string contato = txtContato.Text;
                string endereco = txtEndereco.Text;
                string cep = txtCEP.Text;
                string uf = txtUF.Text;
                string bairro = txtBairro.Text;
                string municipio = txtMunicipio.Text;

                string query = "INSERT INTO Cliente (nome_cli, data_nasc_cli, rg_cli, cpf_cli, email_cli, contato_cli, endereco_cli, cep_cli, uf_cli, bairro_cli, municipio_cli) " +
                               "VALUES (@_nome, @_data_nasc, @_rg, @_cpf, @_email, @_contato, @_endereco, @_cep, @_uf, @_bairro, @_municipio)";
                comando.CommandText = query;

                comando.Parameters.AddWithValue("@_nome", nome);
                comando.Parameters.AddWithValue("@_data_nasc", dataNascimento);
                comando.Parameters.AddWithValue("@_rg", rg);
                comando.Parameters.AddWithValue("@_cpf", cpf);
                comando.Parameters.AddWithValue("@_email", email);
                comando.Parameters.AddWithValue("@_contato", contato);
                comando.Parameters.AddWithValue("@_endereco", endereco);
                comando.Parameters.AddWithValue("@_cep", cep);
                comando.Parameters.AddWithValue("@_uf", uf);
                comando.Parameters.AddWithValue("@_bairro", bairro);
                comando.Parameters.AddWithValue("@_municipio", municipio);

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message);
            }

        }
    }
}
    

