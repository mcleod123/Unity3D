using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject CatWarrior;
    private Vector3 offset;

    void Start()
    {
        // it is a wrong way, i fix this
        // CatWarrior = GameObject.FindGameObjectWithTag("CatWarrior");
        
        // correct way to find objects
        CatWarrior = GameObject.Find("CatWarrior");
        
        offset = transform.position - CatWarrior.transform.position;
    }

    void LateUpdate()
    {
        transform.position = CatWarrior.transform.position + offset;
    }
}
