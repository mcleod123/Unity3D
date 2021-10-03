using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipBodyRotator : MonoBehaviour
{

    [SerializeField] private float _speed = 3f;

    private bool playerShipIsAlreadyRotateLeft = false;
    private bool playerShipIsAlreadyRotateRight = false;
    private float shipRotateAngleIfMove = 30;

    public Quaternion originalRotation;

    private float originalX;
    private float originalY;
    private float originalZ;

    void Start()
    {
        originalRotation = transform.rotation;

        originalX = originalRotation.x;
        originalY = originalRotation.y;
        originalZ = originalRotation.z;
    }



    void Update()
    {

        // Please no rotation MORE!!!!!!!!!!

        /*

        if (Input.GetKey(KeyCode.D))
        {
            ShipBodyRotate(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ShipBodyRotate(Vector3.left);
        }


        if (Input.GetKey(KeyCode.W))
        {
            ShipBodyRotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ShipBodyRotate(Vector3.back);
        }

        */

    }


    private void ShipBodyRotate(Vector3 direction)
    {
        if ( playerShipIsAlreadyRotateRight && playerShipIsAlreadyRotateLeft)
        {
            playerShipIsAlreadyRotateRight = false;
            playerShipIsAlreadyRotateLeft = false;
        }




        if (direction.Equals(Vector3.right))
        {

            if (!playerShipIsAlreadyRotateRight)
            {
                if (!playerShipIsAlreadyRotateRight && !playerShipIsAlreadyRotateLeft)
                {
                    transform.Rotate(0, 0, shipRotateAngleIfMove);
                    playerShipIsAlreadyRotateRight = true;

                } 
                else if (playerShipIsAlreadyRotateLeft)
                {
                    transform.Rotate(0, 0, shipRotateAngleIfMove*2);
                    playerShipIsAlreadyRotateRight = true;
                }
            }



        }



        if (direction.Equals(Vector3.left))
        {
            if (!playerShipIsAlreadyRotateLeft)
            {
                if (!playerShipIsAlreadyRotateLeft && !playerShipIsAlreadyRotateRight)
                {
                    transform.Rotate(0, 0, -(shipRotateAngleIfMove) );
                    playerShipIsAlreadyRotateLeft = true;
                } 
                else if (playerShipIsAlreadyRotateRight)
                {
                    transform.Rotate(0, 0, -(shipRotateAngleIfMove * 2) );
                    playerShipIsAlreadyRotateLeft = true;
                }
            }

        }




        if (direction.Equals(Vector3.back) || direction.Equals(Vector3.forward))
        {


            // transform.rotation = Quaternion.RotateTowards(transform.rotation, originalRotation, 1.0f * Time.deltaTime);

            // transform.Rotate(originalRotation.x, originalRotation.y, originalRotation.z);


            if(playerShipIsAlreadyRotateRight)
            {
                //transform.Rotate(0, 0, -(shipRotateAngleIfMove) );
                transform.Rotate(originalX, originalY, originalZ);
                playerShipIsAlreadyRotateRight = false;
            }

            if(playerShipIsAlreadyRotateLeft)
            {
                //transform.Rotate(0, 0, shipRotateAngleIfMove);
                transform.Rotate(originalX, originalY, originalZ);
                playerShipIsAlreadyRotateLeft = false;
            }



            playerShipIsAlreadyRotateRight = false;
            playerShipIsAlreadyRotateLeft = false;
        }

        // Debug.Log("playerShipIsAlreadyRotateRight " + playerShipIsAlreadyRotateRight);
        // Debug.Log("playerShipIsAlreadyRotateLeft "  + playerShipIsAlreadyRotateLeft);

    }




}
