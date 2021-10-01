using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationProperty : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TestSimpleEvent()
    {
        Debug.Log("TestSimpleEvent: OK");
    }

    private void TestStringEvent(string value)
    {
        Debug.Log($"TestSimpleEvent: OK, {value}");
    }

    private void TestGameObjectEvent(GameObject go)
    {
        Debug.Log($"TestSimpleEvent: OK, {go.name}");
    }
}
