
public static class GameEvents
{
    public static event System.Action GameStartEvent;

    public static event System.Action<int> ScorePointChangeEvent;

    public static void CallScorePointChangeEvent(int scorePoint)
    {
        ScorePointChangeEvent?.Invoke(scorePoint);
    }

}
