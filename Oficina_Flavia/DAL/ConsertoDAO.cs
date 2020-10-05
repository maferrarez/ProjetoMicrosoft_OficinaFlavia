using Oficina_Flavia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oficina_Flavia.DAL
{
    class ConsertoDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        
        public static void Cadastrar(Conserto conserto)
        {
            _context.Consertos.Add(conserto);
            _context.SaveChanges();
        }


    }
}
