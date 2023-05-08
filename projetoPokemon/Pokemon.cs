namespace projetoPokemon
{
  public class Pokemon
  {
    public string? nome;
    public string? tipo;
    public int nivel;
    Ataque? ataque;

    public Pokemon(string nome, string tipo, int nivel, string tipo2, string efeito, int dano)
    {
      this.nome = nome;
      this.tipo = tipo;
      this.nivel = nivel;
      ataque = new Ataque(tipo2, efeito, dano);
    }
    public string Dados()
    {
      return $"NOME: {nome} || TIPO: {tipo} || NÍVEL {nivel}.";
    }

    public Ataque GetAtaque()
    {
      return ataque;
    }
    public void SetAtaque(Ataque ataque)
    {
      this.ataque = ataque;
    }
  }
}