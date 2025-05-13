using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSuper.Pages
{
    public class ProdutoModel : PageModel
    {

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public void OnGet()
        {
            Nome = "Frete Dedicado";
            Preco = 50000;
            Estoque = 1000;
        }
    }
}
