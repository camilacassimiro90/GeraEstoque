using GeraEstoque.Repositories;

namespace GeraEstoque.Screens
{
  public static class MenuScreen
  {
    public static void Iniciar()
    {
      Console.Clear();

      System.Console.WriteLine("Seja bem vindo(a)!");
      System.Console.WriteLine("----------------------------");
      System.Console.WriteLine(@"
1 - Cadastrar Produto
2 - Consultar Produto
3 - Modificar Produto
4 - Excluir Produto
5 - Listar Produtos
0 - Sair
    ");

      System.Console.WriteLine("Selecione uma opção");
      var opcao = short.Parse(Console.ReadLine()!);

      switch (opcao)
      {
        case 1: CriarProdutoScreen.Iniciar(repository); Iniciar(repository); break;
        case 5: ListarProdutosScreen.Iniciar(repository); Iniciar(repository); break;
        default: Environment.Exit(0); break;
      };
    }
  }
}

