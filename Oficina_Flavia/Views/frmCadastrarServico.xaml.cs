using Oficina_Flavia.DAL;
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
    /// Interaction logic for frmCadastrarServico.xaml
    /// </summary>
    public partial class frmCadastrarServico : Window
    {
        private Servico servico;
        public frmCadastrarServico()
        {
            InitializeComponent();
        }

        private void btnCadastrarServico_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtDescricao.Text) &&
                !string.IsNullOrWhiteSpace(txtValor.Text))
            {
                servico = new Servico()
                {

                    Nome = txtNome.Text,
                    Descricao = txtDescricao.Text,
                    Valor = Convert.ToInt32(txtValor.Text)

                };

                if (ServicoDAO.Cadastrar(servico))
                {
                    MessageBox.Show("Serviço cadastrado com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Serviço já cadastrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void LimparFormulario()
        {
            txtDescricao.Clear();
            txtId.Clear();
            txtNome.Clear();
            txtValor.Clear();
            txtNome.Focus();
            servico = new Servico();
        }
    }
}
