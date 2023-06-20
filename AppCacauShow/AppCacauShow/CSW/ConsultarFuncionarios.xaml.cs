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
    /// Lógica interna para ConsultarFuncionarios.xaml
    /// </summary>
    public partial class ConsultarFuncionarios : Window
    {
        public ConsultarFuncionarios()
        {
            InitializeComponent();
        }

        private void Caixa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCadastroFunc(object sender, RoutedEventArgs e)
        {
            CadastrarFuncionario funcionario = new CadastrarFuncionario();
            funcionario.ShowDialog();
        }
    }
}
