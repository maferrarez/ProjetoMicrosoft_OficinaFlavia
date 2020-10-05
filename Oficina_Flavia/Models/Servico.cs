using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Oficina_Flavia.Models
{
    [Table("Servicos")]
    class Servico : BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

    }
}
