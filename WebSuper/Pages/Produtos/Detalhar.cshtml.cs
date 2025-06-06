using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebSuper.Models;

namespace WebSuper.Pages.Produtos
{
    public class DetalharModel : PageModel
    {
        public Produto produto { get; set; }
        public IActionResult OnGet(int id)
        {
            var produtos = carregarProdutos();

            produto = produtos.FirstOrDefault(produto => produto.Id == id);

            if (produto == null)
            {
                return RedirectToPage("/Produtos/Index");
            }
            else
            {
                return Page();
            }

        }
      

        public List<Produto> carregarProdutos()
            {
            var produtos = new List<Produto>();

            if (System.IO.File.Exists("produtos.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("produtos.txt");

                foreach (var linha in linhas)
                {
                    var dados = linha.Split(";");
                    var produto = new Produto
                    {
                        Id = int.Parse(dados[0]),
                        Nome = dados[1],
                        Preco = double.Parse(dados[2]),
                        Estoque = int.Parse(dados[3])
                    };

                    produtos.Add(produto);
                }
            }
            return produtos;
        }
    }
}
