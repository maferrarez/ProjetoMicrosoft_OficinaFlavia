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
    /// Interaction logic for frmCadastrarFuncionario.xaml
    /// </summary>
    public partial class frmCadastrarFuncionario : Window
    {
        Funcionario funcionario;
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            if (ConfirmTxt())
            {
                funcionario = new Funcionario()
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Endereco = txtEndereco.Text,
                    Cargo = txtCargo.Text,
                    Telefone = Convert.ToInt32(txtTelefone.Text)
                };

                if (FuncionarioDAO.Cadastrar(funcionario))
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Funcionario já cadastrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
                }


            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void LimparFormulario()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtCargo.Clear();
            txtCriadoEm.Clear();
            txtId.Clear();
            txtNome.Focus();
            funcionario = new Funcionario();
            btnAlterarFuncionario.IsEnabled = false;
            btnRemoverFuncionario.IsEnabled = false;
        }


        public bool ConfirmTxt()
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtEndereco.Text) && !string.IsNullOrWhiteSpace(txtCargo.Text)
                && !string.IsNullOrWhiteSpace(txtCpf.Text) && !string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                return true;
            }
            return false;
        }

        private void btnBuscarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            funcionario = FuncionarioDAO.BuscarPorNome(txtNome.Text);
            if (funcionario != null)
            {
                txtCpf.Text = funcionario.Cpf;
                txtEndereco.Text = funcionario.Endereco;
                txtTelefone.Text = funcionario.Telefone.ToString();
                txtCargo.Text = funcionario.Cargo;
                txtCriadoEm.Text = funcionario.CriadoEm.ToString();
                txtId.Text = funcionario.Id.ToString();
                btnAlterarFuncionario.IsEnabled = true;
                btnRemoverFuncionario.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Funcionario não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnLimparFuncionario_Click(object sender, RoutedEventArgs e)
        {
            LimparFormulario();
        }

        private void btnAlterarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            if (funcionario != null)
            {
                funcionario.Nome = txtNome.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Endereco = txtEndereco.Text;
                funcionario.Cargo = txtCargo.Text;
                funcionario.Telefone = Convert.ToInt32(txtTelefone.Text);

                FuncionarioDAO.Alterar(funcionario);
                LimparFormulario();
                MessageBox.Show("Funcionario Alterado com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemoverFuncionario_Click(object sender, RoutedEventArgs e)
        {
            if (funcionario != null)
            {
                FuncionarioDAO.Remover(funcionario);
                LimparFormulario();
                MessageBox.Show("Funcionario Removido com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Funcionario não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
