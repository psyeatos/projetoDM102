namespace projetoPokemon
{
  public class Revive : IItem
  {
    public string? tipo;
    public string? efeito;
    public int quantidade;

    public Revive(string tipo, string efeito, int quantidade)
    {
      this.tipo = tipo;
      this.efeito = efeito;
      this.quantidade = quantidade;
    }
    public string Comprar()
    {
      quantidade++;
      return ($"Comprou um {tipo} com ele você poderá {efeito} seu Pokémon.");
    }
    public string Vender()
    {
      if (quantidade == 0)
      {
        return ($"Você não tem {tipo} para vender.");
      }
      else
      {
        quantidade--;
        return ($"Vendeu uma {tipo}, você tem {quantidade}.");
      }
    }
  }
}