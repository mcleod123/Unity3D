using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShipByHit : MonoBehaviour
{

    static int numberOfHits;

    // Start is called before the first frame update
    void Start()
    {
        numberOfHits = 4;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        // destroing bullet by ship
        if (collision.gameObject.name == "RocketWeaponBullet(Clone)")
        {
            Destroy(collision.gameObject);
            AudioManager.PlaySFX(SFXType.Hit);

            numberOfHits--;

        }
        else if (collision.gameObject.name == "MainWeaponBullet(Clone)")
        {
            Destroy(collision.gameObject);
            AudioManager.PlaySFX(SFXType.EnemyShipExplosion);

        } else
        {
            AudioManager.PlaySFX(SFXType.Collision);
        }



    }


}
