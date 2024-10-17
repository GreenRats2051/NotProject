using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public Score score;
    public Game game;
    public InputListener inputListener;
    public ClickableObject clickableObject;
    public ScoreDisplay scoreDisplay;

    void Awake()
    {
        score = new Score();
        game = new Game();
        inputListener = gameObject.AddComponent<InputListener>();
        clickableObject = FindObjectOfType<ClickableObject>();
        scoreDisplay = FindObjectOfType<ScoreDisplay>();
    }

    void Start()
    {
        game.StartGame(this);
    }
}
