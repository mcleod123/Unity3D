using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    [SerializeField] private Transform _pointA;
    [SerializeField] private Transform _pointB;

    [SerializeField] private Transform _target;

    [SerializeField] private float _time;
    [SerializeField] private float _delay;

    private float _timeCounter;

    // Start is called before the first frame update
    void Start()
    {
        _target.SetPositionXZ(3, +10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Start Target Motion")]
    private void TestStartTargetMotion()
    {
        StartCoroutine(TargetMotion());
    }

    [ContextMenu("Delayed Action")]
    private void TestDelayedAction()
    {
        StartCoroutine(DelayedAction(_delay, TestStartTargetMotion));
    }

    private IEnumerator DelayedAction(float delay, System.Action action)
    {
        Debug.Log("Coroutine started");
        yield return new WaitForSeconds(delay);

        Debug.Log("Coroutine completed");
        action?.Invoke();

    }

    private IEnumerator TargetMotion()
    {
        _timeCounter = 0f;
        while (_timeCounter < _time)
        {
            var normalizedTime = _timeCounter / _time;
            _target.position = Vector3.Lerp(_pointA.position, _pointB.position, normalizedTime);
            _timeCounter += Time.deltaTime;
            yield return null;
        }

        _target.position = _pointB.position;
        Debug.Log("Coroutine completed");
    }
}
