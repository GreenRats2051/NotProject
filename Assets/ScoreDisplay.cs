using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private Bootstrapper bootstrapper;

    private void Start()
    {
        scoreText.text = "Score: " + bootstrapper.score.CurrentScore;
        bootstrapper.score.OnScoreChanged += UpdateScoreText;
    }

    public void Initialize(Score score)
    {
        this.bootstrapper.score = score;
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + bootstrapper.score.CurrentScore;
    }
}
