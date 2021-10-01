using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    [SerializeField] private float _speed = 3.5f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Motion(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
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

        if (direction.Equals(Vector3.right))
        {
           // transform.rotation = Quaternion.identity;
            transform.Rotate(0, 3, 0);
        } 

        if (direction.Equals(Vector3.left))
        {
            //transform.rotation = Quaternion.identity;
            transform.Rotate(0, -3, 0);
        }
        


        if (direction.Equals(Vector3.back))
        {
            //transform.rotation = Quaternion.identity;
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }

        if (direction.Equals(Vector3.forward))
        {
            //transform.rotation = Quaternion.identity;
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }





    }






}
