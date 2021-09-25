using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BackgroundManage : MonoBehaviour
{
    [SerializeField] List<GameObject> _particlesBackground;



    // Start is called before the first frame update
    void Start()
    {
        // ParticleOff();
    }


    public void ParticleOff()
    {
        for(int i=0; i < _particlesBackground.Count; i++)
        {
            _particlesBackground[i].SetActive(false);
        }
    }

    private void ParticleOn()
    {
        for (int i = 0; i < _particlesBackground.Count; i++)
        {
            _particlesBackground[i].SetActive(true);
        }
    }

}
