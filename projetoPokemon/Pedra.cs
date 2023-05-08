namespace projetoPokemon
{
  public class Pedra
  {
    public string? tipo;
    public string? efeito;
    public int quantidade;

    public Pedra(string tipo, string efeito, int quantidade)
    {
      this.tipo = tipo;
      this.efeito = efeito;
      this.quantidade = quantidade;
    }
    public string Comprar()
    {
      quantidade++;
      return ($"Comprou uma {tipo}, você tem {quantidade}. Com ela você poderá {efeito}.");
    }
    public string Vender()
    {
      if (quantidade == 0)
      {
        return ($"Você não tem uma pedra {tipo} para vender.");
      }
      else
      {
        quantidade--;
        return ($"Vendeu uma pedra {tipo}, você tem {quantidade}.");
      }
    }
  }
}