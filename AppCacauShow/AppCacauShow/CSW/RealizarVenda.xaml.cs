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
    /// Lógica interna para RealizarVenda.xaml
    /// </summary>
    public partial class RealizarVenda : Window
    {
        public RealizarVenda()
        {
            InitializeComponent();
        }

        private Window currentWindow;

        private void OpenWindow(Window newWindow)
        {
            if (currentWindow != null)
            {
                currentWindow.Hide(); // Ocultar a janela atual em vez de fechá-la
            }

            currentWindow = newWindow;
            newWindow.Owner = this; // Definir a janela principal como proprietária da nova janela
            newWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen; // Definir a posição inicial da janela
            newWindow.Show();
        }


        private void Estoque_Click(object sender, RoutedEventArgs e)
        {
            Estoque estoqueWindow = new Estoque();
            OpenWindow(estoqueWindow);
        }

        private void Vendas_Click(object sender, RoutedEventArgs e)
        {
            RealizarVenda realizarVenda = new RealizarVenda();
            OpenWindow(realizarVenda);
        }

    
    }
}
