using UnityEngine;

public class UIGamePanel : BallEvents
{
    [SerializeField] private GameObject _passedPanel;
    [SerializeField] private GameObject _defeatPanel;

    private void Start()
    {
        _passedPanel.SetActive(false);
        _defeatPanel.SetActive(false);
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
    }
}
