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

      string opcoes =
      @"1 Cadastrar produto
2 Consultar produto
3 Modificar produto
4 Excluir produto
0 Sair
      
Digite a opção:";

      System.Console.WriteLine(opcoes);

    }
    public static void CadastrarProduto();
    {
      var opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1: Program.CadastrarProduto; break;
        default: Console.WriteLine(opcoes); break;
      }

      Console.ReadLine()
    }

}
}