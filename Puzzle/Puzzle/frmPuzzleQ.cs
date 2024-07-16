using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace PuzzleQ
{
    public partial class frmPuzzleQ : Form
    {
        string path = Application.StartupPath + @"\";

        List<String> level1 = new() { @"images\Bee 1.JPG", @"images\Bee 2.JPG", @"images\Bee 3.JPG", @"images\Bee 4.JPG", @"images\Bee 5.JPG", @"images\Bee 6.JPG", @"images\Bee 7.JPG", @"images\Bee 8.JPG" };
        List<String> level2 = new() { @"images\Cherry Blossom 1.jpg", @"images\Cherry Blossom 2.jpg", @"images\Cherry Blossom 3.jpg", @"images\Cherry Blossom 4.jpg", @"images\Cherry Blossom 5.jpg", @"images\Cherry Blossom 6.jpg", @"images\Cherry Blossom 7.jpg", @"images\Cherry Blossom 8.jpg" };
        List<String> level3 = new() { @"images\Colorful Design 1.jpg", @"images\Colorful Design 2.jpg", @"images\Colorful Design 3.jpg", @"images\Colorful Design 4.jpg", @"images\Colorful Design 5.jpg", @"images\Colorful Design 6.jpg", @"images\Colorful Design 7.jpg", @"images\Colorful Design 8.jpg" };

        List<PictureBox> CanMoveRightResults;
        List<PictureBox> CanMoveRightSource;
        List<PictureBox> CanMoveLeftResults;
        List<PictureBox> CanMoveLeftSource;
        List<PictureBox> CanMoveUpResults;
        List<PictureBox> CanMoveUpSource;
        List<PictureBox> CanMoveDownResults;
        List<PictureBox> CanMoveDownSource;

        List<Button> MovementButtons;

        List<PictureBox> All;

        private enum LevelEnum { Level1, Level2, Level3 };
        LevelEnum currentlevel = LevelEnum.Level1;

        private enum GameStatus { NotStarted, Playing, Winner }
        GameStatus gamestatus = GameStatus.NotStarted;

        public frmPuzzleQ()
        {
            InitializeComponent();
            btnStart.Click += ButtonStart_Click;
            btnUp.Click += BtnUp_Click;
            btnDown.Click += BtnDown_Click;
            btnLeft.Click += BtnLeft_Click;
            btnRight.Click += BtnRight_Click;
            CanMoveRightResults = new() { pictureBox2, pictureBox3, pictureBox5, pictureBox6, pictureBox8, pictureBox9 };
            CanMoveRightSource = new() { pictureBox1, pictureBox2, pictureBox4, pictureBox5, pictureBox7, pictureBox8 };
            CanMoveLeftResults = new() { pictureBox2, pictureBox1, pictureBox5, pictureBox4, pictureBox8, pictureBox7 };
            CanMoveLeftSource = new() { pictureBox3, pictureBox2, pictureBox6, pictureBox5, pictureBox9, pictureBox8 };
            CanMoveUpResults = new() { pictureBox4, pictureBox1, pictureBox5, pictureBox2, pictureBox6, pictureBox3 };
            CanMoveUpSource = new() { pictureBox7, pictureBox4, pictureBox8, pictureBox5, pictureBox9, pictureBox6 };
            CanMoveDownResults = new() { pictureBox4, pictureBox7, pictureBox5, pictureBox8, pictureBox6, pictureBox9 };
            CanMoveDownSource = new() { pictureBox1, pictureBox4, pictureBox2, pictureBox5, pictureBox3, pictureBox6 };
            MovementButtons = new() { btnDown, btnLeft, btnRight, btnUp };
            All = new() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
        }

        private void SettingsBasedOnLevelAndGameStatus()
        {
            if (gamestatus == GameStatus.NotStarted)
            {
                lblScore.Text = "Score - ";
                lblScoreNumber.Text = "0";
                gamestatus = GameStatus.Playing;
                currentlevel = LevelEnum.Level1;
                lblCurrentLevel.Text = "Current Level - 1";
            }
            else if (gamestatus == GameStatus.Playing)
            {
                DecreaseScore();
            }
            else if (gamestatus == GameStatus.Winner)
            {
                gamestatus = GameStatus.Playing;
                if (currentlevel == LevelEnum.Level1)
                {
                    currentlevel = LevelEnum.Level2;
                    lblCurrentLevel.Text = "Current Level - 2";
                }
                else if (currentlevel == LevelEnum.Level2)
                {
                    currentlevel = LevelEnum.Level3;
                    lblCurrentLevel.Text = "Current Level - 3";
                }
                else
                {
                    currentlevel = LevelEnum.Level1;
                    lblCurrentLevel.Text = "CurrentLevel - 1";
                }
            }
        }

        private void SetColors()
        {
            if (gamestatus == GameStatus.Playing)
            {
                if (currentlevel == LevelEnum.Level1)
                {
                    lblMessage.BackColor = Color.White;
                    lblMessage.ForeColor = Color.Gold;
                    tblMain.BackColor = Color.LemonChiffon;
                }
                else if (currentlevel == LevelEnum.Level2)
                {
                    lblMessage.BackColor = Color.White;
                    lblMessage.ForeColor = Color.IndianRed;
                    tblMain.BackColor = Color.LightCoral;
                }
                else if (currentlevel == LevelEnum.Level3)
                {
                    lblMessage.BackColor = Color.White;
                    lblMessage.ForeColor = Color.Teal;
                    tblMain.BackColor = Color.MediumTurquoise;
                }
            }
            else if (gamestatus == GameStatus.Winner)
            {
                tblMain.BackColor = Color.HotPink;
                lblMessage.BackColor = Color.HotPink;
                lblMessage.ForeColor = Color.White;
            }
        }

        private void SetMessageLabelAndColors()
        {
            SetColors();
            if (gamestatus == GameStatus.Playing)
            {
                lblMessage.Text = "Try to complete the picture by moving the photos around using the arrow buttons. You can click start anytime to get a new layout, but your score will decrease.";
            }
            else if (gamestatus == GameStatus.Winner)
            {
                if (currentlevel == LevelEnum.Level3)
                {
                    lblMessage.Text = "YOU WON! CONGRATULATIONS! YOU HAVE SUCCESSFULLY COMPLETED ALL THREE LEVELS! Click Start to begin from level 1.";
                }
                else
                {
                    lblMessage.Text = "YOU WON! HOORAY! Click Start to proceed to the next level.";
                }
            }
        }

        private string GetPicture(List<String> lst)
        {
            Random rnd = new();
            int countofpics = lst.Count();
            int n = rnd.Next(0, countofpics);
            string picture = lst[n];
            return picture;
        }

        private List<String> GetCopyList()
        {
            int n = 0;
            List<String> list = new();
            List<String> copy = new();
            switch (currentlevel)
            {
                case LevelEnum.Level1:
                    list = level1;
                    break;
                case LevelEnum.Level2:
                    list = level2;
                    break;
                case LevelEnum.Level3:
                    list = level3;
                    break;
            }
            for (int i = 1; i <= 8; i++)
            {
                if (i > 1)
                {
                    n = n + 1;
                }
                copy.Add(list[n]);
            }
            return copy;
        }

        private void GetRandomPictureInAllBoxes()
        {
            int n = 0;
            List<String> copy = GetCopyList();
            for (int i = 1; i <= 8; i++)
            {
                if (i > 1)
                {
                    n = n + 1;
                }
                string picture = GetPicture(copy);
                All[n].ImageLocation = path + picture;
                copy.Remove(picture);
            }
        }

        private void MovePhoto(PictureBox pbresults, List<PictureBox> listresults, List<PictureBox> listsource)
        {
            if (pbresults.ImageLocation == null)
            {
                int n = listresults.IndexOf(pbresults);
                pbresults = listresults[n];
                PictureBox pbsource = listsource[n];
                pbresults.ImageLocation = pbsource.ImageLocation;
                pbsource.ImageLocation = null;
            }
        }

        private void MoveCorrectPhoto(List<PictureBox> listresults, List<PictureBox> listsource)
        {
            MovePhoto(listresults[0], listresults, listsource);
            MovePhoto(listresults[1], listresults, listsource);
            MovePhoto(listresults[2], listresults, listsource);
            MovePhoto(listresults[3], listresults, listsource);
            MovePhoto(listresults[4], listresults, listsource);
            MovePhoto(listresults[5], listresults, listsource);
        }

        private void MoveRight()
        {
            MoveCorrectPhoto(CanMoveRightResults, CanMoveRightSource);
        }

        private void MoveLeft()
        {
            MoveCorrectPhoto(CanMoveLeftResults, CanMoveLeftSource);
        }
        private void MoveUp()
        {
            MoveCorrectPhoto(CanMoveUpResults, CanMoveUpSource);
        }

        private void MoveDown()
        {
            MoveCorrectPhoto(CanMoveDownResults, CanMoveDownSource);
        }

        private bool CheckForWinner()
        {
            bool winner = false;
            List<String> lst = new();
            switch (currentlevel)
            {
                case LevelEnum.Level1:
                    lst = level1;
                    break;
                case LevelEnum.Level2:
                    lst = level2;
                    break;
                case LevelEnum.Level3:
                    lst = level3;
                    break;
            }
            if (pictureBox1.ImageLocation == path + lst[0] && pictureBox2.ImageLocation == path + lst[1] && pictureBox3.ImageLocation == path + lst[2] && pictureBox4.ImageLocation == path + lst[3] && pictureBox5.ImageLocation == path + lst[4] && pictureBox6.ImageLocation == path + lst[5] && pictureBox7.ImageLocation == path + lst[6] && pictureBox8.ImageLocation == path + lst[7])
            {
                winner = true;
            }
            return winner;
        }

        private void IncreaseScore()
        {
            bool b = int.TryParse(lblScoreNumber.Text, out int n);
            if (b == true)
            {
                lblScoreNumber.Text = (n + 1).ToString();
            }
        }

        private void DecreaseScore()
        {
            bool b = int.TryParse(lblScoreNumber.Text, out int n);
            if (b == true)
            {
                lblScoreNumber.Text = (n - 1).ToString();
            }
        }

        private void SetWinnerIfTrue()
        {
            bool winner = CheckForWinner();
            if (winner == true)
            {
                gamestatus = GameStatus.Winner;
                MovementButtons.ForEach(b => b.Enabled = false);
                IncreaseScore();
                switch (currentlevel)
                {
                    case LevelEnum.Level1:
                        pictureBox9.ImageLocation = path + @"images\Bee 9.JPG";
                        break;
                    case LevelEnum.Level2:
                        pictureBox9.ImageLocation = path + @"images\Cherry Blossom 9.jpg";
                        break;
                    case LevelEnum.Level3:
                        pictureBox9.ImageLocation = path + @"images\Colorful Design 9.jpg";
                        break;
                }
                SetMessageLabelAndColors();
            }
        }

        private void BtnRight_Click(object? sender, EventArgs e)
        {
            MoveRight();
            SetWinnerIfTrue();
        }

        private void BtnLeft_Click(object? sender, EventArgs e)
        {
            MoveLeft();
            SetWinnerIfTrue();
        }

        private void BtnDown_Click(object? sender, EventArgs e)
        {
            MoveDown();
            SetWinnerIfTrue();
        }

        private void BtnUp_Click(object? sender, EventArgs e)
        {
            MoveUp();
            SetWinnerIfTrue();
        }

        private void ButtonStart_Click(object? sender, EventArgs e)
        {
            pictureBox9.ImageLocation = null;
            SettingsBasedOnLevelAndGameStatus();
            SetMessageLabelAndColors();
            GetRandomPictureInAllBoxes();
            MovementButtons.ForEach(b => b.Enabled = true);
        }
    }
}
