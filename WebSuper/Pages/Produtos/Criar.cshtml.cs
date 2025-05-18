using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebSuper.Models;

namespace WebSuper.Pages.Produtos
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Produto produto { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                using (var writer = new StreamWriter("produtos.txt", true))
                {
                    writer.WriteLine(produto.Id + ";" + produto.Nome + ";" + produto.Preco + ";" + produto.Estoque);
                    return RedirectToPage("Index");
                }
            }
            return Page();
        }
    }
}
