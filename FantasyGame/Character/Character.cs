using FantasyGame.Weapon;

namespace FantasyGame.Character;

public class Character
{
    // FIELDS
    public string classAbility = "You stand still";
    public string name;
    public string description = "A civillian";
    public Weapon.Weapon weapon;
    
    // CONSTRUCTOR
    public Character(string aName)
    {
        this.weapon = new Weapon.Weapon();
        this.name = aName;
    }
    
    // METHOD Attack()
    public virtual void Attack()
    {
        Random rnd = new Random();
        Console.WriteLine($"{classAbility} and {weapon.attackMessage}");
        Console.WriteLine($"You deal {rnd.Next(weapon.minDamage, weapon.maxDamage + 1)} {weapon.damageType} damage.");
    }
}