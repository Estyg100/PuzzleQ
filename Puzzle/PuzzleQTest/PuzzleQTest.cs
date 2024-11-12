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

    }
}