using facade_design_pattern.Enums;
using facade_design_pattern.Subsystems.Avengers;
using facade_design_pattern.Subsystems.JusticeLeagueAmerica;
using facade_design_pattern.Subsystems.Villains;

namespace facade_design_pattern.Facades;

public class SuperHeroFacade
{
    private readonly CaptainAmerica _captainAmerica = new();
    private readonly Hulk _hulk = new();
    private readonly Batman _batman = new();
    private readonly WonderWoman _wonderWoman = new();

    private void AvengersActions()
    {
        _hulk.Smash();
        _captainAmerica.Counterattack();
    }

    private void JusticeLeagueAmericaActions()
    {
        _batman.Investigate();
        _wonderWoman.Fight();
    }

    private void CrossoverJusticeLeagueAmericaAvengersActions()
    {
        _batman.Investigate();
        _hulk.Smash();
        _captainAmerica.Counterattack();
        _wonderWoman.Fight();
    }

    public void Combat(Villain villain)
    {
        villain.Attack();

        switch (villain.VillainType)
        {
            case EVillainType.Darkseid:
                JusticeLeagueAmericaActions();
                break;

            case EVillainType.Krona:
                CrossoverJusticeLeagueAmericaAvengersActions();
                break;

            case EVillainType.Thanos:
                AvengersActions();
                break;
 
            default:
                throw new ArgumentException("Vilão desconhecido!");
        }
    }
}
