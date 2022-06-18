using GeraEstoque.Models;
using GeraEstoque.Repositories;
namespace GeraEstoque.Screens;


class ListarProdutosScreen
{
  public static void Iniciar(ProdutoRepository repository)
  {
    Console.Clear();
    System.Console.WriteLine("Lista de Produtos Cadastrados");
    System.Console.WriteLine("--------------------------------");
    foreach (var produto in repository.Produtos)
    {
      System.Console.WriteLine(produto.ToString());
    }
    Console.ReadLine();
  }
}