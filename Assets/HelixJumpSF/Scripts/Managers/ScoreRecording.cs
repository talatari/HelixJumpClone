using UnityEngine;

public class ScoreRecording : BallEvents
{
    [SerializeField] private int _score;
    [SerializeField] private LevelProgress _levelProgress;

    public int _Score => _score;

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        if (_type == SegmentType.Empty)
        {
            //_score += _levelProgress.CurrentLevel;
            _score++;
        }
    }
}
