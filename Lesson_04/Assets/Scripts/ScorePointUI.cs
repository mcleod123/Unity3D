using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScorePointUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scorePointText;
    // Start is called before the first frame update
    void Awake()
    {
        GameEvents.ScorePointChangeEvent += OnScorePointChangeHander;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        GameEvents.ScorePointChangeEvent -= OnScorePointChangeHander;
    }

    private void OnScorePointChangeHander(int scorePoint)
    {
        _scorePointText.text = scorePoint.ToString();
    }
}
