namespace JaPediu
{
  public class CebolaDecorator : Produto
  {
    private Produto _prod;

    public CebolaDecorator(Produto prod)
    {
      _prod = prod;
    }

    public virtual double getPreco()
    {
      return 1.0 + _prod.getPreco();
    }
  }
}
