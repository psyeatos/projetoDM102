namespace projetoPokemon
{
  public class Fruta : IItem
  {
    public string? tipo;
    public string? efeito;
    public int quantidade;

    public Fruta(string tipo, string efeito, int quantidade)
    {
      this.tipo = tipo;
      this.efeito = efeito;
      this.quantidade = quantidade;
    }
    public string Comprar()
    {
      quantidade++;
      return ($"Comprou uma {tipo}, com ela seu Pokémon não poderá ser {efeito}. Você tem {quantidade}.");
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