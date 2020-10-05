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
            int idS = (int) cboServicos.SelectedValue;
            Servico servico = ServicoDAO.BuscarPorId(idS);
            PopularDataGrid(servico);
            PopularConserto(servico);
            total += servico.Valor;
            lblTotal.Content = $"Total: {total:C2}";
            conserto.ValorTotal = total;
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
            int idC = (int)cboCliente.SelectedValue;
            Cliente cliente = ClienteDAO.BuscarPorId(idC);
            int idF = (int)cboFuncionario.SelectedValue;
            Funcionario funcionario = FuncionarioDAO.BuscarPorId(idF);
            conserto.Cliente = cliente;
            conserto.Funcionario = funcionario;
            conserto.DataEntrada = DateTime.Now;
            conserto.DataRetorno = dataSaida.SelectedDate.Value.Date;
            ConsertoDAO.Cadastrar(conserto);
            MessageBox.Show("Conserto cadastrado com sucesso!");
            
        }
        
        private void btnBuscarCarro_Click(object sender, RoutedEventArgs e)
        {
            int idC = (int)cboCliente.SelectedValue;
            List<Carro> carros = CarroDAO.ListarPorCliente(idC);
            cboCarros.ItemsSource = carros;
        }
    }
}
