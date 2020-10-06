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
    /// Interaction logic for frmCadastrarConserto.xaml
    /// </summary>
    public partial class frmCadastrarConserto : Window
    {
        private List<dynamic> servicos = new List<dynamic>();
        double total = 0;
        private Conserto conserto = new Conserto();
        public frmCadastrarConserto()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboServicos.ItemsSource = ServicoDAO.Listar();
            cboServicos.DisplayMemberPath = "Nome";
            cboServicos.SelectedValuePath = "Id";

            cboFuncionario.ItemsSource = FuncionarioDAO.Listar();
            cboFuncionario.DisplayMemberPath = "Nome";
            cboFuncionario.SelectedValuePath = "Id";

            cboCliente.ItemsSource = ClienteDAO.Listar();
            cboCliente.DisplayMemberPath = "Nome";
            cboCliente.SelectedValuePath = "Id";

        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (cboServicos.SelectedValue != null)
            {
                int idS = (int)cboServicos.SelectedValue;
                Servico servico = ServicoDAO.BuscarPorId(idS);
                PopularDataGrid(servico);
                PopularConserto(servico);
                total += servico.Valor;
                lblTotal.Content = $"Total: {total:C2}";
                conserto.ValorTotal = total;
            }
            else
            {
                MessageBox.Show("Selecione um serviço.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PopularConserto(Servico servico)
        {
            conserto.ItensServicos.Add(
                new ItemServico
                {
                    Servico = servico,
                    Valor = servico.Valor
                }
            );
        }

        private void PopularDataGrid(Servico servico)
        {
            dynamic item = new
            {
                Nome = servico.Nome,
                Descricao = servico.Descricao,
                Valor = servico.Valor.ToString("C2")
            };
            servicos.Add(item);
            dtaServicos.ItemsSource = servicos;
            dtaServicos.Items.Refresh();
        }

        private void brnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (cboServicos.SelectedValue != null && cboCliente.SelectedValue != null && cboCarros.SelectedValue != null && cboFuncionario.SelectedValue != null)
            {
                if (dataSaida.SelectedDate != null)
                {
                    int idC = (int)cboCliente.SelectedValue;
                    int idF = (int)cboFuncionario.SelectedValue;
                    int idcr = (int)cboCarros.SelectedValue;
                    conserto.Cliente = ClienteDAO.BuscarPorId(idC);
                    conserto.Funcionario = FuncionarioDAO.BuscarPorId(idF);
                    conserto.DataRetorno = dataSaida.SelectedDate.Value.Date;
                    conserto.Carro = CarroDAO.BuscarPorId(idcr);
                    ConsertoDAO.Cadastrar(conserto);
                    Limpar();
                    MessageBox.Show("Conserto cadastrado com sucesso!", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Selecione uma data de retorno.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione todos os campos.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnBuscarCarro_Click(object sender, RoutedEventArgs e)
        {
            if (cboCliente.SelectedValue != null)
            {
                int idC = (int)cboCliente.SelectedValue;
                List<Carro> carros = CarroDAO.ListarPorCliente(idC);
                cboCarros.ItemsSource = carros;
                cboCarros.DisplayMemberPath = "Placa";
                cboCarros.SelectedValuePath = "Id";
                cboCliente.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Selecione um cliente.", "Oficina Flavia", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void Limpar()
        {
            servicos.Clear();
            dtaServicos.Items.Refresh();
            total = 0;
            lblTotal.Content = $"Total: {total:C2}";
            cboCarros.SelectedIndex = -1;
            cboCarros.ItemsSource = null;
            cboCliente.IsEnabled = true;
            servicos = new List<dynamic>();
            conserto = new Conserto();
        }

        private void btnLimparConserto_Click(object sender, RoutedEventArgs e)
        {
            Limpar();
        }
    }
}
