using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Items
{
    class Bonus : Item, ITimeoutable
    {
        protected Bonus(string id, int healthEffect, int defenseEffect, int attackEffect, int timeout)
            : base(id,healthEffect,defenseEffect,attackEffect)
        {
            this.Timeout = timeout;
        }

        public int HealthEffect { get; set; }

        public int DefenseEffect { get; set; }

        public int AttackEffect { get; set; }

        public int Timeout { get; set; }

        public int Countdown
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool HasTimedOut
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
