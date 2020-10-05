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
    /// Interaction logic for frmCadastrarCarro.xaml
    /// </summary>
    public partial class frmCadastrarCarro : Window
    {/// <summary>
     /// Interaction logic for frmCadastrarCarro.xaml
     /// </summary>
  
            Carro carro;
            Cliente cliente;
            public frmCadastrarCarro()
            {
                InitializeComponent();
                Limpar();
            }

            private void btnCadastrarCarro_Click(object sender, RoutedEventArgs e)
            {

                int idC = (int)cboCliente.SelectedValue;
                Cliente cliente = ClienteDAO.BuscarPorId(idC);
                        carro = CarroDAO.BuscarPorPlaca(txtPlaca.Text);
                        if (carro == null)
                        {
                            carro = new Carro();
                            carro.Dono = cliente;
                            carro.Modelo = txtModelo.Text;
                            carro.Placa = txtPlaca.Text;
                            if (CarroDAO.Cadastrar(carro))
                            {
                                MessageBox.Show("Carro cadastrado com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
                                Limpar();
                            }
                        else
                        {
                            MessageBox.Show("Carro já registrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }

            }



            public void Limpar()
            {
                txtModelo.Clear();
                txtPlaca.Clear();
                txtCriadoEm.Clear();
                txtId.Clear();
                txtPlaca.Focus();
                cliente = new Cliente();
                carro = new Carro();
                btnRemoverrCarro.IsEnabled = false;
                btnAlterarCarro.IsEnabled = false;
            }

            private void btnBuscarCarro_Click(object sender, RoutedEventArgs e)
            {
                carro = CarroDAO.BuscarPorPlaca(txtPlaca.Text);
                if (carro != null)
                {
                    cboCliente.IsEnabled = false;
                    txtModelo.Text = carro.Modelo;
                    txtCriadoEm.Text = carro.CriadoEm.ToString();
                    txtId.Text = carro.Id.ToString();
                    btnRemoverrCarro.IsEnabled = true;
                    btnAlterarCarro.IsEnabled = true;

                }
                else
                {
                    MessageBox.Show("Carro não encontrado.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            private void btnLimparCarro_Click(object sender, RoutedEventArgs e)
            {
                Limpar();
            }

            private void btnAlterarCarro_Click(object sender, RoutedEventArgs e)
            {
                CarroDAO.Alterar(carro);

            }

            private void btnRemoverrCarro_Click(object sender, RoutedEventArgs e)
            {
                CarroDAO.Remover(carro);

            }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboCliente.ItemsSource = ClienteDAO.Listar();
            cboCliente.DisplayMemberPath = "Nome";
            cboCliente.SelectedValuePath = "Id";
        }
    }
    }
