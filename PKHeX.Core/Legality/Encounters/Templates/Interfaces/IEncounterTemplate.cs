namespace PKHeX.Core;

/// <summary>
/// Represents all details that an entity may be encountered with.
/// </summary>
public interface IEncounterTemplate : ISpeciesForm, IVersion, IGeneration, IShiny, ILevelRange, ILocation, IFixedAbilityNumber, IFixedBall, IShinyPotential, IContext
{
    /// <summary>
    /// Indicates if the encounter originated as an egg.
    /// </summary>
    bool IsEgg { get; }
}

public static partial class Extensions
{
    public static bool IsWithinEncounterRange(this IEncounterTemplate encounter, PKM pk)
    {
        var level = pk.CurrentLevel;
        if (!pk.HasOriginalMetLocation)
            return encounter.IsLevelWithinRange(level);
        if (encounter.IsEgg)
            return level == encounter.LevelMin;
        if (encounter is IMetLevel)
            return encounter.IsLevelWithinRange(level);
        var met = pk.MetLevel;
        if (met != 0)
            return level == met;
        return encounter.IsLevelWithinRange(level);
    }
}
