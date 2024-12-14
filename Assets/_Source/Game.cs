using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Bootstrapper bootstrapper;
    public TMP_Text TMP_Text;

    void Start()
    {
        Debug.Log("Game started!");
    }

    void Update()
    {
        TMP_Text.text = bootstrapper.score.currentScore.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("Game ended!");
        bootstrapper.score.ResetScore();
    }
}
