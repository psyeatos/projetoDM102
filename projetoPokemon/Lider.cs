namespace projetoPokemon
{
  public class Lider : Treinador
  {
    public string? cidade;
    public string? tipo;
    public string? insignia;

    public Lider(string nome, int id, string favorito, string cidade, string tipo, string insignia)
      : base(nome, id, favorito)
    {
      this.cidade = cidade;
      this.tipo = tipo;
      this.insignia = insignia;
    }
    public string DarInsigna()
    {
      return $"{nome} é da cidade de {cidade} e usa o tipo {tipo} para defender seu ginásio";
    }
  }
}