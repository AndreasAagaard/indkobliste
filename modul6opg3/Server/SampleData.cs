using modul6opg3.Client.Shared;

namespace modul6opg3.Server
{
    public class SampleData
    {
        public readonly static ShoppingItem[] BageListe = new[]
        {
            new ShoppingItem { Title = "Mælk", IsDone = false },
            new ShoppingItem { Title = "Æg", IsDone = false },
            new ShoppingItem { Title = "Hvedemel", IsDone = false },
            new ShoppingItem { Title = "Sukker", IsDone = false },
            new ShoppingItem { Title = "Bagepulver", IsDone = false },
            new ShoppingItem { Title = "Vanillesukker", IsDone = false },
            new ShoppingItem { Title = "Gær", IsDone = false },
        };

        public readonly static ShoppingItem[] FestListe = new[]
{
            new ShoppingItem { Title = "Øl", IsDone = false },
            new ShoppingItem { Title = "Chips", IsDone = false },
            new ShoppingItem { Title = "Saltstænger", IsDone = false },
            new ShoppingItem { Title = "Sodavand", IsDone = false },
            new ShoppingItem { Title = "Vin", IsDone = false },
            new ShoppingItem { Title = "Gin", IsDone = false },
            new ShoppingItem { Title = "Tonic", IsDone = false },
        };

        public readonly static ShoppingItem[] BabyListe = new[]
{
            new ShoppingItem { Title = "Bleer", IsDone = false },
            new ShoppingItem { Title = "Vådservietter", IsDone = false },
            new ShoppingItem { Title = "Skumklude", IsDone = false },
            new ShoppingItem { Title = "Bleposer", IsDone = false },
            new ShoppingItem { Title = "Klemmesmoothies", IsDone = false },
            new ShoppingItem { Title = "Modersmælkerstatning", IsDone = false },
        };
    }
}

