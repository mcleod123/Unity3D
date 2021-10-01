using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class DoTweenExample : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _pointA;
    [SerializeField] private Transform _pointB;

    [SerializeField] private Transform[] _points;

    [SerializeField] private float _time;

    [SerializeField] private MeshRenderer _meshRenderer;

    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update

    private Vector3[] _pathArray;
    void Start()
    {
        PreparePath();
        _meshRenderer = _target.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Start Animation")]
    private void StartAnimation()
    {
        _target.position = _pointA.position;
        _target.DOMove(_pointB.position, _time)
            .SetEase(Ease.OutBounce)
            .OnComplete(OnTweenCompleted)
            .OnUpdate(OnAnimationUpdate);

        //_meshRenderer.material.
        //_target.DOPath(_pathArray, _time, PathType.Linear);
    }

    private void OnTweenCompleted()
    {
        Debug.Log("OnTweenCompleted");
    }

    private void OnAnimationUpdate()
    {
        Debug.Log("OnAnimationUpdate");
    }

    private void PreparePath()
    {
        _pathArray = new Vector3[_points.Length];

        for (int i = 0; i < _points.Length; i++)
        {
            _pathArray[i] = _points[i].position;
        }
    }

}
