using System;

namespace GameEncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Demo Static Instance====");
            Console.WriteLine($"Total karakter saat ini: {Character.GetTotalCharacterCount()}");
            Character hero1 = new Character();
            hero1.ShowStats();

            Character hero2 = new Character("AN-505", "Artherion");
            hero2.ShowStats();

            Character hero3 = new Character("AN-570", "Detherrion");
            hero3.ShowStats();

            Character hero4 = new Character(10);
            hero4.ShowStats();

            Character hero5 = new Character("CN-245", "Diamond", "Swordmaster", 150);
            hero5.ShowStats();

            Console.WriteLine($"Total karakter yang telah dibuat: {Character.GetTotalCharacterCount()}");
            Console.ReadKey();
        }
    }
}