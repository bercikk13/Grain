using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grain
{
    public class Cell
    {
        public int x;
        public int y;
        public int state;
        public Cell [] myNeighbors;
        public Cell [] neighbors;
        public MyColor color;
        public int probability;
        public bool blocked;

        public bool recrystallized;
        public int H;
        public bool border;

        public Cell()
        {
            state = 0;
            myNeighbors = new Cell[8];
            neighbors = new Cell[8];
            color = new MyColor(0,0,0);
            probability = 0;
            blocked = false;

            recrystallized = false;
            H = 0;
            border = false;
        }
    }

    public class MyColor
    {
        public int R;
        public int G;
        public int B;
        private static Random random = new Random();

        public MyColor()
        {
            R = random.Next(0, 256); 
            G = random.Next(0, 256); 
            B = random.Next(0, 256); 
        }
        public MyColor(int R, int G, int B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }

    }
}
