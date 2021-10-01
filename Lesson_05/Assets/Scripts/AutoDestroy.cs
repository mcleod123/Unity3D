using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] private float _delay = 2f;
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(DestroyObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(_delay);
        Destroy(gameObject);
    }
}
