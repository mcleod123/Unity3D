using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfAnimationControllerBlendTree : MonoBehaviour
{
    private const string SpeedParam = "Speed";
    private const string LeftRightParam = "LeftRight";
    private const string JumpParam = "Jump";

    [SerializeField] private Animator _animator;

    private float _speedCounter;
    private float _leftRightCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _speedCounter = Input.GetAxis("Vertical");
        _leftRightCounter = Input.GetAxis("Horizontal");
        SetLocomotion();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void SetLocomotion()
    {
        _animator.SetFloat(SpeedParam, _speedCounter);
        _animator.SetFloat(LeftRightParam, _leftRightCounter);
    }

    private void Jump()
    {
        _animator.SetTrigger(JumpParam);
    }
}
