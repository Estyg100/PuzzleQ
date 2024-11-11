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
        //OnPropertyChanged(nameof(game.Spots));
    }

    private void btnUp_Clicked(object sender, EventArgs e)
    {
        // Implement movement logic
    }

    private void btnDown_Clicked(object sender, EventArgs e)
    {
        // Implement movement logic
    }

    private void btnLeft_Clicked(object sender, EventArgs e)
    {
        // Implement movement logic
    }

    private void btnRight_Clicked(object sender, EventArgs e)
    {
        // Implement movement logic
    }
}
