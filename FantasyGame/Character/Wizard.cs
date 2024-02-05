using FantasyGame.Spells;

namespace FantasyGame.Character;

public class Wizard : Character
{
    // FIELDS
    public Fireball _classAbility =  new Fireball();
    
    // CONSTRUCTOR
    public Wizard(string aName) : base(aName)
    {
        this.description = "Pumper Mage";
    }
    
    // METHOD Attack()
    public override void Attack()
    {
        Random rnd = new Random();
        Console.WriteLine($"You launch a {_classAbility.description} at your enemy.");
        Console.WriteLine($"You deal {rnd.Next(_classAbility.minDamage, _classAbility.maxDamage + 1)} {_classAbility.damageType} damage.");
    }
}
