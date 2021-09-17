using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMoves : MonoBehaviour
{

    [SerializeField] private float _speed = 2.5f;
    private float positionX, positionZ;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D))
        {
            Motion(Vector3.right);
        } else if (Input.GetKey(KeyCode.A))
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

        // check move restriction
        if(!MoveRestrictChecker(direction))
        {
            return;
        }


        if (direction.Equals(Vector3.right))
        {
            transform.rotation = Quaternion.identity;
            transform.Rotate(0, 90, 0);
        }

        if (direction.Equals(Vector3.left))
        {
            transform.rotation = Quaternion.identity;
            transform.Rotate(0, 270, 0);
        }

        if (direction.Equals(Vector3.back))
        {
            transform.rotation = Quaternion.identity;
            transform.Rotate(0, 180, 0);
        }

        if (direction.Equals(Vector3.forward))
        {
            transform.rotation = Quaternion.identity;
            transform.Rotate(0, 0, 0);
        }

        transform.Translate(Vector3.forward * _speed * Time.deltaTime);



    }


    private bool MoveRestrictChecker(Vector3 direction)
    {

        // get cat hero coordinates
        positionX = transform.position.x;
        positionZ = transform.position.z;

        Debug.Log(positionZ.ToString());


        // checking if movement is allowed

        // X Axis restrict
        if ( positionX >= 9.5 && direction.Equals(Vector3.right))
        {
            return false;
        }

        if (positionX <= -9.5 && direction.Equals(Vector3.left))
        {
            return false;
        }


        // Z Axis restrict
        if (positionZ >= 9.5 && direction.Equals(Vector3.forward))
        {
            return false;
        }

        if (positionZ <= -9.5 && direction.Equals(Vector3.back))
        {
            return false;
        }



        // else move is allow
        return true;

    }








}
