using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Oficina_Flavia.Models
{
    [Table("Consertos")]
    class Conserto : BaseModel
    {
        public Conserto()
        {
            DataEntrada = DateTime.Now; 
            Cliente = new Cliente();
            Funcionario = new Funcionario();
            ItensServicos = new List<ItemServico>();
            Carro = new Carro();
        }

        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<ItemServico> ItensServicos { get; set; }
        public Carro Carro { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataRetorno { get; set; }
        public double ValorTotal { get; set; }
    }
}
