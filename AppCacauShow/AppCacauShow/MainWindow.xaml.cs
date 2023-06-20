using AppCacauShow.CSW;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppCacauShow
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Click_Entrar(object sender, RoutedEventArgs e)
        {
            RealizarVenda vendaWindow = new RealizarVenda();
            vendaWindow.Owner = this; // Define a janela principal como proprietária da janela de venda
            vendaWindow.ShowDialog();
        }

        private void Click_Caixa(object sender, RoutedEventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.Owner = this; // Define a janela principal como proprietária da janela de venda
            caixa.ShowDialog();
        }
    }
}
