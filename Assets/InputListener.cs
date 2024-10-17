using UnityEngine;

public class InputListener : MonoBehaviour
{
    private Bootstrapper bootstrapper;

    public void Initialize(Game game)
    {
        this.bootstrapper.game = game;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bootstrapper.game.EndGame();
        }
    }
}
