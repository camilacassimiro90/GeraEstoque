namespace GeraEstoque.Screens
{
  public static class CriarProdutoScreen
  {
    public static void Iniciar()
    {
      CriarProdutoScreen.Iniciar();
      {
        string id;
        string descricao;
        int quantidade;
        double valorCompra;
        double valorVenda;
        char continua = 'S';
        Guid guid = Guid.NewGuid();

        do
        {
          Console.WriteLine("Cadastramento");

          Console.WriteLine("Insira a descrição do produto:");
          descricao = Console.ReadLine();

          Console.WriteLine("Insira a quantidade:");
          quantidade = int.Parse(Console.ReadLine());

          Console.WriteLine("insira o valor de compra:");
          valorCompra = double.Parse(Console.ReadLine());

          Console.WriteLine("insira o valor de venda:");
          valorVenda = double.Parse(Console.ReadLine());

          Console.WriteLine("Deseja continuar? (S/N)");
          continua = Convert.ToChar(Console.ReadLine());

          id = guid.ToString();

        } while (continua == 'S');

        Console.Clear();

        Console.WriteLine("Produto cadastrado com sucesso!");

        Console.WriteLine($"Nome: {descricao}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"{valorCompra}");
        Console.WriteLine($"{valorVenda}");
        Console.WriteLine($"id: {id}");
      }

    }

  }
}