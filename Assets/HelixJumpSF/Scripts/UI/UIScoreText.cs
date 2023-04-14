using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoreRecording _scoreRecording;
    [SerializeField] private Text _scoreText;

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        if (_type != SegmentType.Trap)
        {
            _scoreText.text = _scoreRecording._Score.ToString();
        }
    }


}