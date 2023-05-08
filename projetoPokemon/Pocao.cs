namespace projetoPokemon
{
  public class Pocao : IItem
  {
    public string? tipo;
    public int efeito;
    public int quantidade;

    public Pocao(string tipo, int efeito, int quantidade)
    {
      this.tipo = tipo;
      this.efeito = efeito;
      this.quantidade = quantidade;
    }
    public string Comprar()
    {
      quantidade++;
      return ($"Comprou uma {tipo} que aumentará {efeito} de vida.");
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