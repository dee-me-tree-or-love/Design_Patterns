using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternAssignment
{
    /// <summary>
    /// Represents a complexity of the game, the numbers are mapped to the maximum number of rooms in the map
    /// </summary>
    public enum COMPLEXITY
    {
        EASY = 2,
        NORMAL = 10,
    }

    public class Map
    {

        public Room[] Rooms { get; private set; }
        private COMPLEXITY complexity; // allows us to assume that there will be exactly (int)complexity rooms in the map
        public Room currentRoom { get; private set; }

        public Map(COMPLEXITY c)
        {
            this.complexity = c;
            int mapSize = (int)c + 1; // so that the last element of the array will indeed have an index (int)c
            this.Rooms = new Room[mapSize];
            Room entranceRoom = new RoomE(1);
            // since complexity depicts the number of possible rooms
            Room finishRoom = new RoomF((int)(this.complexity));

            switch (this.complexity)
            {
                case COMPLEXITY.EASY:
                    this.addPass(entranceRoom, finishRoom);
                    break;
                case COMPLEXITY.NORMAL:
                    // HARDCODED MAP
                    this.addRoom(entranceRoom);
                    this.addRoom(finishRoom);
                    this.addRoom(new RoomS(2));
                    this.addRoom(new RoomS(3));
                    this.addRoom(new RoomD(4));
                    this.addRoom(new RoomS(5));
                    this.addRoom(new RoomD(6));
                    this.addRoom(new RoomS(7));
                    this.addRoom(new RoomD(8));
                    this.addRoom(new RoomD(9));
                    // HARDCODED CONNECTIONS
                    this.addPass(this.findRoomByKey(1), this.findRoomByKey(2));
                    this.addPass(this.findRoomByKey(1), this.findRoomByKey(9));
                    this.addPass(this.findRoomByKey(2), this.findRoomByKey(3));
                    this.addPass(this.findRoomByKey(2), this.findRoomByKey(4));
                    this.addPass(this.findRoomByKey(3), this.findRoomByKey(4));
                    this.addPass(this.findRoomByKey(3), this.findRoomByKey(5));
                    this.addPass(this.findRoomByKey(5), this.findRoomByKey(6));
                    this.addPass(this.findRoomByKey(6), this.findRoomByKey(7));
                    this.addPass(this.findRoomByKey(6), this.findRoomByKey(8));
                    this.addPass(this.findRoomByKey(8), this.findRoomByKey(9));
                    this.addPass(this.findRoomByKey(8), this.findRoomByKey(10));
                    break;
                default:
                    // TO DO: generate random maps
                    break;
            }
            currentRoom = entranceRoom;
        }

        /// <summary>
        /// Checks whether it is possible to proceed to the room with roomKey from the current room 
        /// - does so if it is the case
        /// </summary>
        /// <param name="roomKey"></param>
        public bool goToNextRoom(int roomKey)
        {
            Room nextRoom = this.findRoomByKey(roomKey);
            if (nextRoom!=null && currentRoom.linksTo(nextRoom))
            {
                this.currentRoom = nextRoom;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds a room to the stack
        /// </summary>
        /// <param name="r"></param>
        private void addRoom(Room r)
        {
            int key = r.Key;
            this.Rooms[key] = r;
        }

        public Room getLastRoom()
        {
            return this.Rooms[this.Rooms.Length - 1];
        }

        /// <summary>
        /// Creates an edge between two rooms
        /// If the second parameter is set to null - only an attempt to create the first room is done, it's stack is not affected
        /// </summary>
        /// <param name="rmain"></param>
        /// <param name="rneighbour"></param>
        public void addPass(Room rmain, Room rneighbour)
        {
            if (this.findRoomByKey(rmain.Key) == null) // simply peek the element of he index
            { // if such room didn't exist before
                this.addRoom(rmain);
            }
            if (rneighbour != null)
            {
                rmain.addNeighbour(rneighbour);
                if (this.findRoomByKey(rneighbour.Key) == null)
                {
                    this.addRoom(rneighbour);
                }
                rneighbour.addNeighbour(rmain);
            }
        }

        /// <summary>
        /// Returns the entrance
        /// </summary>
        /// <returns></returns>
        public Room getStartRoom()
        {
            return this.Rooms[1];
        }

        /// <summary>
        /// Retrieves a room with a specified key
        /// Takes O(1) - since every room is mapped by it's key
        /// </summary>
        /// <param name="search_k"></param>
        /// <returns></returns>
        public Room findRoomByKey(int search_k)
        {
            if (search_k < this.Rooms.Length && search_k > 0)
            {
                return this.Rooms[search_k];
            }
            else
            {
                // since such key is not in the adjacency list we can safely conclude that such room does not exist in the map
                return null;
            }
        }
    }
}
