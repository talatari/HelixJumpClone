using UnityEngine;
using UnityEngine.UI;

public class UIRecordScore : BallEvents
{
    [SerializeField] private RecordRecording _recordRecording;
    [SerializeField] private Text _recordScoreGameText;

    private string _recordText;

    private void Start()
    {
        _recordText = _recordScoreGameText.text;
    }

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        _recordScoreGameText.text = _recordText + _recordRecording._RecordScoreGame.ToString();
    }


}