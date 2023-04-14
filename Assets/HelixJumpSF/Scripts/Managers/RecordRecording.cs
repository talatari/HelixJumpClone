using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordRecording : BallEvents
{
    [SerializeField] private ScoreRecording _scoreRecording;

    private int _recordScoreGame;
    public int _RecordScoreGame => _recordScoreGame;

    private void Start()
    {
        LoadRecordScoreGameProgress();
    }

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        if (_type == SegmentType.Finish)
        {
            if (_scoreRecording._Score > _recordScoreGame)
            {
                _recordScoreGame = _scoreRecording._Score;
                SaveRecordScoreGameProgress();
            }
        }
    }

    private void SaveRecordScoreGameProgress()
    {
        PlayerPrefs.SetInt("RecordScoreGame:_recordScoreGame", _recordScoreGame);
    }

    private void LoadRecordScoreGameProgress()
    {
        _recordScoreGame = PlayerPrefs.GetInt("RecordScoreGame:_recordScoreGame", 0);
    }

    private void ResetRecordScoreGameProgress()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}