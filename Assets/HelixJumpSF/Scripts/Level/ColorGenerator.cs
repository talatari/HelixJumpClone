using UnityEngine;

[System.Serializable]
public class LevelPallete
{
    public Color AxisColor;
    public Color BallColor;
    public Color DefaultSegmentColor;
    public Color TrapSegmentColor;
    public Color FinishSegmentColor;
}

public class ColorGenerator : MonoBehaviour
{
    [SerializeField] private LevelPallete[] _levelPallete;
    [SerializeField] private Material _axisMaterial;
    [SerializeField] private Material _ballMaterial;
    [SerializeField] private Material _defaultMaterial;
    [SerializeField] private Material _trapMaterial;
    [SerializeField] private Material _finishMaterial;

    private void Start()
    {
        int _index = Random.Range(0, _levelPallete.Length);

        _axisMaterial.color = _levelPallete[_index].AxisColor;
        _ballMaterial.color = _levelPallete[_index].BallColor;
        _defaultMaterial.color = _levelPallete[_index].DefaultSegmentColor;
        _trapMaterial.color = _levelPallete[_index].TrapSegmentColor;
        _finishMaterial.color = _levelPallete[_index].FinishSegmentColor;
    }
}
