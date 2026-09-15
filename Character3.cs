using System;
using System.Data.Common;

namespace GameEncapsulationDemo
{
    public class Character
    {
        public String? charId;
        protected String? charName;
        internal String? charCls;
        private float? health;
        private int? level;
        //Atribut class static
        private static int totalCharacterCount = 0;

        //Method class static
        public static int GetTotalCharacterCount()
        {
            return totalCharacterCount;
        }
        //1. Konstruktor default
        public Character()
        {
            charId = "NoName";
            charName = "Hero";
            charCls = "Adventurer";
            health = 100;
            level = 1;
            totalCharacterCount++;
            Console.WriteLine("Objek Character dibuat dengan Konstruktor Default");
        }

        // 2. Konstruktor Berparameter
        public Character(string id, string name)
        {
            charId = id;
            charName = name;
            charCls = "Adventurer";
            health = 120;
            level = 1;
            totalCharacterCount++;
            Console.WriteLine("Objek Character ini dibuat dengan Konstruktor 2 parameter");
        }

        // 3. Objek dibuat dengan 3 Parameter
        public Character(string id, string name, string clss)
        {
            charId = id;
            charName = name;
            charCls = clss;
            health = 190;
            level = 1;
            totalCharacterCount++;
            Console.WriteLine("Objek dibuat dengan Konstruktor 3 Parameter");
        }

        public Character(int initialLevel)
        {
            level = initialLevel;
            totalCharacterCount++;
        }

        public Character(string id, string name, string cls, float hp)
        {
            charId = id;
            charName = name;
            charCls = cls;
            health = hp;
            level = 1;
            totalCharacterCount++;
            Console.WriteLine("Objek ini dibuat dengan konstruktor 4 parameter");
        }
        public void Start()
        {
            level = 1;
            health = 100;
            Console.WriteLine($"Karakter {charName} (level {level}) memulai petualangan!");
        }

        private void LevelUp()
        {
            level++;
            Console.WriteLine($"{charName} naik level! Level sekarang {level}");
        }

        public void TakeDmg(float dmg)
        {
            health -= dmg;
            Console.WriteLine($"{charName} menerima damage sebesar {dmg} damage. Heath tersisa {health}");
            if (health <= 0)
            {
                Console.WriteLine($"{charName} telah gugur!");
            }
        }

        public void Heal(float healing)
        {
            health += healing;
            Console.WriteLine($"{charName} menerima pemulihan sebesar {healing}! Health saat ini {health}");
        }

        public void ShowStats()
        {
            Console.WriteLine($"ID = {charId}");
            Console.WriteLine($"Name = {charName}");
            Console.WriteLine($"Class = {charCls}");
            Console.WriteLine($"ID = {charId}");
            Console.WriteLine($"Level = {level}");
            Console.WriteLine($"Health = {health}");
        }
    }
}