using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourExample : MonoBehaviour
{
    private void Awake()
    {
    }

    private void OnEnable()
    {   
    }

    private void OnLevelWasLoaded(int level)
    {   
    }

    private void Start()
    {
        //gameObject.SetActive(true);
        //gameObject.GetComponent<StringExample>();
        gameObject.name = "MonoTest";
        //transform.parent
        //transform.hasChanged;
        transform.eulerAngles= new Vector3(90, 0, 0);
        //transform.right;
        //transform.up;
        //transform.forward;
    }

    private void FixedUpdate()
    {   
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void LateUpdate()
    {
    }

    private void OnApplicationQuit()
    {
    }

    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }
}
