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

        public void LimparFormulario()
        {
            txtDescricao.Clear();
            txtId.Clear();
            txtNome.Clear();
            txtValor.Clear();
            txtNome.Focus();
            txtDate.Clear();
            servico = new Servico();
            btnAlterarServico.IsEnabled = false;
            btnRemoverServico.IsEnabled = false;
        }

        private void btnRemoverServico_Click(object sender, RoutedEventArgs e)
        {
            if (servico != null)
            {
                ServicoDAO.Remover(servico);
                LimparFormulario();
                MessageBox.Show("Serviço Removido com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Serviço não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAlterarServico_Click(object sender, RoutedEventArgs e)
        {
            if (servico != null)
            {
                servico.Nome = txtNome.Text;
                servico.Descricao = txtDescricao.Text;
                servico.Valor = Convert.ToInt32(txtValor.Text);

                ServicoDAO.Alterar(servico);
                LimparFormulario();
                MessageBox.Show("Serviço Alterado com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Serviço não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnLimparServico_Click(object sender, RoutedEventArgs e)
        {

            LimparFormulario();
        }

        private void btnBuscarServico_Click(object sender, RoutedEventArgs e)
        {
            servico = ServicoDAO.BuscarPorServico(txtNome.Text);
            if (servico != null)
            {
                txtNome.Text = servico.Nome;
                txtDescricao.Text = servico.Descricao;
                txtDate.Text = servico.CriadoEm.ToString();
                txtId.Text = servico.Id.ToString();
                txtValor.Text = servico.Valor.ToString();
                btnAlterarServico.IsEnabled = true;
                btnRemoverServico.IsEnabled = true;

            }
            else
            {
                MessageBox.Show("Serviço não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
    }
}
