using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fightWithTheEnemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroHealth = 100;
            int heroDamage = 5;
            int enemyHealth = 50;
            int enemyDamage = 10;

            while (heroHealth > 0 && enemyHealth > 0)
            {
                heroHealth -= enemyDamage;
                enemyHealth -= heroDamage;
                Console.WriteLine($"У героя {heroHealth} единиц здоровья, а у противника {enemyHealth} единиц здоровья");
                if (heroHealth <= 0 || enemyHealth <= 0)
                {
                    Console.WriteLine("Ничья");
                }
                else if (heroHealth <= 0)
                {
                    Console.WriteLine("Победил противник.");
                }
                else
                {
                    Console.WriteLine("Победил герой");
                }
            }
        }
    }
}
