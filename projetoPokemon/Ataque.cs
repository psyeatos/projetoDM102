namespace projetoPokemon
{
  public class Ataque
  {
    public string? tipo;
    public string? efeito;
    public int dano;

    public Ataque(string tipo, string efeito, int dano)
    {
      this.tipo = tipo;
      this.efeito = efeito;
      this.dano = dano;
    }
    public string Usar(string nome)
    {
      return ($"{nome} usou o ataque {tipo}, deu {dano} de dano e causou {efeito} como efeito.");
    }
  }
}