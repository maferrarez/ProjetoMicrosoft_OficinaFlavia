using Oficina_Flavia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oficina_Flavia.DAL
{
    class ServicoDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static Servico BuscarPorServico(string nomeServico) => _context.Servicos.FirstOrDefault(x => x.Nome == nomeServico);
        public static Servico BuscarPorId(int id) => _context.Servicos.FirstOrDefault(x => x.Id == id);
        public static bool Cadastrar(Servico servico)
        {
            if (BuscarPorServico(servico.Nome) == null)
            {
                _context.Servicos.Add(servico);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public static void Remover(Servico servico)
        {
            _context.Servicos.Remove(servico);
            _context.SaveChanges();
        }
        public static void Alterar(Servico servico)
        {
            _context.Servicos.Update(servico);
            _context.SaveChanges();
        }
        public static List<Servico> Listar() => _context.Servicos.ToList();
    }
}
