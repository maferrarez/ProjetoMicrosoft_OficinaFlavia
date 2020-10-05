using Oficina_Flavia.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Oficina_Flavia.Views
{
    /// <summary>
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Cliente cliente = new Cliente();
            Funcionario funcionario = new Funcionario();
            Servico servicos = new Servico();
            Conserto conserto = new Conserto();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Oficina da Flavia",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarCliente frm = new frmCadastrarCliente();
            frm.ShowDialog();
        }

        private void menuCadastrarServico_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarServico frm = new frmCadastrarServico();
            frm.ShowDialog();
        }

        private void menuCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarFuncionario frm = new frmCadastrarFuncionario();
            frm.ShowDialog();
        }


        private void menuCadastrarConserto_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarConserto frm = new frmCadastrarConserto();
            frm.ShowDialog();

        }

        private void menuCadastrarCarro_Click(object sender, RoutedEventArgs e)
        {

            frmCadastrarCarro frm = new frmCadastrarCarro();
            frm.ShowDialog();
        }
    }
}
