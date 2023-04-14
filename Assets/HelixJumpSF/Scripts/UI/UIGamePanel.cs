using UnityEngine;

public class UIGamePanel : BallEvents
{
    [SerializeField] private GameObject _passedPanel;
    [SerializeField] private GameObject _defeatPanel;
    [SerializeField] private GameObject _recordPanel;

    private void Start()
    {
        _passedPanel.SetActive(false);

        _defeatPanel.SetActive(false);

        _recordPanel.SetActive(true);
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
            _recordPanel.SetActive(true);
        }

        if (_type == SegmentType.Empty)
        {
            _recordPanel.SetActive(false);
        }
    }


}