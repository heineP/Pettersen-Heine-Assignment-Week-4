namespace FantasyGame.Weapon;

public class Bow : Weapon
{
    // CONSTRUCTOR
    public Bow()
    {
        description = "Bow";
        attackMessage = "fire an arrow with your bow.";
        damageType = "Piercing";
        tooltipDamageRange = "7-9";
        minDamage = 7;
        maxDamage = 9;
    }
}