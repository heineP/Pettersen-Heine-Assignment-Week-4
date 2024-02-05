namespace FantasyGame.Character;

public class Rogue : Character
{
    // CONSTRUCTOR
    public Rogue(string aName) : base(aName)
    {
        this.classAbility = "You emerge from the shadows";
        this.description = "Stealthy assassin";
    }
}
