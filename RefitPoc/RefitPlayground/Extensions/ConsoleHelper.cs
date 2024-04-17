using RefitClientPoc.ElixirsData;

namespace RefitPlayground.Extensions;

public static class ConsoleHelper {
    public static void WriteElixir(Elixir elixir) {
        Console.WriteLine($"Id: {elixir.Id}");
        Console.WriteLine($"Name:{elixir.Name}");
        Console.WriteLine($"Effect: {elixir.Effect}");
        Console.WriteLine($"Side effect: {elixir.SideEffects}");
        Console.WriteLine($"Characteristic: {elixir.Characteristics}");
        Console.WriteLine($"Time: {elixir.Time}");
        Console.WriteLine($"Difficulty: {elixir.Difficulty}");
        Console.WriteLine($"Manufacturer: {elixir.Manufacturer}");
        Console.WriteLine("Ingredients:");
        Console.WriteLine();
        foreach (var ingredient in elixir.Ingredients) {
            Console.WriteLine($"Ingredient id: {ingredient.Id}");
            Console.WriteLine($"Ingredient name: {ingredient.Name}");
            Console.WriteLine();
        }
        Console.WriteLine("Inventors:");
        Console.WriteLine();
        foreach (var inventor in elixir.Inventors) {
            Console.WriteLine($"Inventor id: {inventor.Id}");
            Console.WriteLine($"Inventor first name: {inventor.FirstName}");
            Console.WriteLine($"Inventor last name: {inventor.LastName}");
            Console.WriteLine();
        }
    }
}
