using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgress : BallEvents
{
    private int _currentLevel = 1;
    private int _defaultCurrentLevel = 1;
    public int CurrentLevel => _currentLevel;

    protected override void Awake()
    {
        base.Awake();

        LoadGameProgress();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            ResetGameProgress();
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        if (_type == SegmentType.Finish)
        {
            _currentLevel++;
            SaveGameProgress();
        }
    }

    private void SaveGameProgress()
    {
        PlayerPrefs.SetInt("LevelProgress:_currentLevel",
            _currentLevel);
    }

    private void LoadGameProgress()
    {
        _currentLevel = PlayerPrefs.GetInt("LevelProgress:_currentLevel",
            _defaultCurrentLevel);
    }

    private void ResetGameProgress()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
