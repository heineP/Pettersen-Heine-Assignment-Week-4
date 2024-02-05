using FantasyGame.Weapon;
using FantasyGame.Character;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EXAMPLES");
        Character heine = new Fighter("Heine");
        heine.weapon = new Wand();
        heine.Attack();
        
        Console.WriteLine("-----------------------------------------");
        Character edwin = new Rogue("Edwin");
        edwin.weapon = new Dagger();
        edwin.Attack();
        
        Console.WriteLine("-----------------------------------------");
        Character medivh = new Wizard("Medivh");
        medivh.Attack();
    }
}
