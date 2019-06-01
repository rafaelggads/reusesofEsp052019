using System;

namespace JaPediu
{
  public class ProdutoFactory 
  {
    public Produto getInstance(string tipo)
    {
        switch (tipo)
        {
          case "1":
            return new PratoA();
          case "2":
            return new PratoB();
          default:
            throw new Exception("Tipo inexistente");
      }
    }
  }
}
