using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    [SerializeField] private LevelGenerator _levelGenerator;
    [SerializeField] private LevelProgress _levelProgress;
    [SerializeField] private BallController _ballController;

    private void Start()
    {
        _levelGenerator.GenerateLevel(_levelProgress.CurrentLevel);

        _ballController.transform.position = new Vector3(
            _ballController.transform.position.x,
            _levelGenerator._LastFloorY,
            _ballController.transform.position.z);

    }
}