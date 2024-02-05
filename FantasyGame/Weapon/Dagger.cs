namespace FantasyGame.Weapon;

public class Dagger : Weapon
{
    // CONSTRUCTOR
    public Dagger()
    {
        description = "Dagger";
        attackMessage = "Lunge at the target with your dagger.";
        damageType = "Piercing";
        tooltipDamageRange = "8-13";
        minDamage = 8;
        maxDamage = 13;
    }
}