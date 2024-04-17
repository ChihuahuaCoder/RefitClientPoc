using RefitClientPoc;
using RefitPlayground.Extensions;

var felixFelicisId = new Guid("f552960d-dfe6-43f5-8239-63c35d6101ab");
var bruiseRemovalPasteId = new Guid("ae0f3421-1acf-4323-9822-d535261d949f");
var draughtOfPeaceId = new Guid("2bc0184a-65ad-4899-90b7-3c6ce1e3156e");

var client = new WizardWorldClient();

// var elixir = await client.GetElixir(bruiseRemovalPasteId);
// ConsoleHelper.WriteElixir(elixir);

var elixirs = await client.GetElixirs();
foreach (var elixir in elixirs) {
    ConsoleHelper.WriteElixir(elixir);
}
