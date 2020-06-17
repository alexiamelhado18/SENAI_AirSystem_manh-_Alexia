using ProjetoEstudoTaskool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoTaskool.Repositories
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;
        
        private static int contador = 1;

        
        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    Codigo = 1,
                    Nome = "Alexia",
                    Email = "alexia@email",
                    Senha = "1234",
                    Telefone = "123456789",
                    UserName = "Ale"
                }
               );
                contador++;
                usuarios.Add(new Usuario
                {
                    Codigo = 2,
                    Nome = "Junior",
                    Email = "junior@gmail",
                    Senha = "1234",
                    Telefone = "123456789",
                    UserName = "junnin"

                }
                );
                contador++;
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }
        public void adicionar(Usuario usuario)
        {
            usuario.Codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }
        public void editar(Usuario usuario)
        {

            Usuario u = usuarios.Find(x => x.Codigo == usuario.Codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        
        public void deletar(int codigo)
        {
            Usuario usuario = usuarios.Find(x => x.Codigo == codigo);

            usuarios.Remove(usuario);
        }
    }
}

