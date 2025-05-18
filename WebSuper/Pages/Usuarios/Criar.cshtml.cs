using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebSuper.Models;

namespace WebSuper.Pages.Usuarios
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Usuario usuario {  get; set; } // Objeto vai ser armazenado no arquivo
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                using(var writer = new StreamWriter("usuarios.txt", true))
                {
                    /*
                    writer.WriteLine(usuario.Nome);
                    writer.WriteLine(usuario.Senha);
                    writer.WriteLine(usuario.Email);
                    */
                    writer.WriteLine(usuario.Id + ";" + usuario.Nome + ";" + usuario.Senha + ";" + usuario.Email);
                    return RedirectToPage("Index");
                }
            }
            return Page();
        }
    }
}
