using UnityEngine;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] private BallController _ballController;

    private int _currentLevel = 1;
    public int CurrentLevel => _currentLevel;

    private void Start()
    {
        _ballController._collisionSegment.AddListener(OnBallCollisonSegment);
    }

    private void OnBallCollisonSegment(SegmentType _type)
    {
        if (_type == SegmentType.Finish)
        {
            _currentLevel++;
        }
    }

    private void OnDestroy()
    {
        _ballController._collisionSegment.RemoveListener(OnBallCollisonSegment);
    }
}
