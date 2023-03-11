using UnityEngine;

public abstract class BallEvents : MonoBehaviour
{
    [SerializeField] protected BallController _ballController;

    protected virtual void Awake()
    {
        _ballController._collisionSegment.AddListener(OnBallCollisionSegment);
    }

    protected virtual void OnDestroy()
    {
        _ballController._collisionSegment.RemoveListener(OnBallCollisionSegment);
    }

    protected virtual void OnBallCollisionSegment(SegmentType _type) { }
}
