using System;

class Pokemon
{
    public string name;
    public int id;
    public string type1;
    public string type2;
    public float height;
    public float weight;
    public string ability1;
    public string ability2;
    public string hiddenAbility;
    public int hp;
    public int attack;
    public int defense;
    public int specialAttack;
    public int specialDefense;
    public int speed;
    public string[] moves;
    public string genderRatio;
    public int evolutionLevel;

    public Pokemon(string name, int id, string type1, string type2, float height, float weight, string ability1, string ability2, string hiddenAbility, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed, string[] moves, string genderRatio, int evolutionLevel)
    {
        this.name = name;
        this.id = id;
        this.type1 = type1;
        this.type2 = type2;
        this.height = height;
        this.weight = weight;
        this.ability1 = ability1;
        this.ability2 = ability2;
        this.hiddenAbility = hiddenAbility;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
        this.specialAttack = specialAttack;
        this.specialDefense = specialDefense;
        this.speed = speed;
        this.moves = moves;
        this.genderRatio = genderRatio;
        this.evolutionLevel = evolutionLevel;
    }
}

class Pokedex
{
    static void Main(string[] args)
    {
        Pokemon bisasam = new Pokemon("Bisasam", 1, "Pflanze", "Gift", 0.7f, 6.9f, "Notdünger", null, "Chlorophyll", 45, 49, 49, 65, 65, 45, new string[] { "Tackle", "Rankenhieb", "Giftschock", "Schlafpuder" }, "87.5% ♂, 12.5% ♀", 1);
        Pokemon bisaknosp = new Pokemon("Bisaknosp", 2, "Pflanze", "Gift", 1.0f, 13.0f, "Notdünger", null, "Chlorophyll", 60, 62, 63, 80, 80, 60, new string[] { "Tackle", "Rankenhieb", "Giftschock", "Schlafpuder" }, "87.5% ♂, 12.5% ♀", 16);
        Pokemon bisaflor = new Pokemon("Bisaflor", 3, "Pflanze", "Gift", 2.0f, 100.0f, "Notdünger", null, "Chlorophyll", 80, 82, 83, 100, 100, 80, new string[] { "Tackle", "Rankenhieb", "Giftschock", "Solarstrahl" }, "87.5% ♂, 12.5% ♀", 32);
        Pokemon glumanda = new Pokemon("Glumanda", 4, "Feuer", null, 0.6f, 8.5f, "Großbrand", null, "Solar Power", 39, 52, 43, 60, 50, 65, new string[] {"Kratzer", "Glut, Ruckzuckhieb"}""87.5% ♂, 12.5% ♀",1);
        Pokemon glutexo = new Pokemon("Glutexo", 5, "Feuer", null, 1.1f, 19.0f, "Großbrand", null, "Solar Power", 58, 64, 58, 80, 65, 80, new string[] { "Kratzer", "Glut", "Ruckzuckhieb", "Drachenwut" }, "87.5% ♂, 12.5% ♀", 16);
        Pokemon glurak = new Pokemon("Glurak", 6, "Feuer", "Flug", 1.7f, 90.5f, "Großbrand", null, "Solar Power", 78, 84, 78, 109, 85, 100, new string[] { "Kratzer", "Glut", "Ruckzuckhieb", "Flammenwurf" }, "87.5% ♂, 12.5% ♀", 36);
        Pokemon schiggy = new Pokemon("Schiggy", 7, "Wasser", null, 0.5f, 9.0f, "Sturzbach", null, "Regengenuss", 44, 48, 65, 50, 64, 43, new string[] { "Tackle", "Aquaknarre", "Rutenschlag", "Blubber" }, "87.5% ♂, 12.5% ♀", 1);
        Pokemon schillok = new Pokemon("Schillok", 8, "Wasser", null, 1.0f, 22.5f, "Sturzbach", null, "Regengenuss", 59, 63, 80, 65, 80, 58, new string[] { "Tackle", "Aquaknarre", "Rutenschlag", "Blubber" }, "87.5% ♂, 12.5% ♀", 16);
        Pokemon turtok = new Pokemon("Turtok", 9, "Wasser", null, 1.6f, 85.5f, "Sturzbach", null, "Regengenuss", 79, 83, 100, 85, 105, 78, new string[] { "Tackle", "Aquaknarre", "Rutenschlag", "Hydropumpe" }, "87.5% ♂, 12.5% ♀", 36);
        Pokemon raupy = new Pokemon("Raupy", 10, "Käfer", null, 0.3f, 2.9f, "Giftdorn", null, "Puderabwehr", 45, 30, 35, 20, 20, 45, new string[] { "Fadenreißer", "Käferbiss", "Giftstachel", "Käfergebrumm" }, "50% ♂, 50% ♀", 7);
        Pokemon safcon = new Pokemon("Safcon", 11, "Käfer", null, 0.7f, 9.9f, "Menschlichkeit", null, "Puderabwehr", 50, 20, 55, 25, 25, 30, new string[] { "Fadenreißer", "Käferbiss", "Giftstachel", "Käfergebrumm" }, "50% ♂, 50% ♀", 7);
        Pokemon sanktacho = new Pokemon("Sanktacho", 12, "Käfer", "Gift", 1.1f, 29.5f, "Menschlichkeit", null, "Puderabwehr", 60, 45, 50, 90, 80, 70, new string[] { "Giftstachel", "Käferbiss", "Schlafpuder", "Psychoklinge" }, "50% ♂, 50% ♀", 10);
        Pokemon hornliu = new Pokemon("Hornliu", 13, "Käfer", "Gift", 0.3f, 3.2f, "Giftdorn", null, "Schwebedurch", 30, 40, 55, 25, 30, 50, new string[] { "Giftstachel", "Käferbiss", "Furienschlag", "Schlafpuder" }, "50% ♂, 50% ♀", 7);
        Pokemon kokuna = new Pokemon("Kokuna", 14, "Käfer", "Gift", 0.6f, 10.0f, "Hautwechsel", null, null, 45, 25, 50, 25, 25, 35, new string[] { "Giftstachel", "Härtner", null, null }, "50% ♂, 50% ♀", 10);
        Pokemon bibor = new Pokemon("Bibor", 15, "Käfer", "Gift", 1.0f, 29.5f, "Giftdorn", null, "Hexapod", 65, 80, 50, 40, 50, 75, new string[] { "Giftstachel", "Käferbiss", "Furienschlag", "Schlafpuder" }, "50% ♂, 50% ♀", 16);
        Pokemon taubsi = new Pokemon("Taubsi", 16, "Normal", "Flug", 0.3f, 1.8f, "Speziesbonus", null, "Adlerauge", 40, 45, 40, 35, 35, 56, new string[] { "Ruckzuckhieb", "Windhose", null, null }, "50% ♂, 50% ♀", 1);
        Pokemon tauboga = new Pokemon("Tauboga", 17, "Normal", "Flug", 1.1f, 30.0f, "Speziesbonus", null, "Adlerauge", 55, 50, 55, 50, 50, 71, new string[] { "Ruckzuckhieb", "Windhose", null, null }, "50% ♂, 50% ♀", 18);
        Pokemon tauboss = new Pokemon("Tauboss", 18, "Normal", "Flug", 1.5f, 39.5f, "Speziesbonus", null, "Adlerauge", 80, 75, 75, 70, 70, 91, new string[] { "Ruckzuckhieb", "Windhose", "Bohrschnabel", "Flügelschlag" }, "50% ♂, 50% ♀", 36);
        











static void SearchPokedex()
    {
        Console.WriteLine("Enter the name of the Pokemon:");
        string pokemonName = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < 150; i++)
        {
            if (pokedex[i].name.Equals(pokemonName, StringComparison.InvariantCultureIgnoreCase))
            {
                pokedex[i].Display();
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Pokemon not found.");
        }
        Console.WriteLine();
    }

    static void DisplayAllPokemon()
    {
        for (int i = 0; i < 150; i++)
        {
            Console.WriteLine(pokedex[i].name);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        InitializePokedex();

        while (true)
        {
            Console.WriteLine("Pokedex Menu");
            Console.WriteLine("1. Search for a Pokemon");
            Console.WriteLine("2. Display all Pokemon");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SearchPokedex();
                    break;
                case 2:
                    DisplayAllPokemon();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}