namespace JaPediu
{
  public class OvoDecorator : Produto
  {
    private Produto _prod;

    public OvoDecorator(Produto prod)
    {
      _prod = prod;
    }

    public double getPreco()
    {
      return 1.5 + _prod.getPreco();
    }
  }
}
