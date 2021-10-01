using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfAnimationController : MonoBehaviour
{
    private const string SpeedParam = "Speed";
    private const string JumpParam = "Jump";

    private const float MinimalSpeed = 0f;
    private const float MaxSpeed = 3f;

    [SerializeField] private Animator _animator;

    private float _speedCounter;

    private bool _isCharacterGo = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _isCharacterGo = true;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            _isCharacterGo = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        ChangeSpeed();
    }

    private void ChangeSpeed()
    {
        if (_isCharacterGo)
        {
            _speedCounter += Time.deltaTime;
        }
        else
        {
            _speedCounter -= Time.deltaTime;
        }

        _speedCounter = Mathf.Clamp(_speedCounter, MinimalSpeed, MaxSpeed);

        _animator.SetFloat(SpeedParam, _speedCounter);
    }

    private void Jump()
    {
        _animator.SetTrigger(JumpParam);
    }
}
