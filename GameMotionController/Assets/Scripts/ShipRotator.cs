using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipRotator : MonoBehaviour
{
    [SerializeField] float _rotateSpeed = 30f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            RotateShip(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            RotateShip(Vector3.left);
        } else
        {
            RotateShip(Vector3.up);
        }
    }

    private void RotateShip(Vector3 direction)
    {

        if (direction.Equals(Vector3.right))
        {
            transform.Rotate(0, 0, Mathf.Lerp(0, 8, Time.deltaTime * _rotateSpeed));
        } else if (direction.Equals(Vector3.left))
        {
            transform.Rotate(0, 0, Mathf.Lerp(0, -8, Time.deltaTime * _rotateSpeed));
        } 
        else 
        {
            transform.Rotate(0, 0, Mathf.Lerp(0, 0, Time.deltaTime * _rotateSpeed));
        }


    }

}
