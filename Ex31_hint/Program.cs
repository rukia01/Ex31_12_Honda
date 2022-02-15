using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2);
            Character character2 = new Character("ささっき", 1000, 25);
            Tank tank1 = new Tank("Tiger", 500000, 250);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125);
            tank2.bullet = 5;
            Cow cow = new Cow("黒毛和牛", 5000, 60);
            Cat cat = new Cat("野良猫", 200, 15);
            Honet honet = new Honet("スズメバチ", 100, 0);
            Character[] characters = { character1, character2, tank1, tank2, cow, cat, honet };
            for(var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
            character2.Attack(cat);
            tank1.Attack(cow);
            tank2.Attack(character2);
            cow.Attack(character2);
            cat.Attack(character2);
            honet.Attack(tank1);
            honet.Attack(cow);
            honet.Attack(character2);
            honet.Attack(honet);
        }
    }
}
