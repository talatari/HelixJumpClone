using UnityEngine;
using UnityEngine.UI;

public class UIRecordScore : BallEvents
{
    [SerializeField] private RecordRecording _recordRecording;
    [SerializeField] private Text _recordScoreGameText;

    private string _recordText = "Record: ";

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        if (_type != SegmentType.Trap)
        {
            _recordScoreGameText.text = _recordText +
                _recordRecording._RecordScoreGame.ToString();
        }


    }
}
