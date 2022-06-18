using GeraEstoque.Repositories;
using GeraEstoque.Screens;
namespace GeraEstoque
{
  class Program
  {

    static void Main(string[] args)
    {
      var repository = new ProdutoRepository();
      MenuScreen.Iniciar(repository);
    }
  }
}

