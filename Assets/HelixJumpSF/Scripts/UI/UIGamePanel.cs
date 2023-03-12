using UnityEngine;
using UnityEngine.UI;

public class UIGamePanel : BallEvents
{
    [SerializeField] private GameObject _passedPanel;
    [SerializeField] private GameObject _defeatPanel;
    [SerializeField] private GameObject _recordPanel;
    //[SerializeField] private RecordRecording _recordRecording;
    [SerializeField] private Text _recordScoreGameText;

    private int _recordScoreGame;
    private string _recordText = "Record: ";

    private void Start()
    {
        _passedPanel.SetActive(false);
        _defeatPanel.SetActive(false);
        _recordPanel.SetActive(true);
        _recordScoreGame = PlayerPrefs.GetInt(
            "RecordScoreGame:_recordScoreGame", 0);

        _recordScoreGameText.text = _recordText + _recordScoreGame;
    }

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        if (_type == SegmentType.Trap)
        {
            _defeatPanel.SetActive(true);
        }

        if (_type == SegmentType.Finish)
        {
            _passedPanel.SetActive(true);
        }

        if (_type == SegmentType.Empty)
        {
            _passedPanel.SetActive(false);
        }
    }
}
