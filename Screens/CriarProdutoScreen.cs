using GeraEstoque.Repositories;
using GeraEstoque.Models;

namespace GeraEstoque.Screens;
public static class CriarProdutoScreen
{
  public static void Iniciar(ProdutoRepository repository)
  {
    Console.Clear();
    System.Console.Write("Nome do produto: ");
    string nome = Console.ReadLine();
    System.Console.Write("Quantidade em estoque: ");
    int qtd = int.Parse(Console.ReadLine()!);
    System.Console.Write("Valor de compra: ");
    int valorCompra = int.Parse(Console.ReadLine()!);
    System.Console.Write("Valor de venda: ");
    int valorVenda = int.Parse(Console.ReadLine()!);
    string id = Guid.NewGuid().ToString();

    var produto = new Produto(nome!, qtd, valorCompra, valorVenda);
    System.Console.WriteLine("Produto cadastrado com sucesso!");
    repository.Produtos.Add(produto);
    Console.ReadLine();
  }
  static void criarGuid()
  {
    Guid guid = Guid.NewGuid();
  }
}
