using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Oficina_Flavia.Models
{
    [Table("Funcionarios")]
    class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
    }
}
