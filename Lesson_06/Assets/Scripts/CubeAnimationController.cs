using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimationController : MonoBehaviour
{
    private const string TransitionToSimpleParam = "TransitionToSimple";
    private const string SomeFlagParam = "SomeFlag";
    private const string SpeedParam = "Speed";
    private const string TakedWeaponParam = "TakedWeapon";

    private const float MinimalSpeed = 0f;
    private const float MaxSpeed = 3f;

    [SerializeField] private Animator _animator;

    private float _speedCounter;

    private bool _isSpeedGoUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _isSpeedGoUp = true;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            _isSpeedGoUp = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            TestTakeWeapon();
        }

        ChangeSpeed();
    }

    private void ChangeSpeed()
    {
        if (_isSpeedGoUp)
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

    
    private void TestTakeWeapon()
    {
        _animator.SetTrigger(TakedWeaponParam);
    }
}
