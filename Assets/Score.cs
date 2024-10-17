using System;
public class Score
{
    private int currentScore;
    public Action OnScoreChanged;

    public int CurrentScore
    {
        get => currentScore;
        set
        {
            currentScore = value;
            OnScoreChanged?.Invoke();
        }
    }
}
