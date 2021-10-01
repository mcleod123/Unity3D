using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPrefab : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    [SerializeField] private Transform _shootingPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shooting();
        }
    }

    private void Shooting()
    {
        Instantiate(_bulletPrefab, _shootingPoint.position, Quaternion.identity);
    }
}
