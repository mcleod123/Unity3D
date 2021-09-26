using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePointUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scorePointText;

    private void Awake()
    {
        GameEvents.ScorePointChangeEvent += OnScorePointHandler;
    }


    private void OnDestroy()
    {
        GameEvents.ScorePointChangeEvent -= OnScorePointHandler;
    }

    private void OnScorePointHandler(int scorePoint)
    {
        _scorePointText.text = scorePoint.ToString();
    }

}
