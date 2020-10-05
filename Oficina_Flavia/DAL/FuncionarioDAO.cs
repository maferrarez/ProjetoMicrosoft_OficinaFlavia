using Oficina_Flavia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oficina_Flavia.DAL
{
    class FuncionarioDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static Funcionario BuscarPorNome(string nome) => _context.Funcionarios.FirstOrDefault(x => x.Nome == nome);
        public static Funcionario BuscarPorId(int id) => _context.Funcionarios.FirstOrDefault(x => x.Id == id);
        public static bool Cadastrar(Funcionario funcionario)
        {
            if (BuscarPorNome(funcionario.Nome) == null)
            {
                _context.Funcionarios.Add(funcionario);
                _context.SaveChanges();

                return true;
            }
            return false;
        }

        public static void Alterar(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            _context.SaveChanges();
        }

        public static void Remover(Funcionario funcionario)
        {

            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();
        }

        public static List<Funcionario> Listar() => _context.Funcionarios.ToList();

    }
}
