namespace projetoPokemon
{
  public class Treinador
  {
    public string? nome;
    public int id;
    public string? favorito;

    public Treinador(string nome, int id, string favorito)
    {
      this.nome = nome;
      this.id = id;
      this.favorito = favorito;
    }
    public string Dados()
    {
      return $"NOME: {nome} || ID: {id} || POKÉMON FAVORITO: {favorito}.";
    }
  }
}