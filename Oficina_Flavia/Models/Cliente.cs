using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows.Documents;

namespace Oficina_Flavia.Models
{
    [Table("Clientes")]
    class Cliente : Pessoa
    {
        public string Email { get; set; }
    }
}
