using System.Windows.Forms;
namespace Grain
{
    partial class textBoxGS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PB = new System.Windows.Forms.PictureBox();
            this.runOneStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGSx = new System.Windows.Forms.TextBox();
            this.textBoxGSy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNucleons = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSteps = new System.Windows.Forms.TextBox();
            this.comboBoxNbhd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.setNucleons = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPixel = new System.Windows.Forms.TextBox();
            this.drawGrid = new System.Windows.Forms.Button();
            this.runAutomat = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.radioButtonPeriodic = new System.Windows.Forms.RadioButton();
            this.radioButtonAbsorbent = new System.Windows.Forms.RadioButton();
            this.buttonSetInclusions = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCircular = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxInclSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxInclusions = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxProbability = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SingleCellItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDualPhaseGrain = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNonDualPhase = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSetMCCells = new System.Windows.Forms.Button();
            this.buttonRunMC = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxMCSteps = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxMCNeighborhood = new System.Windows.Forms.ComboBox();
            this.textBoxMCAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBoxHetero = new System.Windows.Forms.CheckBox();
            this.textBoxEnergyHGrain = new System.Windows.Forms.TextBox();
            this.textBoxInStep = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxRecryFactor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxRecryNucleons = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButtonSetOnce = new System.Windows.Forms.RadioButton();
            this.radioButtonRekryDecr = new System.Windows.Forms.RadioButton();
            this.radioButtonRecryIncr = new System.Windows.Forms.RadioButton();
            this.radioButtonRekryConst = new System.Windows.Forms.RadioButton();
            this.textBoxStepsRekry = new System.Windows.Forms.TextBox();
            this.textBoxEnergyHBoundary = new System.Windows.Forms.TextBox();
            this.buttonShowEnergy = new System.Windows.Forms.Button();
            this.buttonDistrEnergy = new System.Windows.Forms.Button();
            this.buttonRunRecry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.BackColor = System.Drawing.Color.White;
            this.PB.Location = new System.Drawing.Point(423, 12);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(546, 549);
            this.PB.TabIndex = 0;
            this.PB.TabStop = false;
            this.PB.Click += new System.EventHandler(this.PB_Click);
            this.PB.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Paint);
            // 
            // runOneStep
            // 
            this.runOneStep.Location = new System.Drawing.Point(118, 102);
            this.runOneStep.Name = "runOneStep";
            this.runOneStep.Size = new System.Drawing.Size(45, 19);
            this.runOneStep.TabIndex = 1;
            this.runOneStep.Text = "1 step";
            this.runOneStep.UseVisualStyleBackColor = true;
            this.runOneStep.Click += new System.EventHandler(this.runAutomat_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dimension";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "y:";
            // 
            // textBoxGSx
            // 
            this.textBoxGSx.Location = new System.Drawing.Point(35, 30);
            this.textBoxGSx.Name = "textBoxGSx";
            this.textBoxGSx.Size = new System.Drawing.Size(36, 20);
            this.textBoxGSx.TabIndex = 5;
            // 
            // textBoxGSy
            // 
            this.textBoxGSy.Location = new System.Drawing.Point(35, 56);
            this.textBoxGSy.Name = "textBoxGSy";
            this.textBoxGSy.Size = new System.Drawing.Size(36, 20);
            this.textBoxGSy.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            // 
            // textBoxNucleons
            // 
            this.textBoxNucleons.Location = new System.Drawing.Point(57, 16);
            this.textBoxNucleons.Name = "textBoxNucleons";
            this.textBoxNucleons.Size = new System.Drawing.Size(37, 20);
            this.textBoxNucleons.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Steps";
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.Location = new System.Drawing.Point(88, 48);
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.Size = new System.Drawing.Size(70, 20);
            this.textBoxSteps.TabIndex = 10;
            // 
            // comboBoxNbhd
            // 
            this.comboBoxNbhd.FormattingEnabled = true;
            this.comboBoxNbhd.Items.AddRange(new object[] {
            "Random Hex",
            "Random Penta",
            "Moore",
            "Von Neumann",
            "Further Moore"});
            this.comboBoxNbhd.Location = new System.Drawing.Point(88, 21);
            this.comboBoxNbhd.Name = "comboBoxNbhd";
            this.comboBoxNbhd.Size = new System.Drawing.Size(70, 21);
            this.comboBoxNbhd.TabIndex = 11;
            this.comboBoxNbhd.SelectedIndexChanged += new System.EventHandler(this.comboBoxNbhd_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Neighbourhood";
            // 
            // setNucleons
            // 
            this.setNucleons.Location = new System.Drawing.Point(113, 14);
            this.setNucleons.Name = "setNucleons";
            this.setNucleons.Size = new System.Drawing.Size(50, 24);
            this.setNucleons.TabIndex = 13;
            this.setNucleons.Text = "Set";
            this.setNucleons.UseVisualStyleBackColor = true;
            this.setNucleons.Click += new System.EventHandler(this.setNucleons_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pixel";
            // 
            // textBoxPixel
            // 
            this.textBoxPixel.Location = new System.Drawing.Point(35, 82);
            this.textBoxPixel.Name = "textBoxPixel";
            this.textBoxPixel.Size = new System.Drawing.Size(36, 20);
            this.textBoxPixel.TabIndex = 15;
            this.textBoxPixel.TextChanged += new System.EventHandler(this.textBoxPixel_TextChanged);
            // 
            // drawGrid
            // 
            this.drawGrid.Location = new System.Drawing.Point(92, 78);
            this.drawGrid.Name = "drawGrid";
            this.drawGrid.Size = new System.Drawing.Size(71, 24);
            this.drawGrid.TabIndex = 16;
            this.drawGrid.Text = "Draw";
            this.drawGrid.UseVisualStyleBackColor = true;
            this.drawGrid.Click += new System.EventHandler(this.drawGrid_Click);
            // 
            // runAutomat
            // 
            this.runAutomat.Location = new System.Drawing.Point(13, 102);
            this.runAutomat.Name = "runAutomat";
            this.runAutomat.Size = new System.Drawing.Size(99, 19);
            this.runAutomat.TabIndex = 17;
            this.runAutomat.Text = "Run";
            this.runAutomat.UseVisualStyleBackColor = true;
            this.runAutomat.Click += new System.EventHandler(this.runAutomat_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(13, 127);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(150, 20);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear ";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // radioButtonPeriodic
            // 
            this.radioButtonPeriodic.AutoSize = true;
            this.radioButtonPeriodic.Checked = true;
            this.radioButtonPeriodic.Location = new System.Drawing.Point(87, 15);
            this.radioButtonPeriodic.Name = "radioButtonPeriodic";
            this.radioButtonPeriodic.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPeriodic.TabIndex = 20;
            this.radioButtonPeriodic.TabStop = true;
            this.radioButtonPeriodic.Text = "Periodic";
            this.radioButtonPeriodic.UseVisualStyleBackColor = true;
            this.radioButtonPeriodic.CheckedChanged += new System.EventHandler(this.radioButtonPeriodic_CheckedChanged);
            // 
            // radioButtonAbsorbent
            // 
            this.radioButtonAbsorbent.AutoSize = true;
            this.radioButtonAbsorbent.Location = new System.Drawing.Point(87, 38);
            this.radioButtonAbsorbent.Name = "radioButtonAbsorbent";
            this.radioButtonAbsorbent.Size = new System.Drawing.Size(73, 17);
            this.radioButtonAbsorbent.TabIndex = 21;
            this.radioButtonAbsorbent.TabStop = true;
            this.radioButtonAbsorbent.Text = "Absorbent";
            this.radioButtonAbsorbent.UseVisualStyleBackColor = true;
            // 
            // buttonSetInclusions
            // 
            this.buttonSetInclusions.Location = new System.Drawing.Point(5, 85);
            this.buttonSetInclusions.Name = "buttonSetInclusions";
            this.buttonSetInclusions.Size = new System.Drawing.Size(54, 23);
            this.buttonSetInclusions.TabIndex = 22;
            this.buttonSetInclusions.Text = "Set";
            this.buttonSetInclusions.UseVisualStyleBackColor = true;
            this.buttonSetInclusions.Click += new System.EventHandler(this.buttonSetInclusions_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCircular);
            this.groupBox1.Controls.Add(this.radioButtonSquare);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxInclSize);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttonSetInclusions);
            this.groupBox1.Controls.Add(this.textBoxInclusions);
            this.groupBox1.Location = new System.Drawing.Point(12, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 114);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inclusions";
            // 
            // radioButtonCircular
            // 
            this.radioButtonCircular.AutoSize = true;
            this.radioButtonCircular.Location = new System.Drawing.Point(73, 91);
            this.radioButtonCircular.Name = "radioButtonCircular";
            this.radioButtonCircular.Size = new System.Drawing.Size(60, 17);
            this.radioButtonCircular.TabIndex = 30;
            this.radioButtonCircular.TabStop = true;
            this.radioButtonCircular.Text = "Circular";
            this.radioButtonCircular.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Checked = true;
            this.radioButtonSquare.Location = new System.Drawing.Point(73, 69);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(59, 17);
            this.radioButtonSquare.TabIndex = 29;
            this.radioButtonSquare.TabStop = true;
            this.radioButtonSquare.Text = "Square";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Shape";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Size";
            // 
            // textBoxInclSize
            // 
            this.textBoxInclSize.Location = new System.Drawing.Point(59, 39);
            this.textBoxInclSize.Name = "textBoxInclSize";
            this.textBoxInclSize.Size = new System.Drawing.Size(91, 20);
            this.textBoxInclSize.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Amount";
            // 
            // textBoxInclusions
            // 
            this.textBoxInclusions.Location = new System.Drawing.Point(59, 16);
            this.textBoxInclusions.Name = "textBoxInclusions";
            this.textBoxInclusions.Size = new System.Drawing.Size(91, 20);
            this.textBoxInclusions.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxGSx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioButtonPeriodic);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxGSy);
            this.groupBox2.Controls.Add(this.radioButtonAbsorbent);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPixel);
            this.groupBox2.Controls.Add(this.drawGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 110);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxNucleons);
            this.groupBox3.Controls.Add(this.setNucleons);
            this.groupBox3.Location = new System.Drawing.Point(12, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 46);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nucleons";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxProbability);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.comboBoxNbhd);
            this.groupBox4.Controls.Add(this.clear);
            this.groupBox4.Controls.Add(this.runOneStep);
            this.groupBox4.Controls.Add(this.runAutomat);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxSteps);
            this.groupBox4.Location = new System.Drawing.Point(12, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 153);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Simulation";
            // 
            // textBoxProbability
            // 
            this.textBoxProbability.Location = new System.Drawing.Point(88, 76);
            this.textBoxProbability.Name = "textBoxProbability";
            this.textBoxProbability.Size = new System.Drawing.Size(70, 20);
            this.textBoxProbability.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Probability %";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SingleCellItem,
            this.selectDualPhaseGrain,
            this.selectNonDualPhase});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 70);
            this.contextMenuStrip1.Text = "Select non dual grain ";
            // 
            // SingleCellItem
            // 
            this.SingleCellItem.Checked = true;
            this.SingleCellItem.CheckOnClick = true;
            this.SingleCellItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SingleCellItem.Name = "SingleCellItem";
            this.SingleCellItem.Size = new System.Drawing.Size(195, 22);
            this.SingleCellItem.Text = "Single cell drawing";
            this.SingleCellItem.Click += new System.EventHandler(this.SingleCellItem_Click);
            // 
            // selectDualPhaseGrain
            // 
            this.selectDualPhaseGrain.CheckOnClick = true;
            this.selectDualPhaseGrain.Name = "selectDualPhaseGrain";
            this.selectDualPhaseGrain.Size = new System.Drawing.Size(195, 22);
            this.selectDualPhaseGrain.Text = "Select dual phase grain";
            // 
            // selectNonDualPhase
            // 
            this.selectNonDualPhase.CheckOnClick = true;
            this.selectNonDualPhase.Name = "selectNonDualPhase";
            this.selectNonDualPhase.Size = new System.Drawing.Size(195, 22);
            this.selectNonDualPhase.Text = "Select non dual phase";
            // 
            // buttonSetMCCells
            // 
            this.buttonSetMCCells.Location = new System.Drawing.Point(6, 46);
            this.buttonSetMCCells.Name = "buttonSetMCCells";
            this.buttonSetMCCells.Size = new System.Drawing.Size(102, 23);
            this.buttonSetMCCells.TabIndex = 27;
            this.buttonSetMCCells.Text = "Set ID\'s";
            this.buttonSetMCCells.UseVisualStyleBackColor = true;
            this.buttonSetMCCells.Click += new System.EventHandler(this.buttonSetMCCells_Click);
            // 
            // buttonRunMC
            // 
            this.buttonRunMC.Location = new System.Drawing.Point(292, 23);
            this.buttonRunMC.Name = "buttonRunMC";
            this.buttonRunMC.Size = new System.Drawing.Size(83, 46);
            this.buttonRunMC.TabIndex = 28;
            this.buttonRunMC.Text = "Run MC";
            this.buttonRunMC.UseVisualStyleBackColor = true;
            this.buttonRunMC.Click += new System.EventHandler(this.buttonRunMC_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxMCSteps);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.comboBoxMCNeighborhood);
            this.groupBox5.Controls.Add(this.textBoxMCAmount);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.buttonRunMC);
            this.groupBox5.Controls.Add(this.buttonSetMCCells);
            this.groupBox5.Location = new System.Drawing.Point(12, 468);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(405, 77);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Monte Carlo";
            // 
            // textBoxMCSteps
            // 
            this.textBoxMCSteps.Location = new System.Drawing.Point(195, 48);
            this.textBoxMCSteps.Name = "textBoxMCSteps";
            this.textBoxMCSteps.Size = new System.Drawing.Size(91, 20);
            this.textBoxMCSteps.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "MCS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Neighborhood";
            // 
            // comboBoxMCNeighborhood
            // 
            this.comboBoxMCNeighborhood.FormattingEnabled = true;
            this.comboBoxMCNeighborhood.Items.AddRange(new object[] {
            "Moore",
            "Von Neumann"});
            this.comboBoxMCNeighborhood.Location = new System.Drawing.Point(194, 20);
            this.comboBoxMCNeighborhood.Name = "comboBoxMCNeighborhood";
            this.comboBoxMCNeighborhood.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMCNeighborhood.TabIndex = 30;
            // 
            // textBoxMCAmount
            // 
            this.textBoxMCAmount.Location = new System.Drawing.Point(69, 20);
            this.textBoxMCAmount.Name = "textBoxMCAmount";
            this.textBoxMCAmount.Size = new System.Drawing.Size(39, 20);
            this.textBoxMCAmount.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "ID Amount";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.checkBoxHetero);
            this.groupBox6.Controls.Add(this.textBoxEnergyHGrain);
            this.groupBox6.Controls.Add(this.textBoxInStep);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBoxRecryFactor);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.textBoxRecryNucleons);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.radioButtonSetOnce);
            this.groupBox6.Controls.Add(this.radioButtonRekryDecr);
            this.groupBox6.Controls.Add(this.radioButtonRecryIncr);
            this.groupBox6.Controls.Add(this.radioButtonRekryConst);
            this.groupBox6.Controls.Add(this.textBoxStepsRekry);
            this.groupBox6.Controls.Add(this.textBoxEnergyHBoundary);
            this.groupBox6.Controls.Add(this.buttonShowEnergy);
            this.groupBox6.Controls.Add(this.buttonDistrEnergy);
            this.groupBox6.Controls.Add(this.buttonRunRecry);
            this.groupBox6.Location = new System.Drawing.Point(187, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(219, 260);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Recrystallization";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(138, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "H grains:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(135, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "H boundaries:";
            // 
            // checkBoxHetero
            // 
            this.checkBoxHetero.AutoSize = true;
            this.checkBoxHetero.Location = new System.Drawing.Point(10, 229);
            this.checkBoxHetero.Name = "checkBoxHetero";
            this.checkBoxHetero.Size = new System.Drawing.Size(112, 17);
            this.checkBoxHetero.TabIndex = 19;
            this.checkBoxHetero.Text = "Nucl on boudaries";
            this.checkBoxHetero.UseVisualStyleBackColor = true;
            // 
            // textBoxEnergyHGrain
            // 
            this.textBoxEnergyHGrain.Location = new System.Drawing.Point(138, 78);
            this.textBoxEnergyHGrain.Name = "textBoxEnergyHGrain";
            this.textBoxEnergyHGrain.Size = new System.Drawing.Size(70, 20);
            this.textBoxEnergyHGrain.TabIndex = 18;
            // 
            // textBoxInStep
            // 
            this.textBoxInStep.Location = new System.Drawing.Point(138, 198);
            this.textBoxInStep.Name = "textBoxInStep";
            this.textBoxInStep.Size = new System.Drawing.Size(70, 20);
            this.textBoxInStep.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(138, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "In step:";
            // 
            // textBoxRecryFactor
            // 
            this.textBoxRecryFactor.Location = new System.Drawing.Point(138, 159);
            this.textBoxRecryFactor.Name = "textBoxRecryFactor";
            this.textBoxRecryFactor.Size = new System.Drawing.Size(70, 20);
            this.textBoxRecryFactor.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(138, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Factor:";
            // 
            // textBoxRecryNucleons
            // 
            this.textBoxRecryNucleons.Location = new System.Drawing.Point(138, 120);
            this.textBoxRecryNucleons.Name = "textBoxRecryNucleons";
            this.textBoxRecryNucleons.Size = new System.Drawing.Size(70, 20);
            this.textBoxRecryNucleons.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(138, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Nucleons:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Steps";
            // 
            // radioButtonSetOnce
            // 
            this.radioButtonSetOnce.AutoSize = true;
            this.radioButtonSetOnce.Location = new System.Drawing.Point(7, 159);
            this.radioButtonSetOnce.Name = "radioButtonSetOnce";
            this.radioButtonSetOnce.Size = new System.Drawing.Size(68, 17);
            this.radioButtonSetOnce.TabIndex = 9;
            this.radioButtonSetOnce.TabStop = true;
            this.radioButtonSetOnce.Text = "Set once";
            this.radioButtonSetOnce.UseVisualStyleBackColor = true;
            // 
            // radioButtonRekryDecr
            // 
            this.radioButtonRekryDecr.AutoSize = true;
            this.radioButtonRekryDecr.Location = new System.Drawing.Point(7, 139);
            this.radioButtonRekryDecr.Name = "radioButtonRekryDecr";
            this.radioButtonRekryDecr.Size = new System.Drawing.Size(79, 17);
            this.radioButtonRekryDecr.TabIndex = 8;
            this.radioButtonRekryDecr.TabStop = true;
            this.radioButtonRekryDecr.Text = "Decreasing";
            this.radioButtonRekryDecr.UseVisualStyleBackColor = true;
            // 
            // radioButtonRecryIncr
            // 
            this.radioButtonRecryIncr.AutoSize = true;
            this.radioButtonRecryIncr.Location = new System.Drawing.Point(7, 116);
            this.radioButtonRecryIncr.Name = "radioButtonRecryIncr";
            this.radioButtonRecryIncr.Size = new System.Drawing.Size(74, 17);
            this.radioButtonRecryIncr.TabIndex = 7;
            this.radioButtonRecryIncr.TabStop = true;
            this.radioButtonRecryIncr.Text = "Increasing";
            this.radioButtonRecryIncr.UseVisualStyleBackColor = true;
            // 
            // radioButtonRekryConst
            // 
            this.radioButtonRekryConst.AutoSize = true;
            this.radioButtonRekryConst.Checked = true;
            this.radioButtonRekryConst.Location = new System.Drawing.Point(7, 93);
            this.radioButtonRekryConst.Name = "radioButtonRekryConst";
            this.radioButtonRekryConst.Size = new System.Drawing.Size(67, 17);
            this.radioButtonRekryConst.TabIndex = 6;
            this.radioButtonRekryConst.TabStop = true;
            this.radioButtonRekryConst.Text = "Constant";
            this.radioButtonRekryConst.UseVisualStyleBackColor = true;
            // 
            // textBoxStepsRekry
            // 
            this.textBoxStepsRekry.Location = new System.Drawing.Point(53, 198);
            this.textBoxStepsRekry.Name = "textBoxStepsRekry";
            this.textBoxStepsRekry.Size = new System.Drawing.Size(40, 20);
            this.textBoxStepsRekry.TabIndex = 5;
            // 
            // textBoxEnergyHBoundary
            // 
            this.textBoxEnergyHBoundary.Location = new System.Drawing.Point(138, 38);
            this.textBoxEnergyHBoundary.Name = "textBoxEnergyHBoundary";
            this.textBoxEnergyHBoundary.Size = new System.Drawing.Size(70, 20);
            this.textBoxEnergyHBoundary.TabIndex = 3;
            // 
            // buttonShowEnergy
            // 
            this.buttonShowEnergy.Location = new System.Drawing.Point(7, 50);
            this.buttonShowEnergy.Name = "buttonShowEnergy";
            this.buttonShowEnergy.Size = new System.Drawing.Size(118, 23);
            this.buttonShowEnergy.TabIndex = 2;
            this.buttonShowEnergy.Text = "Show energy";
            this.buttonShowEnergy.UseVisualStyleBackColor = true;
            this.buttonShowEnergy.Click += new System.EventHandler(this.buttonShowEnergy_Click);
            // 
            // buttonDistrEnergy
            // 
            this.buttonDistrEnergy.Location = new System.Drawing.Point(7, 20);
            this.buttonDistrEnergy.Name = "buttonDistrEnergy";
            this.buttonDistrEnergy.Size = new System.Drawing.Size(118, 23);
            this.buttonDistrEnergy.TabIndex = 1;
            this.buttonDistrEnergy.Text = "Distribute energy";
            this.buttonDistrEnergy.UseVisualStyleBackColor = true;
            this.buttonDistrEnergy.Click += new System.EventHandler(this.buttonDistrEnergy_Click);
            // 
            // buttonRunRecry
            // 
            this.buttonRunRecry.Location = new System.Drawing.Point(138, 225);
            this.buttonRunRecry.Name = "buttonRunRecry";
            this.buttonRunRecry.Size = new System.Drawing.Size(70, 23);
            this.buttonRunRecry.TabIndex = 0;
            this.buttonRunRecry.Text = "Run";
            this.buttonRunRecry.UseVisualStyleBackColor = true;
            this.buttonRunRecry.Click += new System.EventHandler(this.buttonRunRecry_Click);
            // 
            // textBoxGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 575);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PB);
            this.Name = "textBoxGS";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Button runOneStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGSx;
        private System.Windows.Forms.TextBox textBoxGSy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNucleons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSteps;
        private System.Windows.Forms.ComboBox comboBoxNbhd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button setNucleons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPixel;
        private System.Windows.Forms.Button drawGrid;
        private System.Windows.Forms.Button runAutomat;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RadioButton radioButtonPeriodic;
        private System.Windows.Forms.RadioButton radioButtonAbsorbent;
        private System.Windows.Forms.Button buttonSetInclusions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInclusions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxInclSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonCircular;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.TextBox textBoxProbability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SingleCellItem;
        private System.Windows.Forms.ToolStripMenuItem selectDualPhaseGrain;
        private ToolStripMenuItem selectNonDualPhase;
        private Button buttonSetMCCells;
        private Button buttonRunMC;
        private GroupBox groupBox5;
        private Label label13;
        private ComboBox comboBoxMCNeighborhood;
        private TextBox textBoxMCAmount;
        private Label label12;
        private TextBox textBoxMCSteps;
        private Label label14;
        private GroupBox groupBox6;
        private Button buttonRunRecry;
        private Button buttonDistrEnergy;
        private Button buttonShowEnergy;
        private TextBox textBoxEnergyHBoundary;
        private RadioButton radioButtonSetOnce;
        private RadioButton radioButtonRekryDecr;
        private RadioButton radioButtonRecryIncr;
        private RadioButton radioButtonRekryConst;
        private TextBox textBoxStepsRekry;
        private Label label16;
        private Label label15;
        private TextBox textBoxRecryFactor;
        private Label label17;
        private TextBox textBoxRecryNucleons;
        private TextBox textBoxInStep;
        private Label label18;
        private TextBox textBoxEnergyHGrain;
        private CheckBox checkBoxHetero;
        private Label label20;
        private Label label19;

    }
}

