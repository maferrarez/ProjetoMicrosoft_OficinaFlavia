using Oficina_Flavia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oficina_Flavia.DAL
{
    class CarroDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static Carro BuscarPorPlaca(string placa) => _context.Carros.FirstOrDefault(x => x.Placa == placa);
        public static Carro BuscarPorId(int id) => _context.Carros.FirstOrDefault(x => x.Id == id);
        public static List<Carro> ListarPorCliente(int idCliente) => _context.Carros.Where(x => x.Dono.Id == idCliente).ToList();

        public static bool Cadastrar(Carro carro)
        {
            if (BuscarPorPlaca(carro.Placa) == null)
            {
                _context.Carros.Add(carro);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public static void Remover(Carro carro)
        {
            _context.Carros.Remove(carro);
            _context.SaveChanges();
        }
        public static void Alterar(Carro carro)
        {
            _context.Carros.Update(carro);
            _context.SaveChanges();
        }
    }
}
