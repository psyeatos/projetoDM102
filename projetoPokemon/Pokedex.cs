namespace projetoPokemon
{
  public class Pokedex
  {
    public string? regiao;
    public string? geracao;
    public int quantidade_pokemons;

    public Pokedex(string regiao, string geracao, int quantidade_pokemons)
    {
      this.regiao = regiao;
      this.geracao = geracao;
      this.quantidade_pokemons = quantidade_pokemons;
    }
    public string InfoPokedex()
    {
      return $"Essa pokedex é da {geracao} que se passa em {regiao}. A quantidade de Pokémons presentes nessa região é de {quantidade_pokemons}";
    }
  }
}