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
            lblGrandScore = new Label();
            lblMessage = new Label();
            lblGrandScoreNumber = new Label();
            tblMovement = new TableLayoutPanel();
            btnUp = new Button();
            btnDown = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            btnStart = new Button();
            flpRadioButtons = new FlowLayoutPanel();
            optg1 = new RadioButton();
            optg2 = new RadioButton();
            optg3 = new RadioButton();
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
            flpRadioButtons.SuspendLayout();
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
            tblMain.AutoSize = true;
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
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.8081837F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 75.19182F));
            tblMain.Size = new Size(966, 782);
            tblMain.TabIndex = 0;
            // 
            // tblControls
            // 
            tblControls.AutoSize = true;
            tblControls.ColumnCount = 5;
            tblControls.ColumnStyles.Add(new ColumnStyle());
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.979166F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.7916679F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.729167F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.895833F));
            tblControls.Controls.Add(lblGrandScore, 3, 1);
            tblControls.Controls.Add(lblMessage, 0, 0);
            tblControls.Controls.Add(lblGrandScoreNumber, 4, 1);
            tblControls.Controls.Add(tblMovement, 2, 1);
            tblControls.Controls.Add(btnStart, 1, 1);
            tblControls.Controls.Add(flpRadioButtons, 0, 1);
            tblControls.Dock = DockStyle.Fill;
            tblControls.ForeColor = SystemColors.ControlLightLight;
            tblControls.Location = new Point(3, 3);
            tblControls.Name = "tblControls";
            tblControls.RowCount = 2;
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 47.70642F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 52.29358F));
            tblControls.Size = new Size(960, 188);
            tblControls.TabIndex = 1;
            // 
            // lblGrandScore
            // 
            lblGrandScore.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblGrandScore.AutoSize = true;
            lblGrandScore.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandScore.Location = new Point(638, 126);
            lblGrandScore.Name = "lblGrandScore";
            lblGrandScore.Size = new Size(161, 25);
            lblGrandScore.TabIndex = 3;
            lblGrandScore.Text = "Grand Total:";
            lblGrandScore.TextAlign = ContentAlignment.MiddleCenter;
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
            lblMessage.Size = new Size(954, 89);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Click Start to Begin the Game.";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrandScoreNumber
            // 
            lblGrandScoreNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblGrandScoreNumber.AutoSize = true;
            lblGrandScoreNumber.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandScoreNumber.Location = new Point(802, 126);
            lblGrandScoreNumber.Margin = new Padding(0, 0, 3, 0);
            lblGrandScoreNumber.Name = "lblGrandScoreNumber";
            lblGrandScoreNumber.Size = new Size(155, 25);
            lblGrandScoreNumber.TabIndex = 5;
            lblGrandScoreNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblMovement
            // 
            tblMovement.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblMovement.ColumnCount = 4;
            tblMovement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMovement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMovement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMovement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMovement.Controls.Add(btnUp, 0, 0);
            tblMovement.Controls.Add(btnDown, 1, 0);
            tblMovement.Controls.Add(btnLeft, 2, 0);
            tblMovement.Controls.Add(btnRight, 3, 0);
            tblMovement.Location = new Point(215, 113);
            tblMovement.Name = "tblMovement";
            tblMovement.RowCount = 1;
            tblMovement.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMovement.Size = new Size(417, 51);
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
            btnUp.Size = new Size(98, 45);
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
            btnDown.Location = new Point(107, 3);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(98, 45);
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
            btnLeft.Location = new Point(211, 3);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(98, 45);
            btnLeft.TabIndex = 2;
            btnLeft.Text = "";
            btnLeft.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            btnRight.BackColor = SystemColors.ControlLightLight;
            btnRight.Enabled = false;
            btnRight.Font = new Font("Wingdings", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnRight.ForeColor = SystemColors.ControlLightLight;
            btnRight.Location = new Point(315, 3);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(87, 45);
            btnRight.TabIndex = 3;
            btnRight.Text = "";
            btnRight.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnStart.BackColor = SystemColors.ControlLightLight;
            btnStart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.ControlLightLight;
            btnStart.Location = new Point(35, 113);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(174, 51);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // flpRadioButtons
            // 
            flpRadioButtons.AutoSize = true;
            flpRadioButtons.Controls.Add(optg1);
            flpRadioButtons.Controls.Add(optg2);
            flpRadioButtons.Controls.Add(optg3);
            flpRadioButtons.Dock = DockStyle.Fill;
            flpRadioButtons.Location = new Point(3, 92);
            flpRadioButtons.Name = "flpRadioButtons";
            flpRadioButtons.Size = new Size(26, 93);
            flpRadioButtons.TabIndex = 6;
            // 
            // optg1
            // 
            optg1.AutoSize = true;
            optg1.Checked = true;
            optg1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            optg1.Location = new Point(3, 3);
            optg1.Name = "optg1";
            optg1.Size = new Size(17, 16);
            optg1.TabIndex = 3;
            optg1.TabStop = true;
            optg1.UseVisualStyleBackColor = true;
            // 
            // optg2
            // 
            optg2.AutoSize = true;
            optg2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            optg2.Location = new Point(3, 25);
            optg2.Name = "optg2";
            optg2.Size = new Size(17, 16);
            optg2.TabIndex = 2;
            optg2.UseVisualStyleBackColor = true;
            // 
            // optg3
            // 
            optg3.AutoSize = true;
            optg3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            optg3.Location = new Point(3, 47);
            optg3.Name = "optg3";
            optg3.Size = new Size(17, 16);
            optg3.TabIndex = 0;
            optg3.UseVisualStyleBackColor = true;
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
            tblGrid.Location = new Point(183, 197);
            tblGrid.Name = "tblGrid";
            tblGrid.RowCount = 3;
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblGrid.Size = new Size(600, 582);
            tblGrid.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(203, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(403, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(194, 188);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(3, 197);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(194, 188);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Location = new Point(203, 197);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(194, 188);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Location = new Point(403, 197);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(194, 188);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.Location = new Point(3, 391);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(194, 188);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.Location = new Point(203, 391);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(194, 188);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Dock = DockStyle.Fill;
            pictureBox9.Location = new Point(403, 391);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(194, 188);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            // 
            // frmPuzzleQ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 782);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPuzzleQ";
            Text = "PuzzleQ";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblControls.ResumeLayout(false);
            tblControls.PerformLayout();
            tblMovement.ResumeLayout(false);
            flpRadioButtons.ResumeLayout(false);
            flpRadioButtons.PerformLayout();
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
            PerformLayout();
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
        private Label lblGrandScore;
        private Label lblMessage;
        private Label lblGrandScoreNumber;
        private FlowLayoutPanel flpRadioButtons;
        private RadioButton optg2;
        private RadioButton optg3;
        private RadioButton optg1;
    }
}
