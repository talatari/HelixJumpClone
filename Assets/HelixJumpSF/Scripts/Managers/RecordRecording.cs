using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordRecording : BallEvents
{
    [SerializeField] private ScoreRecording _scoreRecording;

    private int _recordScoreGame;
    public int _RecordScoreGame => _recordScoreGame;

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        //Debug.Log($"_scoreRecording._Score = {_scoreRecording._Score}");
        //Debug.Log($"_recordScoreGame = {_recordScoreGame}");

        if (_type == SegmentType.Finish)
        {
            if (_scoreRecording._Score > _recordScoreGame)
            {
                Debug.Log("SaveRecordScoreGameProgress();");
                SaveRecordScoreGameProgress();
            }
        }
    }

    private void SaveRecordScoreGameProgress()
    {
        PlayerPrefs.SetInt(
            "RecordScoreGame:_recordScoreGame", _recordScoreGame);
    }

    private void LoadRecordScoreGameProgress()
    {
        _recordScoreGame = PlayerPrefs.GetInt(
            "RecordScoreGame:_recordScoreGame", 0);
    }

    private void ResetRecordScoreGameProgress()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
