using System.Text.Json;
using Refit;
using RefitClientPoc;
using RefitClientPoc.Elixirs;

// {
//     "id": "8d65a9dd-ba59-4095-83da-95929fc0c582",
//     "name": "Fire-Protection Potion",
//     "effect": "Protects drinker from fire",
//     "sideEffects": "Sensation of ice flooding body",
//     "characteristics": "Blue in colour",
//     "time": null,
//     "difficulty": "Beginner",
//     "ingredients": [
//     {
//         "id": "0ce74d14-196d-4b07-b3d1-edfe8a0dc5e7",
//         "name": "Salamander blood"
//     },
//     {
//         "id": "22ed69d1-0478-43ca-98a6-8e260daed784",
//         "name": "Bursting mushrooms"
//     },
//     {
//         "id": "cf2db441-f39f-42ac-8716-54d4c758aa18",
//         "name": "Wartcap powder"
//     }
//     ],
//     "inventors": [],
//     "manufacturer": null
// }

// Weasleys' Wizard Wheezes

var felixFelicisId = new Guid("f552960d-dfe6-43f5-8239-63c35d6101ab");
var bruiseRemovalPasteId = new Guid("ae0f3421-1acf-4323-9822-d535261d949f");
var draughtOfPeaceId = new Guid("2bc0184a-65ad-4899-90b7-3c6ce1e3156e");

var client = WizardWorldApiFactory.Create();
// var client = RestService.For<IWizardWorldApi>("https://wizard-world-api.herokuapp.com");

var elixirById = await client.GetElixir(felixFelicisId);

var queryParams = new ElixirsQueryParams {
    Name = "Fire-Protection Potion"
};

// var elixirs = await client.GetElixirs(queryParams);
// Console.WriteLine(JsonSerializer.Serialize(elixirs, new JsonSerializerOptions {
//     WriteIndented = true
// }));

// var feedback = new Feedback {
//     Id = Guid.NewGuid(),
//     Message = "My test 123",
//     Type = FeedbackType.Suggestion
// };
//
// await client.PostFeedback(feedback);
