using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [Header("Animation")]
    [Header("Fall")]

    [SerializeField] private Animator _animator;
    [SerializeField] private float _fallHeight;
    [SerializeField] private float _fallSpeed;


    private float _floorY;

    private void Start()
    {
        enabled = false;
    }

    private void Update()
    {
        if (transform.position.y > _floorY)
        {
            transform.position += Vector3.down * _fallSpeed * Time.deltaTime;
        }
        else
        {
            transform.position = new Vector3(transform.position.x,
                                             _floorY,
                                             transform.position.z);
            enabled = false;
        }
    }

    public void Jump()
    {

    }

    public void Fall(float _startFloor)
    {
        _animator.speed = 0;
        enabled = true;
        _floorY = transform.position.y - _fallHeight;
    }

    public void Stop()
    {

    }
}
