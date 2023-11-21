using MonkeyIsland;

Meer meer = new Meer("Karibik");
Schiff schiff = new Schiff("Santa Maria");
Console.WriteLine(meer.GetInseln()[0].GetName());
meer.SetSchiff(schiff);
Console.WriteLine($"Schiff auf Meer: {meer.GetSchiff().GetName()}");
//Console.WriteLine(meer.GetInseln()[1].GetName());
//das Meer wird zerstört
meer = null;
Console.WriteLine($"Schiff nach Meereszerstörung: {schiff.GetName()}");
//Console.WriteLine(meer.GetInseln()[0].GetName());
Pirat pirat = new Pirat("Guybrush Trebwood");
Orte orte = new Orte("Kneipe");
Console.WriteLine($" {orte.GetName()}");


//meer.SetPirat(pirat);
//Console.WriteLine($"Name Pirat: {pirat.GetName()}");
//Console.WriteLine($"Pirat im Meer: {meer.GetPirat().GetName()}");