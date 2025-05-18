using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebSuper.Models;

namespace WebSuper.Pages.Produtos
{
    public class IndexModel : PageModel
    {

        public List<Produto> Produtos { get; set; }
        public void OnGet()
        {
            Produtos = new List<Produto>();

            if (System.IO.File.Exists("produtos.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("produtos.txt");

                foreach (var linha in linhas)
                {
                    var dados = linha.Split(';');

                    Produto produto = new Produto();
                    produto.Id = int.Parse(dados[0]);
                    produto.Nome = dados[1];
                    produto.Preco = double.Parse(dados[2]);
                    produto.Estoque = int.Parse(dados[3]);

                    Produtos.Add(produto);
                }
            }
        }
    }
}
