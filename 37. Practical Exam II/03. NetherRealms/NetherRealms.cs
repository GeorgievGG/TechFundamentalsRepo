using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.NetherRealms
{
    public class NetherRealms
    {
        public static void Main()
        {
            var demonsList = Console.ReadLine().Split(',').Select(x => x.Trim());
            var healthRegex = new Regex(@"[^0-9+\-*\/.]");
            var damageRegex = new Regex(@"[\-+]*[0-9]+\.*[0-9]*");
            var symbolsRegex = new Regex(@"[\/*]");
            var demons = new List<Demon>();
            foreach (var demon in demonsList)
            {
                var healthElements = healthRegex.Matches(demon).Cast<Match>().ToList();
                var damageElements = damageRegex.Matches(demon).Cast<Match>().ToList();
                var otherSymbols = symbolsRegex.Matches(demon).Cast<Match>().ToList();
                var health = 0;
                var damage = 0m;
                foreach (Match he in healthElements)
                {
                    health += he.Value[0];
                }
                foreach (Match de in damageElements)
                {
                    damage += decimal.Parse(de.Value);
                }
                foreach (Match os in otherSymbols)
                {
                    if (os.Value == "/")
                    {
                        damage /= 2;
                    }
                    else if (os.Value == "*")
                    {
                        damage *= 2;
                    }
                }
                demons.Add(new Demon(demon, health, damage));
            }
            demons = demons.OrderBy(x => x.Name).ToList();
            demons.ForEach(x => Console.WriteLine($"{x.Name} - {x.Health} health, {x.Damage:f2} damage"));
        }
    }
    public class Demon
    {
        public Demon (string name, int health, decimal damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public decimal Damage { get; set; }
    }
}
