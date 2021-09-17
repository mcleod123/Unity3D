using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject CatWarrior;
    private Vector3 offset;

    void Start()
    {
        CatWarrior = GameObject.FindGameObjectWithTag("CatWarrior");
        offset = transform.position - CatWarrior.transform.position;
    }

    void LateUpdate()
    {
        transform.position = CatWarrior.transform.position + offset;
    }
}
