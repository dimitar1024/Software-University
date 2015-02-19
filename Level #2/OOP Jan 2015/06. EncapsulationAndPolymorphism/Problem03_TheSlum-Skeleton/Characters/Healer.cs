using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Healer : Character, IHeal
    {
        public int HealingPoints {get; set; }

        public Healer(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range, int healingPoints)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault(c => (c.IsAlive && this.Team != c.Team));
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}
