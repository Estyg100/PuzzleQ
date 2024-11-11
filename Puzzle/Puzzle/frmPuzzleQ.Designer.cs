namespace PuzzleQ
{
    partial class frmPuzzleQ
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzleQ));
            tblMain = new TableLayoutPanel();
            tblControls = new TableLayoutPanel();
            btnStart = new Button();
            tblMovement = new TableLayoutPanel();
            btnUp = new Button();
            btnDown = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            lblCurrentLevel = new Label();
            lblScore = new Label();
            lblMessage = new Label();
            lblScoreNumber = new Label();
            tblGrid = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            tblMain.SuspendLayout();
            tblControls.SuspendLayout();
            tblMovement.SuspendLayout();
            tblGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = SystemColors.ControlLightLight;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(tblControls, 0, 0);
            tblMain.Controls.Add(tblGrid, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5826559F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 84.41734F));
            tblMain.Size = new Size(966, 738);
            tblMain.TabIndex = 0;
            // 
            // tblControls
            // 
            tblControls.ColumnCount = 5;
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.395833F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.4375F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.333334F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.729167F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.895833F));
            tblControls.Controls.Add(btnStart, 0, 1);
            tblControls.Controls.Add(tblMovement, 1, 1);
            tblControls.Controls.Add(lblCurrentLevel, 2, 1);
            tblControls.Controls.Add(lblScore, 3, 1);
            tblControls.Controls.Add(lblMessage, 0, 0);
            tblControls.Controls.Add(lblScoreNumber, 4, 1);
            tblControls.Dock = DockStyle.Fill;
            tblControls.ForeColor = SystemColors.ControlLightLight;
            tblControls.Location = new Point(3, 3);
            tblControls.Name = "tblControls";
            tblControls.RowCount = 2;
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 47.70642F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 52.29358F));
            tblControls.Size = new Size(960, 109);
            tblControls.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ControlLightLight;
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.ControlLightLight;
            btnStart.Location = new Point(3, 55);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(113, 51);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // tblMovement
            // 
            tblMovement.ColumnCount = 4;
            tblMovement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMovement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMovement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMovement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMovement.Controls.Add(btnUp, 0, 0);
            tblMovement.Controls.Add(btnDown, 1, 0);
            tblMovement.Controls.Add(btnLeft, 2, 0);
            tblMovement.Controls.Add(btnRight, 3, 0);
            tblMovement.Dock = DockStyle.Fill;
            tblMovement.Location = new Point(122, 55);
            tblMovement.Name = "tblMovement";
            tblMovement.RowCount = 1;
            tblMovement.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMovement.Size = new Size(363, 51);
            tblMovement.TabIndex = 1;
            // 
            // btnUp
            // 
            btnUp.BackColor = SystemColors.ControlLightLight;
            btnUp.Dock = DockStyle.Fill;
            btnUp.Enabled = false;
            btnUp.Font = new Font("Wingdings", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnUp.ForeColor = SystemColors.ControlLightLight;
            btnUp.Location = new Point(3, 3);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(84, 45);
            btnUp.TabIndex = 0;
            btnUp.Text = "";
            btnUp.UseVisualStyleBackColor = false;
            // 
            // btnDown
            // 
            btnDown.BackColor = SystemColors.ControlLightLight;
            btnDown.Dock = DockStyle.Fill;
            btnDown.Enabled = false;
            btnDown.Font = new Font("Wingdings", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnDown.ForeColor = SystemColors.ControlLightLight;
            btnDown.Location = new Point(93, 3);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(84, 45);
            btnDown.TabIndex = 1;
            btnDown.Text = "";
            btnDown.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = SystemColors.ControlLightLight;
            btnLeft.Dock = DockStyle.Fill;
            btnLeft.Enabled = false;
            btnLeft.Font = new Font("Wingdings", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnLeft.ForeColor = SystemColors.ControlLightLight;
            btnLeft.Location = new Point(183, 3);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(84, 45);
            btnLeft.TabIndex = 2;
            btnLeft.Text = "";
            btnLeft.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            btnRight.BackColor = SystemColors.ControlLightLight;
            btnRight.Dock = DockStyle.Fill;
            btnRight.Enabled = false;
            btnRight.Font = new Font("Wingdings", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnRight.ForeColor = SystemColors.ControlLightLight;
            btnRight.Location = new Point(273, 3);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(87, 45);
            btnRight.TabIndex = 3;
            btnRight.Text = "";
            btnRight.UseVisualStyleBackColor = false;
            // 
            // lblCurrentLevel
            // 
            lblCurrentLevel.AutoSize = true;
            lblCurrentLevel.Dock = DockStyle.Fill;
            lblCurrentLevel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentLevel.ForeColor = SystemColors.ControlLightLight;
            lblCurrentLevel.Location = new Point(491, 52);
            lblCurrentLevel.Name = "lblCurrentLevel";
            lblCurrentLevel.Size = new Size(170, 57);
            lblCurrentLevel.TabIndex = 2;
            lblCurrentLevel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Dock = DockStyle.Right;
            lblScore.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(812, 52);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 57);
            lblScore.TabIndex = 3;
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = SystemColors.ControlLightLight;
            tblControls.SetColumnSpan(lblMessage, 5);
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = SystemColors.ControlLightLight;
            lblMessage.Location = new Point(3, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(954, 52);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Click Start to Begin the Game.";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreNumber
            // 
            lblScoreNumber.AutoSize = true;
            lblScoreNumber.Dock = DockStyle.Left;
            lblScoreNumber.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreNumber.Location = new Point(818, 52);
            lblScoreNumber.Name = "lblScoreNumber";
            lblScoreNumber.Size = new Size(0, 57);
            lblScoreNumber.TabIndex = 5;
            lblScoreNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblGrid
            // 
            tblGrid.Anchor = AnchorStyles.None;
            tblGrid.AutoSize = true;
            tblGrid.ColumnCount = 3;
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblGrid.Controls.Add(pictureBox1, 0, 0);
            tblGrid.Controls.Add(pictureBox2, 1, 0);
            tblGrid.Controls.Add(pictureBox3, 2, 0);
            tblGrid.Controls.Add(pictureBox4, 0, 1);
            tblGrid.Controls.Add(pictureBox5, 1, 1);
            tblGrid.Controls.Add(pictureBox6, 2, 1);
            tblGrid.Controls.Add(pictureBox7, 0, 2);
            tblGrid.Controls.Add(pictureBox8, 1, 2);
            tblGrid.Controls.Add(pictureBox9, 2, 2);
            tblGrid.Location = new Point(183, 126);
            tblGrid.Name = "tblGrid";
            tblGrid.RowCount = 3;
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblGrid.Size = new Size(600, 600);
            tblGrid.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(203, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 194);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(403, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(194, 194);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(3, 203);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(194, 194);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Location = new Point(203, 203);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(194, 194);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Location = new Point(403, 203);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(194, 194);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.Location = new Point(3, 403);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(194, 194);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.Location = new Point(203, 403);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(194, 194);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Dock = DockStyle.Fill;
            pictureBox9.Location = new Point(403, 403);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(194, 194);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            // 
            // frmPuzzleQ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 738);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPuzzleQ";
            Text = "PuzzleQ";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblControls.ResumeLayout(false);
            tblControls.PerformLayout();
            tblMovement.ResumeLayout(false);
            tblGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblGrid;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private TableLayoutPanel tblControls;
        private Button btnStart;
        private TableLayoutPanel tblMovement;
        private Button btnUp;
        private Button btnDown;
        private Button btnLeft;
        private Button btnRight;
        private Label lblCurrentLevel;
        private Label lblScore;
        private Label lblMessage;
        private Label lblScoreNumber;
    }
}
