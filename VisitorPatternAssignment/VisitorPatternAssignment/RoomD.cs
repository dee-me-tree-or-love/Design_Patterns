using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternAssignment
{
    public class RoomD : Room
    {
        private readonly string[] attacks = new string[]
        {
            "poisoned", "bad luck", "disoriented",
        };

        private readonly string[] attackers = new string[]
        {
            "rats", "ninjas", "lions", "hamsters", "dragons"
        };

        public string  getAttacker()
        {
            return this.attackers[(new Random().Next(0, 34)) % this.attackers.Length];
        }

        public RoomD(int _k) : base(_k) { }

        public override void accept(Visitor v)
        {
            // does not increase the number of steps of the visitor
            v.VisitRoomD(this);
            this.attack(v);
        }


        /// <summary>
        /// Adds a 'buff' title to the visitor
        /// </summary>
        /// <param name="v"></param>
        public void attack(Visitor v)
        {
            // puts a random buff
            v.buff = this.attacks[(new Random().Next(0, 34)) % this.attacks.Length];
        }
    }
}
