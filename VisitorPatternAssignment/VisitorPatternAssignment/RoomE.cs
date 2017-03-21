using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternAssignment
{
    /// <summary>
    /// E for entrance
    /// </summary>
    public class RoomE : Room
    {
        private readonly string[] entranceBuffs = new string[]
        {
            "super luck", "blessed", "far sight",
        };

        public RoomE(int _k) : base(_k) { }

        public override void accept(Visitor v)
        {
            // does not increase the number of steps of the visitor
            v.VisitRoomE(this);
            this.giveBuff(v);
        }


        /// <summary>
        /// Adds a 'buff' title to the visitor
        /// </summary>
        /// <param name="v"></param>
        public void giveBuff(Visitor v)
        {
            // puts a random buff
            v.buff = this.entranceBuffs[(new Random().Next(0, 34)) % this.entranceBuffs.Length];
        }
    }
}
