using System;

namespace GameEncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character();

            hero.characterID = "C-001";
            hero.characterName = "Arthas";
            hero.characterClass = "Warrior";
            hero.health = 100;
            hero.level = 1;

            hero.Start();
            hero.TakeDamage(30);
            hero.Heal(10);

            hero.ShowStats();

            Console.ReadKey();
        }
    }
}