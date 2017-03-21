using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternAssignment
{
    public class RoomS : Room
    {
        private readonly string[] blessings = new string[]
        {
            "super strength", "joy", "enlightment",
        };

        private readonly string[] blessers = new string[]
        {
            "mackerel", "macaroni", "panda", "tilda", "NIL"
        };

        public string getBlesser()
        {
            return this.blessers[(new Random().Next(0, 34)) % this.blessers.Length];
        }

        public RoomS(int _k) : base(_k) { }

        public override void accept(Visitor v)
        {
            // does not increase the number of steps of the visitor
            v.VisitRoomS(this);
            this.heal(v);
        }


        /// <summary>
        /// Adds a 'buff' title to the visitor
        /// </summary>
        /// <param name="v"></param>
        public void heal(Visitor v)
        {
            // puts a random buff
            v.buff = this.blessings[(new Random().Next(0, 34)) % this.blessings.Length];
        }
    }
}
