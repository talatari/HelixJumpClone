using UnityEngine;

[RequireComponent(typeof(BallMovement))]
public class BallController : OnColliderTrigger
{
    private BallMovement _ballMovement;

    private void Start()
    {
        _ballMovement = GetComponent<BallMovement>();
    }

    protected override void OnOneTriggerEnter(Collider other)
    {
        Segment _segment = other.GetComponent<Segment>();

        if (_segment != null)
        {
            if (_segment.type == SegmentType.Empty)
            {
                Debug.Log($"other.transform.position.y = " +
                          $"{other.transform.position.y}");

                _ballMovement.Fall(other.transform.position.y);
            }

            if (_segment.type == SegmentType.Default)
            {
                _ballMovement.Jump();
            }

            if (_segment.type == SegmentType.Trap ||
                _segment.type == SegmentType.Finish)
            {
                _ballMovement.Stop();
            }
        }
    }
}
