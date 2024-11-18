using PuzzleQSystem;
using System.Diagnostics;

namespace PuzzleQ
{
    public partial class frmPuzzleQ : Form
    {
        Game activegame;
        List<Game> lstgame = new() { new Game(), new Game(), new Game() };
        List<PictureBox> Spots;

        List<Button> MovementButtons;

        public frmPuzzleQ()
        {
            InitializeComponent();
            btnStart.Click += ButtonStart_Click;
            btnUp.Click += BtnUp_Click;
            btnDown.Click += BtnDown_Click;
            btnLeft.Click += BtnLeft_Click;
            btnRight.Click += BtnRight_Click;
            activegame = lstgame[0];
            Spots = new() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            MovementButtons = new() { btnDown, btnLeft, btnRight, btnUp };
            lstgame.ForEach(g => g.GrandScoreChanged += G_GrandScoreChanged);
            optg1.CheckedChanged += (sender, e) => SwitchGame(0);
            optg2.CheckedChanged += (sender, e) => SwitchGame(1);
            optg3.CheckedChanged += (sender, e) => SwitchGame(2);
            RefreshBindings();
        }

        private void SwitchGame(int gameIndex)
        {
            activegame = lstgame[gameIndex];
            RefreshBindings();
        }

        private void RefreshBindings()
        {
            foreach (var spotControl in Spots)
            {
                spotControl.DataBindings.Clear();
                var spot = activegame.Spots[Spots.IndexOf(spotControl)];
                spot.StartupPath = Application.StartupPath + @"\images\";
                spotControl.DataBindings.Add("ImageLocation", spot, "SpotImageWithPath");
            }
            lblMessage.DataBindings.Clear();
            lblMessage.DataBindings.Add("Text", activegame, "Message");
            tblMain.DataBindings.Clear();
            tblMain.DataBindings.Add("BackColor", activegame, "BackgroundColor");
            lblMessage.DataBindings.Add("ForeColor", activegame, "PopOfColor");
            btnUp.DataBindings.Clear();
            btnUp.DataBindings.Add("BackColor", activegame, "PopOfColor");
            btnDown.DataBindings.Clear();
            btnDown.DataBindings.Add("BackColor", activegame, "PopOfColor");
            btnRight.DataBindings.Clear();
            btnRight.DataBindings.Add("BackColor", activegame, "PopOfColor");
            btnLeft.DataBindings.Clear();
            btnLeft.DataBindings.Add("BackColor", activegame, "PopOfColor");
            btnStart.DataBindings.Clear();
            btnStart.DataBindings.Add("BackColor", activegame, "PopOfColor");
            btnUp.DataBindings.Add("ForeColor", activegame, "ButtonForeColor");
            btnDown.DataBindings.Add("ForeColor", activegame, "ButtonForeColor");
            btnRight.DataBindings.Add("ForeColor", activegame, "ButtonForeColor");
            btnLeft.DataBindings.Add("ForeColor", activegame, "ButtonForeColor");
            btnStart.DataBindings.Add("ForeColor", activegame, "ButtonForeColor");
            optg1.DataBindings.Clear();
            optg1.DataBindings.Add("Text", lstgame[0], "RadioButtonText");
            optg2.DataBindings.Clear();
            optg2.DataBindings.Add("Text", lstgame[1], "RadioButtonText");
            optg3.DataBindings.Clear();
            optg3.DataBindings.Add("Text", lstgame[2], "RadioButtonText");
        }

        private void G_GrandScoreChanged(object? sender, EventArgs e)
        {
            lblGrandScoreNumber.Text = Game.GrandScore.ToString();
        }

        private void BtnRight_Click(object? sender, EventArgs e)
        {
            activegame.MoveRight();
            activegame.SetWinnerIfTrue();
        }

        private void BtnLeft_Click(object? sender, EventArgs e)
        {
            activegame.MoveLeft();
            activegame.SetWinnerIfTrue();
        }

        private void BtnDown_Click(object? sender, EventArgs e)
        {
            activegame.MoveDown();
            activegame.SetWinnerIfTrue();
        }

        private void BtnUp_Click(object? sender, EventArgs e)
        {
            activegame.MoveUp();
            activegame.SetWinnerIfTrue();
        }

        private void ButtonStart_Click(object? sender, EventArgs e)
        {
            activegame.StartGame();
            MovementButtons.ForEach(b => b.Enabled = true);
        }
    }
}
