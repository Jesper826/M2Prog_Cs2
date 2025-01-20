using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Room
    {
        

        internal int x, y;
        internal string[] level;

        internal Room(int x, int y, string[] level)
        {
            this.x = x;
            this.y = y;
            this.level = level;
        }

        internal string GetRoomLocationKey() {

            return $"{x},{y}";
        }

        
     
        
            
        
    }
}
