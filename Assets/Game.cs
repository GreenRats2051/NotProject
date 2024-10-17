public class Game
{
    public void StartGame(Bootstrapper bootstrapper)
    {
        bootstrapper.score.CurrentScore = 5;
    }

    public void EndGame(Bootstrapper bootstrapper)
    {
        bootstrapper.score.CurrentScore = 0;
    }
}
