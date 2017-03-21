using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternAssignment
{
    public class Adventurer : Visitor
    {
        public const string IMPRESSIONENT = "Hoorah! I am going to an adventure!";
        public const string IMPRESSIONFIN = "Wooooow! What a great adventure!";

        public override void VisitRoomD(RoomD dan)
        {
            this.impression = "Aha! Give up your weopons, filthy " + dan.getAttacker();
        }

        public override void VisitRoomE(RoomE entr)
        {
            this.impression = Adventurer.IMPRESSIONENT;
        }

        public override void VisitRoomF(RoomF fin)
        {
            this.makeStep();
            this.impression = IMPRESSIONFIN;
        }

        public override void VisitRoomS(RoomS shr)
        {
            this.impression = "Aha! thank you the holy " + shr.getBlesser();
        }
    }
}
