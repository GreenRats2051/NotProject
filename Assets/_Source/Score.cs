using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    public int currentScore;
    public Action<int> OnScoreChanged;

    public void InitializeScore(int startScore)
    {
        currentScore = startScore;
        OnScoreChanged?.Invoke(currentScore);
    }

    public void DecrementScore()
    {
        currentScore++;
        OnScoreChanged?.Invoke(currentScore);
    }

    public void ResetScore()
    {
        currentScore = 0;
        OnScoreChanged?.Invoke(currentScore);
    }
}
