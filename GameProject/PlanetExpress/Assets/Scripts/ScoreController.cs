using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{

    private int _scorePoint = 0;


    // Start is called before the first frame update
    void Start()
    {
        ResetScorePoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ResetScorePoint()
    {
        _scorePoint = 0;
        GameEvents.CallScorePointChangeEvent(_scorePoint);
    }

    private void AddScore(int scorePoint)
    {
        _scorePoint += scorePoint;

        GameEvents.CallScorePointChangeEvent(_scorePoint);

    }

    [ContextMenu("Test Add Score Points")]
    private void TestAddScorePoint()
    {
        var scoreToAdd = UnityEngine.Random.Range(10, 100);
        Debug.Log($"Score To add: {scoreToAdd}");
        AddScore(scoreToAdd);
    }

}
