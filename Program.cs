using facade_design_pattern.Enums;
using facade_design_pattern.Facades;
using facade_design_pattern.Subsystems.Villains;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Facade Design Pattern");
Console.WriteLine("---------------------");
Console.ForegroundColor = ConsoleColor.Magenta;

SuperHeroFacade superHeroFacade = new();
superHeroFacade.Combat(new Villain(EVillainType.Krona));

Console.WriteLine();
superHeroFacade.Combat(new Villain(EVillainType.Darkseid));

Console.WriteLine();
superHeroFacade.Combat(new Villain(EVillainType.Thanos));
