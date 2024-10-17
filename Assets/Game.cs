public class Game
{
    private Bootstrapper bootstrapper;

    public Game(Score score)
    {
        this.bootstrapper.score = score;
    }

    public void StartGame()
    {
        bootstrapper.score.CurrentScore = 5;
    }

    public void EndGame()
    {
        bootstrapper.score.CurrentScore = 0;
    }
}
