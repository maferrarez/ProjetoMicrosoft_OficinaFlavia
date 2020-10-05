using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Oficina_Flavia.Models
{
    [Table("ItensServicos")]
    class ItemServico : BaseModel
    {
        public ItemServico()
        {
            Servico = new Servico();
        }
        public Servico Servico { get; set; }
        public double Valor { get; set; }
    }
}
