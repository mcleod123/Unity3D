using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByHit : MonoBehaviour
{


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



        if (collision.gameObject.name == "EnemyShip1(Clone)")
        {
            AudioManager.PlaySFX(SFXType.Hit);
            Destroy(collision.gameObject);
            AudioManager.PlaySFX(SFXType.EnemyShipExplosion);
            ScoreContoller.AddPoints();

        }
        else if (collision.gameObject.name == "EnemyShip2(Clone)")
        {
            AudioManager.PlaySFX(SFXType.Hit);
            Destroy(collision.gameObject);
            AudioManager.PlaySFX(SFXType.EnemyShipExplosion);
            ScoreContoller.AddPoints();
        }



        /*

        if (collision.gameObject.name == "RocketWeaponBullet(Clone)")
        {
            Destroy(collision.gameObject);
            AudioManager.PlaySFX(SFXType.EnemyShipExplosion);
        }
        else if (collision.gameObject.name == "MainWeaponBullet(Clone)")
        {
            if (_numberOfMainWeaponHits == 0)
            {
                Destroy(collision.gameObject);
                AudioManager.PlaySFX(SFXType.EnemyShipExplosion);
            }
            else
            {
                _numberOfMainWeaponHits--;
                AudioManager.PlaySFX(SFXType.Hit);
            }


        }
        else
        {
            AudioManager.PlaySFX(SFXType.Collision);
        }

        */








    }









}
