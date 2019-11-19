using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Ex5
{
    public class Room:ICloneable
    {
        public Room(int number, int adults, int children, Rate rate)
        {
            
            List<int> rooms = new List<int>();
            Room room = new Room(1, 2, 1, 100);
            rooms.Add(room);
            Room room2 = new Room(2, 3, 2, 150);
            rooms.Add(room2);
            
        }
        public int number { get; }
        public int adults { get; }
        public int children { get; }
        public Rate rate { get; }
        
        
        public object Clone()
        {
            Room originalRoom = this;
            Room newRoom = new Room(originalRoom.number, originalRoom.adults, originalRoom.children, originalRoom.rate);

            return newRoom;

        }
        public int CompareTo(object obj)
        {
            Room room1 = obj as Room;
            int compare = this.number.CompareTo(room1.number);
            int compare2 = this.adults.CompareTo(room1.MiddleName);
            int compare3 = this.children.CompareTo(room1.children);
            
            if (compare == 0 && compare2 == 0)
            {
                return this.children.CompareTo(room1.children);

            }
            return compare3;
        }
    }
}
