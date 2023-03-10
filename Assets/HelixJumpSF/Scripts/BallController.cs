using UnityEngine;

[RequireComponent(typeof(BallMovement))]
public class BallController : OnColliderTrigger
{
    private BallMovement _ballMovement;

    private void Start()
    {
        _ballMovement = GetComponent<BallMovement>();
    }
    
    protected override void OnOneTriggerEnter(Collider _other)
    {
        Segment _segment = _other.GetComponent<Segment>();

        if (_segment != null)
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
        }
    }
}
