namespace projetoPokemon
{
  public class Program
  {
    static void Main(string[] args)
    {
      /* Criação de pokedex */
      Pokedex pokedex = new Pokedex("primeira", "Kanto", 151);
      Console.WriteLine(pokedex.InfoPokedex());

      /* Criação do treinador */
      Treinador treinador = new Treinador("Ash Ketchum", 1, "Pikachu");
      Console.WriteLine(treinador.Dados());

      /* Criação do líder de ginásio */
      Lider lider = new Lider("Brock", 2, "Onix", "Pewter City", "pedra", "Boulder Badge");
      Console.WriteLine(lider.Dados());
      Console.WriteLine(lider.DarInsigna());

      /* Criação de Pokémons */
      Pokemon pokemon = new Pokemon("Pikachu", "elétrico", 30, "choque do trovão", "paralisia", 100);
      Pokemon pokemon2 = new Pokemon("Bulbasaur", "grama", 15, "folha navalha", "nada", 80);
      Console.WriteLine(pokemon.Dados());
      Console.WriteLine(pokemon2.Dados());
      Console.WriteLine(pokemon.GetAtaque().Usar(pokemon.nome));
      Console.WriteLine(pokemon2.GetAtaque().Usar(pokemon2.nome));

      /* Criação de frutas */
      Fruta fruta = new Fruta("Cheri Berry", "paralisado", 5);
      Console.WriteLine(fruta.Vender());
      Console.WriteLine(fruta.Comprar());

      /* Criação de pedras */
      Pedra pedra = new Pedra("Stardust", "aumentar o nível do seu Pokémon", 3);
      Console.WriteLine(pedra.Vender());
      Console.WriteLine(pedra.Comprar());

      /* Criação de poção */
      Pocao pocao = new Pocao("Super poção", 50, 10);
      Console.WriteLine(pocao.Vender());
      Console.WriteLine(pocao.Comprar());

      /* Criação de pokebola */
      Pokebola pokebola = new Pokebola("Masterball", "você pegará qualquer Pokémon de primeira!", 0);
      Console.WriteLine(pokebola.Vender());
      Console.WriteLine(pokebola.Comprar());

      /* Criação de revive */
      Revive revive = new Revive("MaxRevive", "reviver com vida máxima", 1);
      Console.WriteLine(revive.Vender());
      Console.WriteLine(revive.Comprar());
    }
  }
}