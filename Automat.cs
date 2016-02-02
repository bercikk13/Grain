using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grain
{
    class MyPoint
    {
        public int x;
        public int y;
        public MyPoint (){}

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
    }
    class Automat
    {
        public Cell[][] firstGrid;
        public Cell[][] secondGrid;
        public Neighbourhoods neighbourhoods;
        int gridSizeX;
        int gridSizeY;
        public static int id = 1;
        Random random = new Random();
        public List<MyPoint> listOfBorders;
        public bool areBordersSet;
        public int nucleonsCount;
        public List<int> blockedID;

        public int start, endX, endY;

        public bool startGrowth;


        public Automat(int x, int y)
        {
            this.gridSizeX = x;
            this.gridSizeY = y;
            neighbourhoods = new Neighbourhoods();
            this.areBordersSet = false;
            createGrid();
            blockedID = new List<int>();

            startGrowth = false;
        }

        public void createGrid()
        {
            firstGrid = new Cell[this.gridSizeX][];
            secondGrid = new Cell[this.gridSizeX][];

            for (int i = 0; i < this.gridSizeX; i++)
            {
                firstGrid[i] = new Cell[gridSizeY];
                secondGrid[i] = new Cell[gridSizeY];

                for (int j = 0; j < this.gridSizeY; j++)
                {
                    firstGrid[i][j] = new Cell();
                    secondGrid[i][j] = new Cell();
                }
            }

        }

        public void setRandomCells(int count)
        {
            for (int i = 0; i < count; i++)
            {
                int randX = random.Next(start, endX);
                int randY = random.Next(start, endY);

                createSingleCell(randX, randY);

            }
        }
        public void createSingleCell(int x, int y)
        {
            if (firstGrid[x][y].state == 0)
            {
                this.firstGrid[x][y].state = id;
                this.firstGrid[x][y].color = new MyColor();
                id++;

            }

        }

        public int mod(int a, int b)
        {
            if (b < 0)
                return mod(-a, -b);
            int ret = a % b;
            if (ret < 0)
                ret += b;
            return ret;
        }

        public void setMyHexNeighbors(bool flag)
        {
            if (flag == true)
            {
                start = 0;
                endX = this.gridSizeX;
                endY = this.gridSizeY;
            }

            else
            {
                start = 1;
                endX = this.gridSizeX - 1;
                endY = this.gridSizeY - 1;
            }

            for (int i = start; i < endX; i++)
                for (int j = start; j < endY; j++)
                {

                    int above = mod((i - 1), this.gridSizeX);
                    int below = mod((i + 1), this.gridSizeX);
                    int left = mod((j - 1), this.gridSizeY);
                    int right = mod((j + 1), this.gridSizeY);

                    firstGrid[i][j].myNeighbors[0] = firstGrid[above][left];
                    firstGrid[i][j].myNeighbors[1] = firstGrid[below][right];
                    firstGrid[i][j].myNeighbors[2] = firstGrid[above][j];
                    firstGrid[i][j].myNeighbors[3] = firstGrid[i][right];
                    firstGrid[i][j].myNeighbors[4] = firstGrid[i][left];
                    firstGrid[i][j].myNeighbors[5] = firstGrid[below][j];
                    firstGrid[i][j].myNeighbors[6] = firstGrid[above][right];
                    firstGrid[i][j].myNeighbors[7] = firstGrid[below][left];
                }
        }

        public void setHexNeighbors(bool flag)
        {

            int start, endX, endY;

            if (flag == true)
            {
                start = 0;
                endX = this.gridSizeX;
                endY = this.gridSizeY;
            }

            else
            {
                start = 1;
                endX = this.gridSizeX - 1;
                endY = this.gridSizeY - 1;
            }

            for (int i = start; i < endX; i++)
                for (int j = start; j < endY; j++)
                {

                    int above = mod((i - 1), this.gridSizeX);
                    int below = mod((i + 1), this.gridSizeX);
                    int left = mod((j - 1), this.gridSizeY);
                    int right = mod((j + 1), this.gridSizeY);

                    firstGrid[i][j].neighbors[0] = secondGrid[above][left];
                    firstGrid[i][j].neighbors[1] = secondGrid[below][right];
                    firstGrid[i][j].neighbors[2] = secondGrid[above][j];
                    firstGrid[i][j].neighbors[3] = secondGrid[i][right];
                    firstGrid[i][j].neighbors[4] = secondGrid[i][left];
                    firstGrid[i][j].neighbors[5] = secondGrid[below][j];
                    firstGrid[i][j].neighbors[6] = secondGrid[above][right];
                    firstGrid[i][j].neighbors[7] = secondGrid[below][left];
                }
        }

        public void setBoundaries()
        {
            listOfBorders = new List<MyPoint>();

            for (int i = start; i < endX; i++)
            {
                for (int j = start; j < endY; j++)
                {
                    for (int k = 0; k < 8; ++k)
                    {
                        if (firstGrid[i][j].myNeighbors[k].state != firstGrid[i][j].state)
                        {
                            listOfBorders.Add(new MyPoint(i,j));
                        }
                    }
                }
            }

            this.areBordersSet = true;
        }

        public void setInclusions(int count, int size, string type)
        { 
            int rand;
            for (int i = 0; i < count; i++)
            {
                rand = random.Next(0, listOfBorders.Count);

                switch (type)
                { 
                    case "square":                   
                        setSquareInclusions(listOfBorders[rand].x, listOfBorders[rand].y, size);
                        break;
                    case "circular":
                        setCircularInclusions(listOfBorders[rand].x, listOfBorders[rand].y, size);
                        break;

                }
            }
        }

        public void setSquareInclusions(int x0, int y0, int length)
        {
            firstGrid[x0][y0].state = -1;

            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                {
                    firstGrid[mod(x0 + i, this.gridSizeX)][mod(y0 + j, this.gridSizeY)].state = -1;
                }
        }

        public void setSquareInclusionsBefore(int count, int length)
        {
            for (int k = 0; k < count; k++)
            {
                int randX = random.Next(start, endX);
                int randY = random.Next(start, endY);

                for (int i = 0; i < length; i++)
                    for (int j = 0; j < length; j++)
                    {
                        firstGrid[mod(randX + i, this.gridSizeX)][mod(randY + j, this.gridSizeY)].state = -1;
                    }

            }
        }

        public void setCircularInclusionsBefore(int count, int radius)
        {
            for (int k = 0; k < count; k++)
            {

            int randX = random.Next(start, endX);
            int randY = random.Next(start, endY);

            
                for (int x = -radius; x <= radius; x++)
                {
                    for (int y = -radius; y <= radius; y++)
                    {
                        if (x * x + y * y <= radius * radius + radius * 0.8)
                        {
                            firstGrid[mod(randX + x, this.gridSizeX)][mod(randY + y, this.gridSizeY)].state = -1;
                        }

                    }
                }
            }

        }

        public void setCircularInclusions(int x0, int y0, int radius)
        {
            for (int x = -radius; x <= radius; x++)
            {         
                for (int y = -radius; y <= radius; y++)
                {
                    if (x * x + y * y <= radius * radius + radius * 0.8)
                    {
                        firstGrid[mod(x0 + x, this.gridSizeX)][mod(y0 + y, this.gridSizeY)].state = -1;
                    }
                    
                }
            }
        }

        public void clearAutomat()
        {
            for (int i = 0; i < this.gridSizeX; i++)
                for (int j = 0; j < this.gridSizeY; j++)
                {
                    if (!firstGrid[i][j].blocked)
                    {
                        firstGrid[i][j].state = 0;
                    }
                }

            this.areBordersSet = false;
        }

        public void copyMatrix()
        {
            for (int i = 0; i < this.gridSizeX; i++)
                for (int j = 0; j < this.gridSizeY; j++)
                {
                    secondGrid[i][j].state = firstGrid[i][j].state;
                    secondGrid[i][j].color = firstGrid[i][j].color;
                }
        }

        public void randomHexGrowth()
        {
            copyMatrix();
            startGrowth = true;
            //int choice = random.Next(0, 2);

            for (int i = start; i < endX; i++)
            {
                for (int j = start; j < endY; j++)
                {
                    if (secondGrid[i][j].state == 0 && secondGrid[i][j].state != -1) // state = -1 dla wtrąceń
                    {
                        int choice = random.Next(0, 2);

                        if (choice == 0)
                        {
                            neighbourhoods.HexaLeft(ref firstGrid[i][j]);
                        }
                        else if (choice == 1)
                        {
                            neighbourhoods.HexaRight(ref firstGrid[i][j]);
                        }
                    }
                }
            }
        }

        public void VonNeuman()
        {
            startGrowth = true;
            copyMatrix();

            for (int i = start; i < endX; i++)
            {
                for (int j = start; j < endY; j++)
                {
                    if (secondGrid[i][j].state == 0 && secondGrid[i][j].state != -1) // state -1 dla wtracen
                    {
                        neighbourhoods.VonNeuman(ref firstGrid[i][j]);
                    }
                }
            }
        }

        public void Moore()
        {
            copyMatrix();
            startGrowth = true;
            for (int i = start; i < endX; i++)
            {
                for (int j = start; j < endY; j++)
                {
                    if (secondGrid[i][j].state == 0 && secondGrid[i][j].state != -1)
                    {
                        neighbourhoods.Moore(ref firstGrid[i][j]);
                    }
                }
            }
        }

        public void furtherMoore(int probability)
        {
            copyMatrix();

            setProbability();

            for (int i = start; i < endX; i++)
            {
                for (int j = start; j < endY; j++)
                {
                     if (secondGrid[i][j].state == 0 && secondGrid[i][j].state != -1)
                     {
                         
                         if(!neighbourhoods.Rule1(ref firstGrid[i][j]))
                         {
                             if (!neighbourhoods.Rule2(ref firstGrid[i][j]))
                             {
                                 if (!neighbourhoods.Rule3(ref firstGrid[i][j]))
                                 {
                                     if (!neighbourhoods.Rule4(ref firstGrid[i][j], probability))
                                     {

                                     }
                                 }
                             }
                         }                       
                     }
                }
            }
        }

        public void randomPenta()
        {
            copyMatrix();
            startGrowth = true;
            

            for (int i = start; i < endX; i++)
            {
                for (int j = start; j <endY; j++)
                {
                    int choice = random.Next(0, 4);

                    if (secondGrid[i][j].state == 0 && secondGrid[i][j].state != -1) // -1 dla wtracen
                    {
                        if (choice == 0)
                        {
                            neighbourhoods.PentaTop(ref firstGrid[i][j]);
                        }
                        else if (choice == 1)
                        {
                            neighbourhoods.PentaBottom(ref firstGrid[i][j]);
                        }
                        else if (choice == 2)
                        {
                            neighbourhoods.PentaRight(ref firstGrid[i][j]); 
                        }
                        else if (choice == 3)
                        {
                            neighbourhoods.PentaLeft(ref firstGrid[i][j]); 
                        }                     
                    }
                }
            }
        }

        public void setProbability()
        {
            for (int i = start; i < endX; i++)
                for (int j = start; j < endY; j++)
                {
                    this.firstGrid[i][j].probability = random.Next(0, 101);
                }
        }

        public void setBlockedCells(int x, int y, bool dual)
        {
            if (firstGrid[x][y].state != 0)
            {
                for (int i = start; i < endX; i++)
                {
                    for (int j = start; j < endY; j++)
                    {
                        if (firstGrid[i][j].state == firstGrid[x][y].state)
                        {
                            firstGrid[i][j].blocked = true;
                            secondGrid[i][j].blocked = true;
                            if (dual)
                            {
                                firstGrid[i][j].color.R = 255;
                                firstGrid[i][j].color.G = 255;
                                firstGrid[i][j].color.B = 0;
                            }
                        }
                    }
                }
            }
        }

        public void setCellsFoMC(int amount)
        {
            Dictionary<int, MyColor> idAndColor = new Dictionary<int, MyColor>();

            for (int i = 1; i <= amount; i++)
            {
                idAndColor[i] = new MyColor();
            }

            for (int i = start; i < endX; i++)
                for (int j = start; j < endY; j++)
                {
                    int randID = random.Next(1, amount+1);
                    this.firstGrid[i][j].state = randID;
                    this.firstGrid[i][j].color = idAndColor[randID];
                }

        }

        public int energyCount(int x, int y, string neighborhood)
        {
            int counter = 0;

            if (neighborhood == "Moore")
            {
                for (int i = 0; i <= 7; i++)
                {
                    if (firstGrid[x][y].state != firstGrid[x][y].myNeighbors[i].state)
                        counter++;
                }
            }
            else if (neighborhood == "Von Neumann")
            {
                for (int i = 2; i < 6; i++)
                {
                    if (firstGrid[x][y].state != firstGrid[x][y].myNeighbors[i].state)
                        counter++;
                }
            }

            return counter;
        }

        public void mcStep(string neighborhood)
        {
            List<MyPoint> Cells = new List<MyPoint>();

            for (int i = start; i < endX; i++)
            {
                for (int j = start; j < endY; j++)
                {
                    Cells.Add(new MyPoint(i,j));
                }
            }
            while (Cells.Count != 0)
            {
                int randCell = random.Next(0, Cells.Count);

                int xx = Cells[randCell].x;
                int yy = Cells[randCell].y;

                int oldState = firstGrid[xx][yy].state;
                MyColor oldColor = firstGrid[xx][yy].color;

                int E1 = energyCount(xx, yy, neighborhood);

                int randNeight = 0;

                if (neighborhood == "Moore")
                {
                     randNeight = random.Next(0, 8);
                }
                else if (neighborhood == "Von Neumann")
                {
                    randNeight = random.Next(2, 6);
                }
                

                if (oldState != firstGrid[xx][yy].myNeighbors[randNeight].state)
                {
                    firstGrid[xx][yy].state = firstGrid[xx][yy].myNeighbors[randNeight].state;
                    firstGrid[xx][yy].color = firstGrid[xx][yy].myNeighbors[randNeight].color;
                }

                int E2 = energyCount(xx, yy, neighborhood);

                if (E1 < E2)
                {
                    firstGrid[xx][yy].state = oldState;
                    firstGrid[xx][yy].color = oldColor;
                }

                Cells.RemoveAt(randCell);

            }
            
        }
    }
}
