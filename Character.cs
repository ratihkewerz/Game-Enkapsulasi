using System;

namespace GameEncapsulationDemo
{
    public class Character
    {
        public string characterID;
        protected string characterName;
        internal string characterClass;
        private float health;
        private int level;

        public void Start()
        {
            level = 1;
            health = 100;
            Console.WriteLine($"Karakter {characterName} (Level {level}) memulai pertualangan!");
        }

        private void LevelUp()
        {
            level++;
            Console.WriteLine($"{characterName} naik level! Level sekarang: {level}");
        }

        public void TakeDamage(float dmg)
        {
            health -= dmg;
            Console.WriteLine($"{characterName} menerima {dmg} damage. Health tersisa: {health}");
            if (health <= 0)
            {
                Console.WriteLine($"{characterName} telah gugur!");
            }
        }

        public void Heal(float healAmt)
        {
            health += healAmt;
            Console.WriteLine($"{characterName} sembuh sebesar {healAmt}. Health sekarang: {health}");
        }

        public void ShowStats()
        {
            Console.WriteLine("=== STATS KARAKTER ===");
            Console.WriteLine($"ID      : {characterID}");
            Console.WriteLine($"Nama    : {characterName}");
            Console.WriteLine($"Class   : {characterClass}");
            Console.WriteLine($"Level   : {level}");
            Console.WriteLine($"Health  : {health}");
            Console.WriteLine($"=====================");
        }
    }
}