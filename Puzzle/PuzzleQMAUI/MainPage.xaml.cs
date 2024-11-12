using PuzzleQSystem;

namespace PuzzleQMAUI;

public partial class MainPage : ContentPage
{
    Game game = new();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = game;
    }

    private void btnStart_Clicked(object sender, EventArgs e)
    {
        game.StartGame();
    }

    private void btnUp_Clicked(object sender, EventArgs e)
    {
        game.MoveUp();
        game.SetWinnerIfTrue();
    }

    private void btnDown_Clicked(object sender, EventArgs e)
    {
        game.MoveDown();
        game.SetWinnerIfTrue();
    }

    private void btnLeft_Clicked(object sender, EventArgs e)
    {
        game.MoveLeft();
        game.SetWinnerIfTrue();
    }

    private void btnRight_Clicked(object sender, EventArgs e)
    {
        game.MoveRight();
        game.SetWinnerIfTrue();
    }
}
