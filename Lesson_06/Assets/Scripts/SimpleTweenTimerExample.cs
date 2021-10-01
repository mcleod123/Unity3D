using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleTweenTimerExample : MonoBehaviour
{
    [SerializeField] private float _time;

    [SerializeField] private Text _timerText;
    [SerializeField] private Text _normilizedTimerText;

    private ITimer _timer;
    // Start is called before the first frame update
    void Start()
    {
        CreateTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateTimer()
    {
        _timer = TimerCreator.CreateTimer(_time);
        _timer.OnTimerCompletedEvent += OnTimerEnd;
        _timer.OnTimerUpdateEvent += OnTimerUpdate;
    }

    private void OnTimerEnd()
    {
        Debug.Log("Timer Completed");
    }

    private void OnTimerUpdate(float time)
    {
        _timerText.text = _timer.Current.ToString();
        _normilizedTimerText.text = _timer.Normilized.ToString();
    }

    [ContextMenu("Start Timer")]
    private void StartTimer()
    {
        _timer.Start();
    }
}
