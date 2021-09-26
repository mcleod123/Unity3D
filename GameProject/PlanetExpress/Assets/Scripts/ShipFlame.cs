using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFlame : MonoBehaviour
{
    [SerializeField] private Vector3 _flameRotatePoint;
    [SerializeField] private Vector3 _flameRotateAngle;
    [SerializeField] private float _flameRotateSpeed = 3.5f;

    private GameObject _shipFlame;



    // Start is called before the first frame update
    void Start()
    {

        _shipFlame = GameObject.Find("Flame");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //FlameMotion(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // FlameMotion(Vector3.left);
        }

    }




    private void FlameMotion(Vector3 direction)
    {


        if (direction.Equals(Vector3.right))
        {

            _flameRotatePoint = Vector3.zero;
            _flameRotateAngle = Vector3.up;

            _shipFlame.transform.RotateAround(_flameRotatePoint, _flameRotateAngle, _flameRotateSpeed);

        }


        if (direction.Equals(Vector3.left))
        {
            _flameRotatePoint = Vector3.zero;
            _flameRotateAngle = Vector3.down;

            _shipFlame.transform.RotateAround(_flameRotatePoint, _flameRotateAngle, _flameRotateSpeed);
        }





    }



}