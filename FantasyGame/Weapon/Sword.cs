namespace FantasyGame.Weapon;

public class Sword : Weapon
{
    // CONSTRUCTOR
    public Sword()
    {
        description = "Sword";
        attackMessage = "swing your sword at the target.";
        damageType = "Slashing";
        tooltipDamageRange = "13-19";
        minDamage = 13;
        maxDamage = 19;
    }
}