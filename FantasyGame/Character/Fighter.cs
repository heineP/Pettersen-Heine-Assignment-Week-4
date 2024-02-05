namespace FantasyGame.Character;

public class Fighter : Character
{
    // CONSTRUCTOR
    public Fighter(string aName) : base(aName)
    {
        this.classAbility = "You charge";
        this.description = "A fierce Fighter!";
    }
}
