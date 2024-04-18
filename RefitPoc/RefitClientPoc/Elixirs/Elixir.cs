namespace RefitClientPoc.Elixirs;

public class Elixir {
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Effect { get; set; }
    public string? SideEffects { get; set; }
    public string? Characteristics { get; set; }
    public string? Time { get; set; }
    public Difficulty? Difficulty { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; } = Array.Empty<Ingredient>();
    public ICollection<Inventor> Inventors { get; set; } = Array.Empty<Inventor>();
    public string? Manufacturer { get; set; }
}
