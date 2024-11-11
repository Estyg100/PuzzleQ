using PuzzleQSystem;

namespace PuzzleQTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStartGame()
        {
            Game game = new();
            game.StartGame();
            string message = $"game status = {game.GameStatus.ToString()}, num spots = {game.Spots.Count}";
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.Playing && game.Spots.Count == 9, message);
            TestContext.WriteLine(message);
        }

        [Test]
        public void TestTakeMove()
        {
            Game game = new();
            game.StartGame();
            string imagename = game.Spots[7].SpotImage;
            string oldimage = $"spot 8 image = {game.Spots[7].SpotImage}";
            TestContext.WriteLine(oldimage);
            game.MoveRight();
            string messsage = $"spot 9 image = {imagename}";
            Assert.IsTrue(game.Spots[8].SpotImage == imagename, messsage);
            TestContext.WriteLine(messsage);
        }

        [Test]
        public void TestWinner()
        {
            Game game = new();
            game.StartGame();
            game.SetWinnerIfTrue();
            bool b = false;
            if (game.Spots[8].SpotImage == @"images\bee9.jpg")
            {
                b = true;
            }
            string message = $"Winner = {b}";
            TestContext.WriteLine(message);
            game.Spots[0].SpotImage = @"images\bee1.jpg";
            game.Spots[1].SpotImage = @"images\bee2.jpg";
            game.Spots[2].SpotImage = @"images\bee3.jpg";
            game.Spots[3].SpotImage = @"images\bee4.jpg";
            game.Spots[4].SpotImage = @"images\bee5.jpg";
            game.Spots[5].SpotImage = @"images\bee6.jpg";
            game.Spots[6].SpotImage = @"images\bee7.jpg";
            game.Spots[7].SpotImage = @"images\bee8.jpg";
            game.SetWinnerIfTrue();
            if (game.Spots[8].SpotImage == @"images\bee9.jpg")
            {
                b = true;
            }
            string message2 = $"Winner = {b}";
            Assert.IsTrue(b = true, message);
            TestContext.WriteLine(message2);
        }
    }
}