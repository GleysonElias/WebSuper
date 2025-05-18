using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebSuper.Models;

namespace WebSuper.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        public List<Usuario> Usuarios { get; set; }
        public void OnGet()
        {
            Usuarios = new List<Usuario>();

            if (System.IO.File.Exists("usuarios.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("usuarios.txt");

                foreach (var linha in linhas)
                {
                    var dados = linha.Split(';');

                    Usuario usuario = new Usuario();
                    usuario.Id = int.Parse(dados[0]);
                    usuario.Nome = dados[1];
                    usuario.Senha = dados[2];
                    usuario.Email = dados[3];

                    Usuarios.Add(usuario);
                }
            }
        }
    }
}
