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
    /// Interaction logic for frmCadastrarCliente.xaml
    /// </summary>
    public partial class frmCadastrarCliente : Window
    {
        private Cliente cliente;
        
        public frmCadastrarCliente()
        {
            InitializeComponent();
            LimparFormulario();
        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (ConfirmTxt())
            {
                cliente = new Cliente()
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Endereco = txtEndereco.Text,
                    Email = txtEmail.Text,
                    Telefone = Convert.ToInt32(txtTelefone.Text)
                };

                if (ClienteDAO.Cadastrar(cliente))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Cliente já cadastrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void LimparFormulario()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtDate.Clear();
            txtNome.Focus();
            cliente = new Cliente();
            btnAlterarCliente.IsEnabled = false;
            btnRemoverCliente.IsEnabled = false;
        }

        public bool ConfirmTxt()
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtEndereco.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtCpf.Text) && !string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                return true;
            }
            return false;
        }

        private void btnBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            cliente = ClienteDAO.BuscarPorNome(txtNome.Text);
            if (cliente == null)
            {
                cliente = ClienteDAO.BuscarPorCpf(txtCpf.Text);
                if (cliente != null)
                {

                    txtCpf.Text = cliente.Cpf;
                    txtEndereco.Text = cliente.Endereco;
                    txtTelefone.Text = cliente.Telefone.ToString();
                    txtEmail.Text = cliente.Email;
                    txtDate.Text = cliente.CriadoEm.ToString();
                    txtId.Text = cliente.Id.ToString();
                    btnAlterarCliente.IsEnabled = true;
                    btnRemoverCliente.IsEnabled = true;

                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnLimparCliente_Click(object sender, RoutedEventArgs e)
        {
            LimparFormulario();
        }

        private void btnAlterarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (cliente != null)
            {
                cliente.Nome = txtNome.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = Convert.ToInt32(txtTelefone.Text);

                ClienteDAO.Alterar(cliente);
                LimparFormulario();
                MessageBox.Show("Cliente Alterado com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemoverCliente_Click(object sender, RoutedEventArgs e)
        {
            if (cliente != null)
            {
                ClienteDAO.Remover(cliente);
                LimparFormulario();
                MessageBox.Show("Cliente Removido com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

      
    }
}
