using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreContoller
{

    public static int score = 0;

    public static void AddPoints()
    {
        Debug.Log("Score: " + score.ToString());
        score++;
    }

    public static int GetPoints()
    {
        return score;
    }


}
