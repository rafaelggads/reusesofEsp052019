using System.Collections.Generic;
using System.Linq;

namespace JaPediu
{
  public class Pedido
  {
    private IList<Produto> produtos;

    public Pedido()
    {
      produtos = new List<Produto>();
    }

    public void addProduto(int index, Produto prod)
    {
      produtos.Insert(index, prod);
    }

    public void replaceProduto(int index, Produto prod)
    {
      produtos.RemoveAt(index);
      produtos.Insert(index, prod);
    }

    public double getPreco()
    {
      return produtos.Sum(e => e.getPreco());
    }
  }
}
