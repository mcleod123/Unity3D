using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMoveController : MonoBehaviour
{

    [SerializeField] private float _speed = 3f;

    [SerializeField] public GameObject _bullet;
    [SerializeField] public GameObject _rocket;
    [SerializeField] public GameObject _startMuzzle;

    private Vector3 _muzzlePosition;

    [SerializeField] private AudioClip _shootSound;

    private float _restrictedCoordX = 11f;
    private float _restrictedCoordTopZ = 10f;
    private float _restrictedCoordBottomZ = 2f;

    private float _frequencyMainWeaponFire = 0.2f;
    private float _frequencyRocketWeaponFire = 1f;

    private bool _canRocketFire = true;
    private bool _canMainWeaponFire = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _speed = 9f;
            Motion(Vector3.right, _speed);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _speed = 9f;
            Motion(Vector3.left, _speed);
        }



        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _speed = 9f;
            Motion(Vector3.forward, _speed);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _speed = 9f;
            Motion(Vector3.back, _speed);
        }



        // Accelerate!
        if (Input.GetKey(KeyCode.E))
        {
            _speed = 14f;
            Motion(Vector3.forward, _speed);
        }


        // Fire!
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            if(_canMainWeaponFire)
            {
                StartCoroutine(MainWeaponFireCoroutine());
            }


        }


        // Rockets!
        if (Input.GetKey(KeyCode.Q) || Input.GetMouseButtonDown(1))
        {
            if(_canRocketFire)
            {
                StartCoroutine(RocketWeaponFireCoroutine());
            }
 

        }


    }


    private void Motion(Vector3 direction, float localSpeed)
    {




            if (direction.Equals(Vector3.right))
            {
                if (transform.position.x >= _restrictedCoordX)
                {
                    transform.Translate(Vector3.left * localSpeed * Time.deltaTime);
                }

                transform.Translate(Vector3.right * localSpeed * Time.deltaTime);
            }

            if (direction.Equals(Vector3.left))
            {
                

                if (transform.position.x <= -_restrictedCoordX)
                {
                    transform.Translate(Vector3.right * localSpeed * Time.deltaTime);
                }

                transform.Translate(Vector3.left * localSpeed * Time.deltaTime);
            }





            if (direction.Equals(Vector3.back))
            {
                if (transform.position.z <= -_restrictedCoordBottomZ)
                {
                    transform.Translate(Vector3.forward * localSpeed * Time.deltaTime);
                }

                transform.Translate(Vector3.back * localSpeed * Time.deltaTime);
            }

            if (direction.Equals(Vector3.forward))
            {

                if (transform.position.z >= _restrictedCoordTopZ)
                {
                    transform.Translate(Vector3.back * localSpeed * Time.deltaTime);
                }

                transform.Translate(Vector3.forward * localSpeed * Time.deltaTime);

            }






    }


    IEnumerator MainWeaponFireCoroutine()
    {
        _canMainWeaponFire = false;
        MainWeaponFire();
        AudioManager.PlaySFX(SFXType.LaserShoot);
        yield return new WaitForSeconds(_frequencyMainWeaponFire);
        _canMainWeaponFire = true;
    }

    void MainWeaponFire()
    {
        _muzzlePosition = GameObject.Find("Muzzle").transform.position;
        Quaternion _muzzleRotation = GameObject.Find("Muzzle").transform.rotation;

        GameObject mainWeaponBullet = Instantiate(_bullet, _muzzlePosition, _muzzleRotation) as GameObject;
    
        Rigidbody bulletRigitBody = mainWeaponBullet.GetComponent<Rigidbody>();

        bulletRigitBody.AddForce(mainWeaponBullet.transform.forward * 30, ForceMode.Impulse);

        Destroy(mainWeaponBullet, 10);

    }


    IEnumerator RocketWeaponFireCoroutine()
    {
        _canRocketFire = false;
        RocketWeaponFire();
        AudioManager.PlaySFX(SFXType.RocketShoot);
        yield return new WaitForSeconds(_frequencyRocketWeaponFire);
        _canRocketFire = true;
    }

    void RocketWeaponFire()
    {
        _muzzlePosition = GameObject.Find("Muzzle").transform.position;
        Quaternion _muzzleRotation = GameObject.Find("Muzzle").transform.rotation;

        GameObject rocketWeaponBullet = Instantiate(_rocket, _muzzlePosition, _muzzleRotation) as GameObject;

        Rigidbody rocketRigitBody = rocketWeaponBullet.GetComponent<Rigidbody>();

        rocketRigitBody.AddForce(rocketWeaponBullet.transform.forward * 20, ForceMode.Impulse);

        Destroy(rocketWeaponBullet, 10);

    }

    private void FixedUpdate()
    {
        // MainWeaponFire();
    }


}
