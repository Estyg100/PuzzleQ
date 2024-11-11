using PuzzleQSystem;

namespace PuzzleQ
{
    public partial class frmPuzzleQ : Form
    {
        Game game = new();
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
            Spots = new() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            Spots.ForEach(s => {
                Spot spot = game.Spots[Spots.IndexOf(s)];
                spot.StartupPath = Application.StartupPath + @"\images\";
                s.DataBindings.Add("ImageLocation", spot, "SpotImageWithPath");
            }
            );
            lblMessage.DataBindings.Add("Text", game, "message");
            lblCurrentLevel.DataBindings.Add("Text", game, "leveldesc");
            lblScoreNumber.DataBindings.Add("Text", game, "score");
            tblMain.DataBindings.Add("BackColor", game, "BackgroundColor");
            lblMessage.DataBindings.Add("ForeColor", game, "PopOfColor");
            btnUp.DataBindings.Add("BackColor", game, "PopOfColor");
            btnDown.DataBindings.Add("BackColor", game, "PopOfColor");
            btnRight.DataBindings.Add("BackColor", game, "PopOfColor");
            btnLeft.DataBindings.Add("BackColor", game, "PopOfColor");
            btnStart.DataBindings.Add("BackColor", game, "PopOfColor");
            btnUp.DataBindings.Add("ForeColor", game, "ButtonForeColor");
            btnDown.DataBindings.Add("ForeColor", game, "ButtonForeColor");
            btnRight.DataBindings.Add("ForeColor", game, "ButtonForeColor");
            btnLeft.DataBindings.Add("ForeColor", game, "ButtonForeColor");
            btnStart.DataBindings.Add("ForeColor", game, "ButtonForeColor");
            MovementButtons = new() { btnDown, btnLeft, btnRight, btnUp };
        }

        private void BtnRight_Click(object? sender, EventArgs e)
        {
            game.MoveRight();
            game.SetWinnerIfTrue();
        }

        private void BtnLeft_Click(object? sender, EventArgs e)
        {
            game.MoveLeft();
            game.SetWinnerIfTrue();
        }

        private void BtnDown_Click(object? sender, EventArgs e)
        {
            game.MoveDown();
            game.SetWinnerIfTrue();
        }

        private void BtnUp_Click(object? sender, EventArgs e)
        {
            game.MoveUp();
            game.SetWinnerIfTrue();
        }

        private void ButtonStart_Click(object? sender, EventArgs e)
        {
            game.StartGame();
            MovementButtons.ForEach(b => b.Enabled = true);
        }
    }
}
