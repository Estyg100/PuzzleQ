using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PuzzleQSystem
{
    public class Game : INotifyPropertyChanged
    {
        public enum GameStatusEnum { NotStarted, Playing, Winner }

        public enum CurrentLevelEnum { Level1, Level2, Level3 }

        List<Spot> CanMoveRightResults;
        List<Spot> CanMoveRightSource;
        List<Spot> CanMoveLeftResults;
        List<Spot> CanMoveLeftSource;
        List<Spot> CanMoveUpResults;
        List<Spot> CanMoveUpSource;
        List<Spot> CanMoveDownResults;
        List<Spot> CanMoveDownSource;

        List<String> Level1ImageNames = new() { "bee1.jpg", "bee2.jpg", "bee3.jpg", "bee4.jpg", "bee5.jpg", "bee6.jpg", "bee7.jpg", "bee8.jpg" };
        List<String> Level2ImageNames = new() { "cherryblossom1.jpg", "cherryblossom2.jpg", "cherryblossom3.jpg", "cherryblossom4.jpg", "cherryblossom5.jpg", "cherryblossom6.jpg", "cherryblossom7.jpg", "cherryblossom8.jpg" };
        List<String> Level3ImageNames = new() { "colorfuldesign1.jpg", "colorfuldesign2.jpg", "colorfuldesign3.jpg", "colorfuldesign4.jpg", "colorfuldesign5.jpg", "colorfuldesign6.jpg", "colorfuldesign7.jpg", "colorfuldesign8.jpg", "colorfuldesign9.jpg" };

        GameStatusEnum _gamestatus = GameStatusEnum.NotStarted;
        CurrentLevelEnum _currentlevel = CurrentLevelEnum.Level1;

        int _score = 0;

        string _message = "Click Start to Begin the Game.";

        System.Drawing.Color _popofcolor;

        private static int numgames;

        public static int GrandScore = 0;

        public Game()
        {
            numgames++;
            this.GameName = "Game " + numgames;
            for (int i = 0; i < 9; i++)
            {
                this.Spots.Add(new Spot());
            }
            CanMoveRightResults = new() { this.Spots[1], this.Spots[2], this.Spots[4], this.Spots[5], this.Spots[7], this.Spots[8] };
            CanMoveRightSource = new() { this.Spots[0], this.Spots[1], this.Spots[3], this.Spots[4], this.Spots[6], this.Spots[7] };
            CanMoveLeftResults = new() { this.Spots[1], this.Spots[0], this.Spots[4], this.Spots[3], this.Spots[7], this.Spots[6] };
            CanMoveLeftSource = new() { this.Spots[2], this.Spots[1], this.Spots[5], this.Spots[4], this.Spots[8], this.Spots[7] };
            CanMoveUpResults = new() { this.Spots[3], this.Spots[0], this.Spots[4], this.Spots[1], this.Spots[5], this.Spots[2] };
            CanMoveUpSource = new() { this.Spots[6], this.Spots[3], this.Spots[7], this.Spots[4], this.Spots[8], this.Spots[5] };
            CanMoveDownResults = new() { this.Spots[3], this.Spots[6], this.Spots[4], this.Spots[7], this.Spots[5], this.Spots[8] };
            CanMoveDownSource = new() { this.Spots[0], this.Spots[3], this.Spots[1], this.Spots[4], this.Spots[2], this.Spots[5] };
            this.PopOfColor = this.PlayingColor;
        }

        public List<Spot> Spots { get; private set; } = new();

        public string GameName { get; private set; }

        public string RadioButtonText { get => this.GameName + " - " + this.leveldesc + " - Score: " + this.score.ToString(); }

        public GameStatusEnum GameStatus
        {
            get => _gamestatus;
            private set
            {
                _gamestatus = value;
                this.InvokePropertyChanged();
            }
        }

        public CurrentLevelEnum CurrentLevel
        {
            get => _currentlevel;
            private set
            {
                _currentlevel = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("leveldesc");
                this.InvokePropertyChanged(nameof(RadioButtonText));
            }
        }

        public string leveldesc { get => this.CurrentLevel.ToString().Substring(0, 5) + ": " + this.CurrentLevel.ToString().Substring(5); }

        public int score
        {
            get => _score;
            private set
            {
                if (_score != value)
                {
                    _score = value;
                    this.InvokePropertyChanged();
                    this.InvokePropertyChanged(nameof(RadioButtonText));
                }
            }
        }

        public string Message
        {
            get => _message;
            private set
            {
                _message = value;
                this.InvokePropertyChanged();
            }
        }

        public System.Drawing.Color PopOfColor
        {
            get => _popofcolor;
            set
            {
                _popofcolor = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("PopOfColorMaui");
            }
        }

        public Microsoft.Maui.Graphics.Color PopOfColorMaui
        {
            get => this.ConvertToMauiColor(this.PopOfColor);
        }

        public Microsoft.Maui.Graphics.Color BackColorMaui
        {
            get => this.ConvertToMauiColor(this.BackgroundColor);
        }

        public Microsoft.Maui.Graphics.Color ButtonForeColorMaui
        {
            get => this.ConvertToMauiColor(this.ButtonForeColor);
        }

        public System.Drawing.Color PlayingColor { get; set; } = System.Drawing.Color.Orange;

        public System.Drawing.Color WinnerColor { get; set; } = System.Drawing.Color.Red;

        public System.Drawing.Color BackgroundColor { get; set; } = System.Drawing.Color.HotPink;

        public System.Drawing.Color ButtonForeColor { get; set; } = System.Drawing.Color.White;

        public event PropertyChangedEventHandler? PropertyChanged;

        public event EventHandler? GrandScoreChanged;

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        private Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;
            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }

        public void StartGame()
        {
            this.Spots.ForEach(s => s.Clear());
            this.PopOfColor = this.PlayingColor;
            SetGameAttributes();
            Shuffle();
            SetMessage();
        }

        private void TakeMove(List<Spot> listresults, List<Spot> listsource)
        {
            MovePhoto(listresults[0], listresults, listsource);
            MovePhoto(listresults[1], listresults, listsource);
            MovePhoto(listresults[2], listresults, listsource);
            MovePhoto(listresults[3], listresults, listsource);
            MovePhoto(listresults[4], listresults, listsource);
            MovePhoto(listresults[5], listresults, listsource);
        }

        private void MovePhoto(Spot spotresults, List<Spot> listresults, List<Spot> listsource)
        {
            if (spotresults.SpotImage == "" || spotresults.SpotImage.Contains(".jpg") == false)
            {
                int n = listresults.IndexOf(spotresults);
                spotresults = listresults[n];
                Spot spotsource = listsource[n];
                spotresults.SpotImage = spotsource.SpotImage;
                spotsource.Clear();
            }
        }

        private void Shuffle()
        {
            GetCorrectLayout();
            Random rnd = new();
            int n = rnd.Next(250, 500);
            for (int i = 0; i < n; i++)
            {
                TakeRandomMove();
            }
            GetSpot9Blank();
        }

        private void GetSpot9Blank()
        {
            if (this.Spots[0].SpotImage == "")
            {
                MoveUp();
                MoveUp();
                MoveLeft();
                MoveLeft();
            }
            else if (this.Spots[1].SpotImage == "")
            {
                MoveUp();
                MoveUp();
                MoveLeft();
            }
            else if (this.Spots[2].SpotImage == "")
            {
                MoveUp();
                MoveUp();
            }
            else if (this.Spots[3].SpotImage == "")
            {
                MoveUp();
                MoveLeft();
                MoveLeft();
            }
            else if (this.Spots[4].SpotImage == "")
            {
                MoveUp();
                MoveLeft();
            }
            else if (this.Spots[5].SpotImage == "")
            {
                MoveUp();
            }
            else if (this.Spots[6].SpotImage == "")
            {
                MoveLeft();
                MoveLeft();
            }
            else if (this.Spots[7].SpotImage == "")
            {
                MoveLeft();
            }
        }

        private void TakeRandomMove()
        {
            Random rnd = new();
            int n = rnd.Next(1, 5);
            switch (n)
            {
                case 1:
                    MoveRight();
                    break;
                case 2:
                    MoveLeft();
                    break;
                case 3:
                    MoveUp();
                    break;
                case 4:
                    MoveDown();
                    break;
            }
        }

        private void GetCorrectLayout()
        {
            List<String> list = new();
            switch (CurrentLevel)
            {
                case CurrentLevelEnum.Level1:
                    list = Level1ImageNames;
                    break;
                case CurrentLevelEnum.Level2:
                    list = Level2ImageNames;
                    break;
                case CurrentLevelEnum.Level3:
                    list = Level3ImageNames;
                    break;
            }
            this.Spots[0].SpotImage = list[0];
            this.Spots[1].SpotImage = list[1];
            this.Spots[2].SpotImage = list[2];
            this.Spots[3].SpotImage = list[3];
            this.Spots[4].SpotImage = list[4];
            this.Spots[5].SpotImage = list[5];
            this.Spots[6].SpotImage = list[6];
            this.Spots[7].SpotImage = list[7];
        }

        public void MoveRight()
        {
            TakeMove(CanMoveRightResults, CanMoveRightSource);
        }

        public void MoveLeft()
        {
            TakeMove(CanMoveLeftResults, CanMoveLeftSource);
        }
        public void MoveUp()
        {
            TakeMove(CanMoveUpResults, CanMoveUpSource);
        }

        public void MoveDown()
        {
            TakeMove(CanMoveDownResults, CanMoveDownSource);
        }

        private void SetGameAttributes()
        {
            if (GameStatus == GameStatusEnum.Playing)
            {
                this.score = this.score - 1;
                GrandScore = GrandScore - 1;
                GrandScoreChanged?.Invoke(this, new EventArgs());
            }
            else
            {
                GameStatus = GameStatusEnum.Playing;
            }
        }


        private void SetMessage()
        {
            if (GameStatus == GameStatusEnum.Playing)
            {
                this.Message = "Try to complete the picture by moving the photos around using the arrow buttons. You can click start anytime to get a new layout, but your score will decrease.";
            }
            else if (GameStatus == GameStatusEnum.Winner)
            {
                if (CurrentLevel == CurrentLevelEnum.Level3)
                {
                    this.Message = "YOU WON! CONGRATULATIONS! YOU HAVE SUCCESSFULLY COMPLETED ALL THREE LEVELS!" + Environment.NewLine + "Click Start to begin from level 1 again.";
                }
                else
                {
                    this.Message = "YOU WON! HOORAY!" + Environment.NewLine + "Click Start to proceed to the next level.";
                }
            }
        }

        private bool DetectWinner()
        {
            bool winner = false;
            List<String> lst = new();
            switch (CurrentLevel)
            {
                case CurrentLevelEnum.Level1:
                    lst = Level1ImageNames;
                    break;
                case CurrentLevelEnum.Level2:
                    lst = Level2ImageNames;
                    break;
                case CurrentLevelEnum.Level3:
                    lst = Level3ImageNames;
                    break;
            }
            if (this.Spots[0].SpotImage == lst[0] && this.Spots[1].SpotImage == lst[1] && this.Spots[2].SpotImage == lst[2] && this.Spots[3].SpotImage == lst[3] && this.Spots[4].SpotImage == lst[4] && this.Spots[5].SpotImage == lst[5] && this.Spots[6].SpotImage == lst[6] && this.Spots[7].SpotImage == lst[7])
            {
                winner = true;
            }
            return winner;
        }

        public void SetWinnerIfTrue()
        {
            bool winner = DetectWinner();
            if (winner)
            {
                GameStatus = GameStatusEnum.Winner;
                this.score++;
                GrandScore++;
                GrandScoreChanged?.Invoke(this, new EventArgs());
                InvokePropertyChanged(nameof(score));
                this.PopOfColor = this.WinnerColor;
                switch (CurrentLevel)
                {
                    case CurrentLevelEnum.Level1:
                        this.Spots[8].SpotImage = "bee9.jpg";
                        break;
                    case CurrentLevelEnum.Level2:
                        this.Spots[8].SpotImage = "cherryblossom9.jpg";
                        break;
                    case CurrentLevelEnum.Level3:
                        this.Spots[8].SpotImage = "colorfuldesign9.jpg";
                        break;
                }
                SetMessage();
                if (CurrentLevel == CurrentLevelEnum.Level3)
                {
                    CurrentLevel = CurrentLevelEnum.Level1;
                }
                else
                {
                    CurrentLevel += 1;
                }
            }
        }


    }
}
