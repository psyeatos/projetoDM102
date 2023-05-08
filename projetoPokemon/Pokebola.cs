namespace projetoPokemon
{
  public class Pokebola : IItem
  {
    public string? tipo;
    public string? efeito;
    public int quantidade;

    public Pokebola(string tipo, string efeito, int quantidade)
    {
      this.tipo = tipo;
      this.efeito = efeito;
      this.quantidade = quantidade;
    }
    public string Comprar()
    {
      quantidade++;
      return ($"Comprou uma {tipo} com ela {efeito}, você tem {quantidade}.");
    }
    public string Vender()
    {
      if (quantidade == 0)
      {
        return ($"Você não tem uma {tipo} para vender.");
      }
      else
      {
        quantidade--;
        return ($"Vendeu uma pedra {tipo}, você tem {quantidade}.");
      }
    }
  }
}