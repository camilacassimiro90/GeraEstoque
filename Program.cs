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
  }
}