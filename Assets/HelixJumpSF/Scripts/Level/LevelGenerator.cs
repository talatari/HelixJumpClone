using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform _axis;
    [SerializeField] private Floor _floorPrefab;
    [SerializeField] private int _defaultFloorAmount;
    [SerializeField] private float _floorHeight;
    [SerializeField] private int _emptySegmentAmount;
    [SerializeField] private int _minTrapSegment;
    [SerializeField] private int _maxTrapSegment;

    private int _countLevel = 1;
    private int _floorAmount;
    public int _FloorAmount => _floorAmount;
    private string _floorName = "_Floor";
    private float _lastFloorY = 0.0f;
    public float _LastFloorY => _lastFloorY;
    private float _indentPerFloor = 1.0f;

    public void GenerateLevel(int _countLevel)
    {
        DestroyChildFloors();

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

            if (i == 0)
            {
                _floor.SetFinishAllSegments();
            }

            if (i > 0 && i < _floorAmount - 1)
            {
                _floor.SetRandomRotation();
                _floor.AddEmptySegment(_emptySegmentAmount);
                _floor.AddRandomTrapSegment(Random.Range(
                    _minTrapSegment, _maxTrapSegment + 1));
            }

            if (i == _floorAmount - 1)
            {
                _floor.AddEmptySegment(_emptySegmentAmount);
                _lastFloorY = _floor.transform.position.y + _indentPerFloor;
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
