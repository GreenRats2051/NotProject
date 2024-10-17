using UnityEngine;

public class InputListener : MonoBehaviour
{
    private Bootstrapper bootstrapper;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bootstrapper.game.EndGame(bootstrapper);
        }
    }
}
