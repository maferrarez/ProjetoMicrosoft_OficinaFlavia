using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Oficina_Flavia.Models
{
    [Table("Carros")]
    class Carro : BaseModel
    {
        public Carro()
        {
            Dono = new Cliente();
        }
        public Cliente Dono { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
    }
}