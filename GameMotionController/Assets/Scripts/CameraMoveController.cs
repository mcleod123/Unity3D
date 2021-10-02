using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveController : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private float _cameraRotateDeniedX = 30;
    private float _cameraRotateDeniedY = 30;

    private Vector3 _up;
    private Vector3 _right;

    private float signedAngleYforward;
    private float signedAngleYback;

    private float sensitivity = 1;
    private float X;
    private float Y;
    private float limit = 30;

    // Start is called before the first frame update
    void Start()
    {
        _up = transform.up;
        _right = transform.right;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(1))
        {
            X = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
            Y += Input.GetAxis("Mouse Y") * sensitivity;

            Y = Mathf.Clamp(Y, -limit, limit);
            transform.localEulerAngles = new Vector3(-Y, X, 0);
        }



        /*
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateCamera(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateCamera(Vector3.left);
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            RotateCamera(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            RotateCamera(Vector3.back);
        }
        */


    }

    /*
    private void RotateCamera(Vector3 direction)
    {

        signedAngleYforward = Vector3.SignedAngle(_up, transform.up, transform.up);
        signedAngleYback = Vector3.SignedAngle(_up, transform.up, transform.up);
        // signedAngleY = Vector3.SignedAngle(_right, transform.right, transform.up);
       
        





        if (direction.Equals(Vector3.right) )
        {
            transform.Rotate(0, 3, 0);
        }

        if (direction.Equals(Vector3.left) )
        {
            transform.Rotate(0, -3, 0);
        }

        if(Mathf.Abs(signedAngleYforward) < _cameraRotateDeniedX && Mathf.Abs(signedAngleYback) < _cameraRotateDeniedX)
        {
            if (direction.Equals(Vector3.back))
            {
                transform.Rotate(3, 0, 0);
            } 

            if (direction.Equals(Vector3.forward))
            {
                transform.Rotate(-3, 0, 0);
            }

        } 
        else
        {
            if (direction.Equals(Vector3.back))
            {
                transform.rotation = Quaternion.identity;
                //transform.Rotate(-1, 0, 0);
            }

            if (direction.Equals(Vector3.forward))
            {
                transform.rotation = Quaternion.identity;
                //transform.Rotate(1, 0, 0);
            }
        }

    }

    */




}
