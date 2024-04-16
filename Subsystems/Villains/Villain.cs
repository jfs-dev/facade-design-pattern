using facade_design_pattern.Enums;

namespace facade_design_pattern.Subsystems.Villains;

public class Villain(EVillainType villainType)
{
    public EVillainType VillainType { get; private set; } = villainType;

    public void Attack() => Console.WriteLine($"{ VillainType } atacando!");
}
