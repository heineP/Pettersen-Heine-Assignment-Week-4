namespace FantasyGame.Weapon;

public class Staff : Weapon
{
    // CONSTRUCTOR
    public Staff()
    {
        description = "Staff";
        attackMessage = "swing your staff at the target.";
        damageType = "Blunt";
        tooltipDamageRange = "1-3";
        minDamage = 1;
        maxDamage = 3;
    }
}