using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleExample : MonoBehaviour
{
    [SerializeField] private float _speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Motion(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Motion(Vector3.left);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Motion(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Motion(Vector3.back);
        }


    }

    private void Motion(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
