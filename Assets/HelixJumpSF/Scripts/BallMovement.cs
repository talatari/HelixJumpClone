using UnityEngine;

[RequireComponent(typeof(BallMovement))]
public class BallMovement : MonoBehaviour
{
    [Header("Fall")]
    [SerializeField] private float _fallHeight;
    [SerializeField] private float _fallSpeedDefault;
    [SerializeField] private float _fallSpeedMax;
    [SerializeField] private float _fallSpeedAxeleration;

    private Animator _animator;
    private float _floorY;
    private float _fallSpeed;

    private void Start()
    {
        enabled = false;
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Debug.Log($"transform.position.y = {transform.position.y}, " +
                  $"_floorY = {_floorY}");

        if (transform.position.y > _floorY)
        {
            transform.Translate(0, -1 * _fallSpeedMax * Time.deltaTime, 0);

            if (_fallSpeed < _fallSpeedMax)
            {
                _fallSpeed += _fallSpeedAxeleration * Time.deltaTime;
            }
        }
        else
        {
            transform.position = new Vector3(
                transform.position.x, _floorY, transform.position.z);

            enabled = false;
        }
    }

    public void Jump()
    {
        _animator.speed = 1;
        _fallSpeed = _fallSpeedDefault;
    }

    public void Fall(float _startFloor)
    {
        _animator.speed = 0;
        enabled = true;
        _floorY = _startFloor - _fallHeight;
    }

    public void Stop()
    {
        _animator.speed = 0;
    }
}
