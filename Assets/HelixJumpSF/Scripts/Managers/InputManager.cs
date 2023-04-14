using UnityEngine;

public class InputManager : BallEvents
{
    [SerializeField] private MouseRotator _mouseRotator;

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        if (_type == SegmentType.Trap || _type == SegmentType.Finish)
        {
            _mouseRotator.enabled = false;
        }
    }


}