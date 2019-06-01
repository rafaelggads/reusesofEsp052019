using System;

namespace JaPediu
{
  public class AdicionalFactory 
  {
    public Produto getInstance(string tipo, Produto produto)
    {
      switch (tipo)
      {
        case "1":
          return new OvoDecorator(produto);
        case "2":
          return new CebolaDecorator(produto);
        default:
          throw new Exception("Tipo inexistente");
      }
    }
  }
}
