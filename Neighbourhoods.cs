using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grain
{
    class Neighbourhoods
    {
        public void VonNeuman(ref Cell cell)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 2; k < 6; ++k)
            {
                count = 0;

                for (int l = 2; l < 6; l++)
                {
                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state && cell.neighbors[k].blocked == false && cell.neighbors[l].blocked == false && cell.neighbors[k].state != -1 && cell.neighbors[l].state != -1)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }

            }

            cell.state = id;
            cell.color = c;
        }

        public void Moore(ref Cell cell)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 0; k < 8; ++k)
            {
                count = 0;

                for (int l = 0; l < 8; l++)
                {
                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state && cell.neighbors[k].blocked == false && cell.neighbors[l].blocked == false && cell.neighbors[k].state != -1 && cell.neighbors[l].state != -1)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }

            }

            cell.state = id;
            cell.color = c;
        }

        public void HexaLeft(ref Cell cell)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 0; k < 6; ++k)
            {
                count = 0;

                for (int l = 0; l < 6; l++)
                {
                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state && cell.neighbors[k].blocked == false && cell.neighbors[l].blocked == false && cell.neighbors[k].state != -1 && cell.neighbors[l].state != -1)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }

                cell.state = id;
                cell.color = c;

            }

        }

        public void HexaRight(ref Cell cell)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 2; k < 8; ++k)
            {
                count = 0;

                for (int l = 2; l < 8; l++)
                {
                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state && cell.neighbors[k].blocked == false && cell.neighbors[l].blocked == false && cell.neighbors[k].state != -1 && cell.neighbors[l].state != -1)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }                
            }

            cell.state = id;
            cell.color = c;
        }

        public void PentaTop(ref Cell cell)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 1; k < 7; ++k)
            {
                if (k == 4)
                    continue;

                count = 0;

                for (int l = 1; l < 7; l++)
                {
                    if (l == 4)
                        continue;

                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state && cell.neighbors[k].blocked == false && cell.neighbors[l].blocked == false && cell.neighbors[k].state != -1 && cell.neighbors[l].state != -1)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }
            }

            cell.state = id;
            cell.color = c;
                
        }

        public void PentaBottom(ref Cell cell)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 0; k < 8; ++k)
            {
                if (k == 1 || k == 3 || k == 6)
                    continue;

                count = 0;

                for (int l = 0; l < 8; l++)
                {
                    if (l == 1 || l == 3 || l == 6)
                        continue;

                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state && cell.neighbors[k].blocked == false && cell.neighbors[l].blocked == false && cell.neighbors[k].state != -1 && cell.neighbors[l].state != -1)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }
            }

            cell.state = id;
            cell.color = c;
        }

        public void PentaRight(ref Cell cell)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 0; k < 7; ++k)
            {
                if (k == 1 || k == 5)
                    continue;

                count = 0;

                for (int l = 0; l < 7; l++)
                {
                    if (l == 1 || l == 5)
                        continue;

                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state && cell.neighbors[k].blocked == false && cell.neighbors[l].blocked == false && cell.neighbors[k].state != -1 && cell.neighbors[l].state != -1)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }
            }

            cell.state = id;
            cell.color = c;
        }

        public void PentaLeft(ref Cell cell)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 1; k < 8; ++k)
            {
                if (k == 2 || k == 6)
                    continue;

                count = 0;

                for (int l = 1; l < 8; l++)
                {
                    if (l == 2 || l == 6)
                        continue;

                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state && cell.neighbors[k].blocked == false && cell.neighbors[l].blocked == false && cell.neighbors[k].state != -1 && cell.neighbors[l].state != -1)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }
            }

            cell.state = id;
            cell.color = c;
        }

        public bool Rule1(ref Cell cell)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 0; k < 8; ++k)
            {
                count = 0;

                for (int l = 0; l < 8; l++)
                {
                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }

                if (maks >= 5)
                {
                    cell.state = id;
                    cell.color = c;
                    return true;
                }
            }

            return false;
        }

        public bool Rule2(ref Cell cell)
        {
            int count = 0;

            MyColor c = new MyColor();

            for (int k = 2; k < 6; ++k)
            {
                count = 0;

                for (int l = 2; l < 6; l++)
                {
                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state)
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    cell.state = cell.neighbors[k].state;
                    cell.color = cell.neighbors[k].color;
                    return true;
                }
            }

            return false;
        }

        public bool Rule3(ref Cell cell)
        {
            int count = 0;

            MyColor c = new MyColor();


            for (int k = 0; k < 2; ++k)
            {
                count = 0;

                for (int l = 0; l < 2; l++)
                {
                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state)
                    {
                        count++;
                    }
                }

                for (int l = 6; l < 8; l++)
                {
                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state)
                    {
                        count++;
                    }
                }

                if (count == 3)
                {
                    cell.state = cell.neighbors[k].state;
                    cell.color = cell.neighbors[k].color;
                    return true;
                }
            }

            return false;
        }

        public bool Rule4(ref Cell cell, int globalProbability)
        {
            int count = 0;
            int maks = 0;
            int id = 0;
            MyColor c = new MyColor();

            for (int k = 0; k < 8; ++k)
            {
                count = 0;

                for (int l = 0; l < 8; l++)
                {
                    if (cell.neighbors[k].state != 0 && cell.neighbors[l].state != 0 && cell.neighbors[k].state == cell.neighbors[l].state)
                    {
                        count++;
                    }
                }

                if (count > maks)
                {
                    maks = count;
                    id = cell.neighbors[k].state;
                    c = cell.neighbors[k].color;
                }              
            }

            if (cell.probability < globalProbability)
            {
                cell.state = id;
                cell.color = c;
                return true;
            }

            return false;
        }
    }
}
