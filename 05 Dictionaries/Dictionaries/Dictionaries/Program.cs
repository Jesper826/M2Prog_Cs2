using System;
using System.Collections.Generic;

namespace RoomDictionaryExample
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Layout { get; set; } 

        public Room(string name, string description, string[] layout)
        {
            Name = name;
            Description = description;
            Layout = layout;
        }

      
        internal string GetRoomLocationKey(int x, int y)
        {
            return $"{x},{y}";
        }
    }

    class Program
    {
        
        private static Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        static void Main(string[] args)
        {
           
            Room startRoom = new Room(
                "Start Room",
                "This is the starting room.",
                new string[]
                {
                    "xxxxx",
                    "x...x",
                    "x...x",
                    "xxxxx"
                });
            rooms.Add(startRoom.GetRoomLocationKey(0, 0), startRoom);

            
            Room room1 = new Room(
                "Room 1",
                "This is another room.",
                new string[]
                {
                    "xxxxx",
                    "x...x",
                    "x.x.x",
                    "xxxxx"
                });
            rooms.Add(room1.GetRoomLocationKey(1, 0), room1);

            Room room2 = new Room(
                "Room 2",
                "This room is to the north.",
                new string[]
                {
                    "xxxxx",
                    "x...x",
                    "x.X.x",
                    "xxxxx"
                });
            rooms.Add(room2.GetRoomLocationKey(0, 1), room2);

            Room room3 = new Room(
                "Room 3",
                "A room to the east.",
                new string[]
                {
                    "xxxxx",
                    "x...x",
                    "x...x",
                    "xxxxx"
                });
            rooms.Add(room3.GetRoomLocationKey(1, 1), room3);

          
            ShowRoom(0, 1);
            ShowRoom(1, 1); 
            ShowRoom(1, 0);  
            ShowRoom(2, 2);
        }

      
        private static void ShowRoom(int x, int y)
        {
            string key = $"{x},{y}";

            if (rooms.ContainsKey(key))
            {
                Room room = rooms[key];

                foreach (string line in room.Layout)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine($"You are in {room.Name}");
            }
            else
            {
                Console.WriteLine("Error room does not exist");
            }

            Console.WriteLine(); 
        }
    }
}
