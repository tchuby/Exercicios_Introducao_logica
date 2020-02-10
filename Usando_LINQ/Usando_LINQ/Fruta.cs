namespace Usando_LINQ
{
    /// <summary>
    /// Fruta - Define a classe furta com: Name, Color and Price.
    /// </summary>
    public class Fruta
    {
        public Fruta(string name, string color, int price)
        {
            Name = name;
            Color = color;
            Price = price;
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }
}
