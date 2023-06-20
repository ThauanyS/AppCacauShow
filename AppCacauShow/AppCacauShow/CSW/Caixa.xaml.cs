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
    /// Lógica interna para Caixa.xaml
    /// </summary>
    public partial class Caixa : Window
    {
        public Caixa()
        {
        }

        private void Consultar_vendas_Click(object sender, RoutedEventArgs e)
        {
            ConsultarVendas consultarVendas = new ConsultarVendas();
            consultarVendas.Owner = this; // Define a janela principal como proprietária da janela de venda
            consultarVendas.ShowDialog();
        }

        private void Consultar_compras_Click(object sender, RoutedEventArgs e)
        {
            ConsultarVendas consultarVendas = new ConsultarVendas();
            consultarVendas.Owner = this; // Define a janela principal como proprietária da janela de venda
            consultarVendas.ShowDialog();
        }
    }
}
