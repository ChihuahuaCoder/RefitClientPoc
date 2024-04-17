using RefitClientPoc;

//Felix Felicis: f552960d-dfe6-43f5-8239-63c35d6101ab
//Bruise removal paste ae0f3421-1acf-4323-9822-d535261d949f
//Draught of Peace 2bc0184a-65ad-4899-90b7-3c6ce1e3156e

var client = new WizardWorldClient();
var elixir = await client.GetElixir(Guid.NewGuid());

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
