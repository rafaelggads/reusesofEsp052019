using System;

namespace JaPediu
{
  class Program
  {
    static void Main()
    {
      var pedido = new Pedido();

      for(int i = 0; ;)
      {
        try
        {
          Console.Clear();
          Console.WriteLine("Total do pedido: " + pedido.getPreco());
          Console.Write("\nIncluir produto?\n\n\t1 - Prato A\n\t2 - Prato B\n\t3 - Concluir pedido\n\n-> ");

          string opcao = Console.ReadLine();

          if (opcao.Equals("3"))
          {
            break;
          }

          ProdutoFactory factory = new ProdutoFactory();

          var prato = factory.getInstance(opcao);
          pedido.addProduto(i, prato);

          while (true)
          {
            try
            {
              Console.Clear();
              Console.WriteLine("Total do pedido: " + pedido.getPreco());
              Console.Write("\nIncluir adicional?\n\n\t1 - Ovo\n\t2 - Cebola\n\t3 - Continuar\n\n-> ");

              string adicional = Console.ReadLine();

              if (adicional.Equals("3"))
              {
                break;
              }

              AdicionalFactory adicionalFactory = new AdicionalFactory();
              prato = adicionalFactory.getInstance(adicional, prato);

              pedido.replaceProduto(i, prato);
            }
            catch (Exception)
            {
              Console.Clear();
              Console.Write("Por favor digite 1, 2 ou 3!\nPressione enter pra continuar");
              Console.ReadLine();
            }
          }

          i++;
        }
        catch (Exception)
        {
          Console.Clear();
          Console.Write("Por favor digite 1, 2 ou 3!\nPressione enter pra continuar");
          Console.ReadLine();
        }
      }

      Console.Write("\nPreco total do pedido: " + pedido.getPreco() + "\n\nObrigado por usar o \"Já Pediu\"!!\nTelevendas: (62) 9 9395-4060\n");
      Console.ReadKey();
    }
  }
}
