using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grain
{
    public partial class textBoxGS : Form
    {
        public int gridSizeX = 200;
        public int gridSizeY = 200;
        int cellSize;
        Automat automat;



        public textBoxGS()
        {
            InitializeComponent();
            textBoxGSx.Text = Convert.ToString(100);
            textBoxGSy.Text = Convert.ToString(100);
            textBoxNucleons.Text = Convert.ToString(10);
            textBoxPixel.Text = Convert.ToString(2);
            textBoxSteps.Text = Convert.ToString(50);
            textBoxInclusions.Text = Convert.ToString(10);
            textBoxInclSize.Text = Convert.ToString(2);
            textBoxProbability.Text = Convert.ToString(50);
            textBoxMCAmount.Text = Convert.ToString(5);
            textBoxMCSteps.Text = Convert.ToString(100);
                
            setNucleons.Enabled = false;
            runAutomat.Enabled = false;
            runOneStep.Enabled = false;
            clear.Enabled = false;

            
                        
        }

        private void PB_Paint(object sender, PaintEventArgs e)
        {

            if (automat != null)
            {
                Pen p = new Pen(Color.Black);


                for (int x = 0; x <= gridSizeY; ++x)
                {
                    e.Graphics.DrawLine(p, 0, x * cellSize, gridSizeX * cellSize, x * cellSize);
                }

                for (int y = 0; y <= gridSizeX; ++y)
                {
                    e.Graphics.DrawLine(p, y * cellSize, 0, y * cellSize, gridSizeY * cellSize);
                }

                if (automat != null)
                {
                    for (int x = 0; x < gridSizeX; ++x)
                        for (int y = 0; y < gridSizeY; ++y)
                        {
                            if (automat.firstGrid[x][y].state != 0)
                                e.Graphics.FillRectangle(new System.Drawing.SolidBrush(Color.FromArgb(automat.firstGrid[x][y].color.R, automat.firstGrid[x][y].color.G, automat.firstGrid[x][y].color.B)), new Rectangle(x * cellSize, y * cellSize, cellSize, cellSize));

                            if (automat.firstGrid[x][y].state == -1)
                            {
                                e.Graphics.FillRectangle(new System.Drawing.SolidBrush(Color.Black), new Rectangle(x * cellSize, y * cellSize, cellSize, cellSize));
                            }
                           /* if (automat.firstGrid[x][y].isBorder == true)
                            {
                                e.Graphics.FillRectangle(new System.Drawing.SolidBrush(Color.Black), new Rectangle(x * cellSize, y * cellSize, cellSize, cellSize));
                            }
                             * */
                        }
                }
            }
        }
        
        private void PB_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (automat != null)
            {
                if (me.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    
                    contextMenuStrip1.Show(PB, cellSize * me.X / cellSize, cellSize * me.Y / cellSize);

                }

                if (me.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    if (SingleCellItem.Checked == true && selectDualPhaseGrain.Checked == false && selectNonDualPhase.Checked == false)
                    {
                        int x = me.X;
                        int y = me.Y;
                        int x1 = (x / cellSize);
                        int y1 = (y / cellSize);

                        if (x1 < gridSizeX && y1 < gridSizeY)
                        {
                            automat.createSingleCell(x1, y1);
                        }
                    }
                    else if (SingleCellItem.Checked == false)
                    {
                        int x = me.X;
                        int y = me.Y;
                        int x1 = (x / cellSize);
                        int y1 = (y / cellSize);

                        if (x1 < gridSizeX && y1 < gridSizeY)
                        {
                            if (selectNonDualPhase.Checked == true && selectDualPhaseGrain.Checked == false)
                            {
                                automat.setBlockedCells(x1, y1, false);
                            }
                            else if (selectDualPhaseGrain.Checked == true && selectNonDualPhase.Checked == false)
                            {
                                automat.setBlockedCells(x1, y1, true);
                            }
                        }
                    }

                    this.PB.Refresh();
                }
            }
        }

        private void runAutomat_Click(object sender, EventArgs e)
        {
            int steps = int.Parse(textBoxSteps.Text);

            if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Random Hex")
            {
                for (int i = 0; i < steps; i++)
                {
                    automat.randomHexGrowth();
                    this.PB.Refresh();
                }
            }

            else if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Random Penta")
            {
                for (int i = 0; i < steps; i++)
                {
                    automat.randomPenta();
                    this.PB.Refresh();
                }
            }
            else if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Moore")
            {
                for (int i = 0; i < steps; i++)
                {
                    automat.Moore();
                    this.PB.Refresh();
                }
            }
            else if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Von Neumann")
            {
                for (int i = 0; i < steps; i++)
                {
                    automat.VonNeuman();
                    this.PB.Refresh();
                }
            }
            else if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Further Moore")
            {
                for (int i = 0; i < steps; i++)
                {
                    automat.furtherMoore(int.Parse(textBoxProbability.Text));
                    this.PB.Refresh();
                }
            }

            automat.areBordersSet = false;
            this.PB.Refresh();
        }

        private void runAutomat_Click_1(object sender, EventArgs e)
        {
            if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Random Hex")
            {
                    automat.randomHexGrowth();
            }

            else if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Random Penta")
            {
                automat.randomPenta();
            }
            else if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Moore")
            {
                automat.Moore();
            }
            else if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Von Neumann")
            {
                automat.VonNeuman();
            }
            else if (this.comboBoxNbhd.GetItemText(this.comboBoxNbhd.SelectedItem) == "Further Moore")
            {
                automat.furtherMoore(int.Parse(textBoxProbability.Text));
            }

            automat.areBordersSet = false;
            this.PB.Refresh();
            
        }

        private void comboBoxNbhd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setNucleons_Click(object sender, EventArgs e)
        {
            this.automat.setRandomCells(int.Parse(textBoxNucleons.Text));
            this.PB.Refresh();
        }

        private void textBoxPixel_TextChanged(object sender, EventArgs e)
        {

        }

        private void drawGrid_Click(object sender, EventArgs e)
        {
            gridSizeX = int.Parse(textBoxGSx.Text);
            gridSizeY = int.Parse(textBoxGSy.Text);
            cellSize = int.Parse(textBoxPixel.Text);



            this.automat = new Automat(gridSizeX, gridSizeY);

            if (radioButtonPeriodic.Checked == true)
            {
                automat.setHexNeighbors(true);
                automat.setMyHexNeighbors(true);
            }

            else if (radioButtonAbsorbent.Checked == true)
            {
                automat.setHexNeighbors(false);
                automat.setMyHexNeighbors(false);
            }
            setNucleons.Enabled = true;
            runAutomat.Enabled = true;
            runOneStep.Enabled = true;
            clear.Enabled = true;
            this.PB.Refresh();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            automat.clearAutomat();
            this.PB.Refresh();
            buttonSetInclusions.Enabled = true;
        }

        private void radioButtonPeriodic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSetInclusions_Click(object sender, EventArgs e)
        {

            if (automat.startGrowth == false)
            {
                if (this.radioButtonSquare.Checked == true)
                {
                    automat.setSquareInclusionsBefore(int.Parse(textBoxInclusions.Text), int.Parse(textBoxInclSize.Text));
                }
                else if (this.radioButtonCircular.Checked == true)
                {
                    automat.setCircularInclusionsBefore(int.Parse(textBoxInclusions.Text), int.Parse(textBoxInclSize.Text));
                }
            }

            else
            {
                if (automat.areBordersSet == false)
                {
                    automat.setBoundaries();
                }

                if (this.radioButtonSquare.Checked == true)
                {
                    automat.setInclusions(int.Parse(textBoxInclusions.Text), int.Parse(textBoxInclSize.Text), "square");
                }
                else if (this.radioButtonCircular.Checked == true)
                {
                    automat.setInclusions(int.Parse(textBoxInclusions.Text), int.Parse(textBoxInclSize.Text), "circular");
                }
            }


            
            
            this.PB.Refresh();

           

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxNbhd_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void SingleCellItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetMCCells_Click(object sender, EventArgs e)
        {
            automat.setCellsFoMC(int.Parse(textBoxMCAmount.Text));

            
            PB.Refresh();
        }

        private void buttonRunMC_Click(object sender, EventArgs e)
        {
            if (this.comboBoxMCNeighborhood.GetItemText(this.comboBoxMCNeighborhood.SelectedItem) == "Moore")
            {
                for (int i = 0; i < int.Parse(textBoxMCSteps.Text); i++)
                {
                    automat.mcStep("Moore");
                    PB.Refresh();

                }
            }
            else if(this.comboBoxMCNeighborhood.GetItemText(this.comboBoxMCNeighborhood.SelectedItem) == "Von Neumann")
            {
                for (int i = 0; i < int.Parse(textBoxMCSteps.Text); i++)
                {
                    automat.mcStep("Von Neumann");
                    PB.Refresh();

                }
            }
            

            
        }




    }
}
