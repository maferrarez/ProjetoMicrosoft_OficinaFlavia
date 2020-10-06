using Oficina_Flavia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oficina_Flavia.DAL
{
    class ClienteDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static Cliente BuscarPorNome(string nomeCliente) => _context.Clientes.FirstOrDefault(x => x.Nome == nomeCliente);
        public static Cliente BuscarPorCpf(string cpfCliente) => _context.Clientes.FirstOrDefault(x => x.Cpf == cpfCliente);
        public static Cliente BuscarPorId(int id) => _context.Clientes.FirstOrDefault(x => x.Id == id);
        public static bool Cadastrar(Cliente cliente)
        {
            if (BuscarPorCpf(cliente.Cpf) == null)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();

                return true;
            }
            return false;
        }

        public static List<Cliente> Listar() => _context.Clientes.ToList();


        public static void Remover(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public static void Alterar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

    }
}
