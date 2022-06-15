using GeraEstoque.Screens;
namespace GeraEstoque
{
  class Program
  {

    static void Main(string[] args)
    {
      MenuScreen.Iniciar();
    }

    public static void MostrarOpcoes()
    {
      string opcoes =
@"1 Cadastrar produto
2 Consultar produto
3 Modificar produto
4 Excluir produto
0 Sair";

      System.Console.WriteLine(opcoes);
      System.Console.WriteLine("Digite uma opção");
    }

    static void criarGuid()
    {
      Guid guid = Guid.NewGuid();
    }
  }
}

