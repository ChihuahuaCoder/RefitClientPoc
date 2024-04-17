namespace RefitClientPoc.ElixirsData;

public class Elixir {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Effect { get; set; }
    public string SideEffect { get; set; }
    public string Characteristic { get; set; }
    public string Time { get; set; }
    public Difficulty Difficulty { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; }
    public ICollection<Inventor> Inventors { get; set; }
    public string Manufacturer { get; set; }
}
