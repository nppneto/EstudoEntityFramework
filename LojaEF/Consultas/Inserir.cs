using LojaEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaEF.Consultas
{
    class Inserir
    {
        static void Main(string[] args)
        {
            // inserindo e consultando todos no banco
            EntidadesContext contexto = new EntidadesContext();
            Usuario u = new Usuario()
            {
                Nome = "Natasha",
                Senha = "123"
            };

            contexto.Usuarios.Add(u);
            contexto.SaveChanges();

            foreach (var usuario in contexto.Usuarios)
            {
                Console.WriteLine(usuario.Nome + " - " + usuario.ID);
            }

            Console.Read();
        }
    }
}
