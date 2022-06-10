namespace GeraEstoque
{
  class Program
  {

    static void Main(string[] args)
    {
      string titulo =
      @"Seja bem vindo(a) ao GeraEstoque 1.0
------------------------------------";
      System.Console.WriteLine(titulo);

      mostrarOpcoes();

    }

    public static void mostrarOpcoes()
    {
      string opcoes =
@"1 Cadastrar produto
2 Consultar produto
3 Modificar produto
4 Excluir produto
0 Sair";

      System.Console.WriteLine(opcoes);
      System.Console.WriteLine("Digite uma opção");
      CadastrarProduto();

      Console.ReadLine();

    }
    public static void CadastrarProduto()
    {
      // System.Console.WriteLine("Digite uma opção");
      var opcao = Console.ReadLine();

      // Console.WriteLine("Digite uma opção");


      switch (opcao)
      {
        case 1: Program.CadastrarProduto(); break;
        default: mostrarOpcoes(); break;
      }

      Console.ReadLine(opcao);
      mostrarOpcoes();
    }
  }
}

