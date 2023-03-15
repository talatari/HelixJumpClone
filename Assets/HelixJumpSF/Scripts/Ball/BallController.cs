using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BallMovement))]
public class BallController : OnColliderTrigger
{
    [HideInInspector] public UnityEvent<SegmentType> _collisionSegment;

    private BallMovement _ballMovement;

    private void Start()
    {
        _ballMovement = GetComponent<BallMovement>();
    }
    
    protected override void OnOneTriggerEnter(Collider _other)
    {
        if (_other.TryGetComponent(out Segment _segment))
        {
            if (_segment.Type == SegmentType.Empty)
            {
                _ballMovement.Fall(_other.transform.position.y);
            }

            if (_segment.Type == SegmentType.Default)
            {
                _ballMovement.Jump();
            }

            if (_segment.Type == SegmentType.Trap ||
                _segment.Type == SegmentType.Finish)
            {
                _ballMovement.Stop();
            }

            _collisionSegment.Invoke(_segment.Type);
        }
    }
}
