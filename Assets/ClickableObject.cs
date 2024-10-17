using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    [SerializeField]
    private Bootstrapper bootstrapper;

    void OnMouseDown()
    {
        if (bootstrapper.score != null)
        {
            bootstrapper.score.CurrentScore++;
            Debug.Log("Score decremented. Current score: " + bootstrapper.score.CurrentScore);
        }
    }
}
