using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    private Bootstrapper bootstrapper;

    public void Initialize(Score score)
    {
        this.bootstrapper.score = score;
    }

    void OnMouseDown()
    {
        if (bootstrapper.score != null)
        {
            bootstrapper.score.CurrentScore--;
            Debug.Log("Score decremented. Current score: " + bootstrapper.score.CurrentScore);
        }
    }
}
