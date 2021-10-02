using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




        if (Input.GetKey(KeyCode.D))
        {
            _speed = 9f;
            Motion(Vector3.right, _speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _speed = 9f;
            Motion(Vector3.left, _speed);
        }



        if (Input.GetKey(KeyCode.W))
        {
            _speed = 9f;
            Motion(Vector3.forward, _speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _speed = 9f;
            Motion(Vector3.back, _speed);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            _speed = 90f;
            Motion(Vector3.forward, _speed);
        }

    }

    private void Motion(Vector3 direction, float localSpeed)
    {


        if (direction.Equals(Vector3.right))
        {
           // transform.rotation = Quaternion.identity;
            transform.Rotate(0, 2, 0);
        } 

        if (direction.Equals(Vector3.left))
        {
            //transform.rotation = Quaternion.identity;
            transform.Rotate(0, -2, 0);
        }
        


        if (direction.Equals(Vector3.back))
        {
            //transform.rotation = Quaternion.identity;
            transform.Translate(Vector3.back * localSpeed * Time.deltaTime);
        }

        if (direction.Equals(Vector3.forward))
        {
            // transform.rotation = Quaternion.identity;
            transform.Translate(Vector3.forward * localSpeed * Time.deltaTime);
        }


        Debug.Log(_speed.ToString());


    }






    /*
    private void RotatePlayer(Vector3 direction)
    {


        if (direction.Equals(Vector3.right))
        {
            transform.Rotate(0, 3, 0);
        }

        if (direction.Equals(Vector3.left))
        {
            transform.Rotate(0, -3, 0);
        }

       

    }

    */


}
