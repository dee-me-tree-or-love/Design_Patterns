using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternAssignment
{
    public abstract class Room
    {
        /// <summary>
        /// the numeric Key of the room. 
        /// </summary>
        public int Key { get; private set; }
        public  Stack<Room> neighourRooms { get; protected set; }

        /// <summary>
        /// Accepts a parameter representing the Key of the room to be assigned
        /// </summary>
        /// <param name="k"></param>
        public Room(int k)
        {
            this.Key = k;
            this.neighourRooms = new Stack<Room>();
        }

        /// <summary>
        /// Adds a neighbour to the room
        /// </summary>
        /// <param name="r"></param>
        public void addNeighbour(Room r)
        {
            if (!this.neighourRooms.Contains(r))
            {
                this.neighourRooms.Push(r);
            }
        }

        /// <summary>
        /// Checks if a room is among the rooms children
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool linksTo(Room r)
        {
            return this.neighourRooms.Contains(r);
        }

        abstract public void accept(Visitor v);       
        
    }
}
