using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByHit : MonoBehaviour
{

    [SerializeField] GameObject _bullet;
    [SerializeField] GameObject _rocket;
    [SerializeField] GameObject _target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {


        

        // определение столкновения с двумя разноименными объектами
        if (collision.gameObject.name == "RocketWeaponBullet")
        {
            Destroy(_target);
        }
        else if (collision.gameObject.name == "MainWeaponBullet")
        {

        }

        

    }









}
