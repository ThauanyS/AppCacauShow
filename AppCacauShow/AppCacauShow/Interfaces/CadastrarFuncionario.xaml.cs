﻿using MySql.Data.MySqlClient;
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
    /// Lógica interna para CadastrarFuncionario.xaml
    /// </summary>
    public partial class CadastrarFuncionario : Window
    {

        private MySqlConnection conexao;
        private MySqlCommand comando;
        public CadastrarFuncionario()
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
                string funcao = txtFuncao.Text;
                string contato = txtContato.Text;
                string endereco = txtEndereco.Text;
                string cep = txtCEP.Text;
                string uf = txtUF.Text;
                string bairro = txtBairro.Text;
                string municipio = txtMunicipio.Text;

                string query = "INSERT INTO Funcionario (nome_fun, data_nasc_fun, rg_fun, cpf_fun, email_fun, funcao_fun, contato_fun, endereco_fun, cep_fun, uf_fun, bairro_fun, municipio_fun) " +
                               "VALUES (@_nome, @_data_nasc, @_rg, @_cpf, @_email, @_funcao, @_contato, @_endereco, @_cep, @_uf, @_bairro, @_municipio)";
                comando.CommandText = query;

                comando.Parameters.AddWithValue("@_nome", nome);
                comando.Parameters.AddWithValue("@_data_nasc", dataNascimento);
                comando.Parameters.AddWithValue("@_rg", rg);
                comando.Parameters.AddWithValue("@_cpf", cpf);
                comando.Parameters.AddWithValue("@_email", email);
                comando.Parameters.AddWithValue("@_funcao", funcao);
                comando.Parameters.AddWithValue("@_contato", contato);
                comando.Parameters.AddWithValue("@_endereco", endereco);
                comando.Parameters.AddWithValue("@_cep", cep);
                comando.Parameters.AddWithValue("@_uf", uf);
                comando.Parameters.AddWithValue("@_bairro", bairro);
                comando.Parameters.AddWithValue("@_municipio", municipio);

                comando.ExecuteNonQuery();

                txtNome.Text = "";
                dtpDataNascimento.SelectedDate = null;
                txtRG.Text = "";
                txtCPF.Text = "";
                txtEmail.Text = "";
                txtFuncao.Text = "";
                txtContato.Text = "";
                txtEndereco.Text = "";
                txtCEP.Text = "";
                txtUF.Text = "";
                txtBairro.Text = "";
                txtMunicipio.Text = "";

                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message);
            }

        }

        private void Estoque1_Click(object sender, RoutedEventArgs e)
        {
            Estoque func = new Estoque();
            func.Show();
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



