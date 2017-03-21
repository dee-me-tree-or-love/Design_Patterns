using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorPatternAssignment;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEasyMap()
        {
            Map m = new Map(COMPLEXITY.EASY);
            int expectedSize = 3; // since the 0th room is empty
            int actualSize = m.Rooms.Length;
            Room finishRoom = m.Rooms[m.Rooms.Length - 1];

            Assert.AreEqual(expectedSize, actualSize);
            Assert.IsInstanceOfType(finishRoom, typeof(RoomF));
        }

        [TestMethod]
        public void TestEasyMapCurrentRoom()
        {
            Map m = new Map(COMPLEXITY.EASY);
           
            Room startRoom = m.Rooms[1];

            Assert.AreSame(startRoom, m.currentRoom);
        }

        [TestMethod]
        public void TestRoomKeys()
        {
            Map m = new Map(COMPLEXITY.EASY);

            Assert.IsNull(m.findRoomByKey(0));
            Assert.IsNull(m.findRoomByKey(3));
            Assert.IsNull(m.findRoomByKey(m.Rooms.Length));
            Assert.IsInstanceOfType(m.findRoomByKey(m.Rooms.Length-1), typeof(RoomF));
        }

        [TestMethod]
        public void TestAdventurer()
        {
            Adventurer adv = new Adventurer();
            Assert.AreEqual(Visitor.IDLE, adv.impression);
        }

        [TestMethod]
        public void TestAdventureOnEasyMap()
        {
            Adventurer adv = new Adventurer();
            Map m = new Map(COMPLEXITY.EASY);

            // accepts the adventurer
            m.currentRoom.accept(adv);
            // should have set the adventurer's buff and also the impression
            Assert.AreEqual(Adventurer.IMPRESSIONENT, adv.impression);
            Room nextRoom = m.currentRoom.neighourRooms.Peek();
            m.goToNextRoom(nextRoom.Key);
            Assert.AreEqual(m.findRoomByKey(m.Rooms.Length - 1), m.currentRoom);

            // accepts the adventurer
            m.currentRoom.accept(adv);
            // should have set the adventurer's impression and nr of steps
            Assert.AreEqual(Adventurer.IMPRESSIONFIN, adv.impression);
            Assert.AreEqual(1, adv.nrSteps);
        }
    }
}
