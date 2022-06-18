using GeraEstoque.Models;

namespace GeraEstoque.Repositories;

public class ProdutoRepository
{
  public IList<Produto> Produtos { get; set; }

  public ProdutoRepository()
  {
    Produtos = new List<Produto>();
  }
}