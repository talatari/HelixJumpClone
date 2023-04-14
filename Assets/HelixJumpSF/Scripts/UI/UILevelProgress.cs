using System;
using UnityEngine;
using UnityEngine.UI;

public class UILevelProgress : BallEvents
{
    [SerializeField] private LevelProgress _levelProgress;
    [SerializeField] private LevelGenerator _levelGenerator;
    [SerializeField] private Text _currentLevelText;
    [SerializeField] private Text _nextLevelText;
    [SerializeField] private Image _progressBar;
    [SerializeField] private Text _textPercentsProgressBar;

    private float _fillStep;
    private string _fillPercent;

    private void Start()
    {
        _currentLevelText.text = _levelProgress.CurrentLevel.ToString();
        _nextLevelText.text = (_levelProgress.CurrentLevel + 1).ToString();

        _progressBar.fillAmount = 0.0f;
    }

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        if (_type == SegmentType.Empty || _type == SegmentType.Finish)
        {
            _fillStep = 1 / ((float)_levelGenerator._FloorAmount - 1);

            _progressBar.fillAmount += _fillStep;

            DrawFillProgressBar();
        }
    }

    private void DrawFillProgressBar()
    {
        _fillPercent = (_progressBar.fillAmount * 100).ToString();

        _textPercentsProgressBar.text = _fillPercent.Split('.')[0] + "%";
    }


}