using PuzzleQSystem;

namespace PuzzleQMAUI;

public partial class MainPage : ContentPage
{
    Game activegame;
    List<Game> lstgame = new() { new Game(), new Game(), new Game() };

    public MainPage()
    {
        InitializeComponent();
        lstgame.ForEach(g => g.GrandScoreChanged += G_GrandScoreChanged);
        Game1Rb.BindingContext = lstgame[0];
        Game2Rb.BindingContext = lstgame[1];
        Game3Rb.BindingContext = lstgame[2];
        activegame = lstgame[0];
        this.BindingContext = activegame;
    }

    private void G_GrandScoreChanged(object? sender, EventArgs e)
    {
        GrandTotal.Text = Game.GrandScore.ToString();
    }

    private void btnStart_Clicked(object sender, EventArgs e)
    {
        activegame.StartGame();
    }

    private void btnUp_Clicked(object sender, EventArgs e)
    {
        activegame.MoveUp();
        activegame.SetWinnerIfTrue();
    }

    private void btnDown_Clicked(object sender, EventArgs e)
    {
        activegame.MoveDown();
        activegame.SetWinnerIfTrue();
    }

    private void btnLeft_Clicked(object sender, EventArgs e)
    {
        activegame.MoveLeft();
        activegame.SetWinnerIfTrue();
    }

    private void btnRight_Clicked(object sender, EventArgs e)
    {
        activegame.MoveRight();
        activegame.SetWinnerIfTrue();
    }

    private void Game_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        if (rb.IsChecked && rb.BindingContext != null)
        {
            activegame = (Game)rb.BindingContext;
            this.BindingContext = activegame;
        }
    }
}
