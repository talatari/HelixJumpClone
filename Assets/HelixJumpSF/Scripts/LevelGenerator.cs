using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform _axis;
    [SerializeField] private Floor _floorPrefab;

    [Header("Settings")]
    [SerializeField] private int _defaultFloorAmount;
    [SerializeField] private float _floorHeight;

    private int _countLevel = 1;
    private float _floorAmount;
    private string _floorName = "_Floor";
    public Transform _BALLTRANSFORM;
    private float _indentPerFloor = 1.0f;

    private void Start()
    {
        GenerateLevel(_countLevel);
    }

    public void GenerateLevel(int _countLevel)
    {
        DestroyChildFloors();

        _BALLTRANSFORM.position = new Vector3(
            _BALLTRANSFORM.position.x,
            _defaultFloorAmount * _floorHeight + _floorHeight + _indentPerFloor,
            _BALLTRANSFORM.position.z);

        _floorAmount = _defaultFloorAmount + _countLevel;

        _axis.transform.localScale = new Vector3(
            1, _floorAmount * _floorHeight + _floorHeight, 1);

        for (int i = 0; i < _floorAmount; i++)
        {
            Floor _floor = Instantiate(_floorPrefab, transform);
            _floor.transform.Translate(0, i * _floorHeight, 0);

            if (i <= 9)
            {
                _floor.name = $"0{i}{_floorName}";
            }
            else
            {
                _floor.name = $"{i}{_floorName}";
            }
        }
    }

    private void DestroyChildFloors()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i) == _axis)
            {
                continue;
            }

            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
