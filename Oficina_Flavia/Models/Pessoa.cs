using System;
using System.Collections.Generic;
using System.Text;

namespace Oficina_Flavia.Models
{
    class Pessoa : BaseModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }

    }
}
