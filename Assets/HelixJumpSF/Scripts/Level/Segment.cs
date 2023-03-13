using System.Collections.Generic;
using UnityEngine;

public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}

[RequireComponent(typeof(MeshRenderer))]
public class Segment : MonoBehaviour
{
    [SerializeField] private Material _axisMaterial;
    [SerializeField] private Material _ballMaterial;
    [SerializeField] private Material _defaultMaterial;
    [SerializeField] private Material _finishMaterial;
    [SerializeField] private Material _trapMaterial;
    [SerializeField] private SegmentType _type;

    public SegmentType Type => _type;
    private MeshRenderer _meshRenderer;
    private ColorGenerator _colorGenerator;
    private List<Material> _materials;
    private Material _randomMaterial;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        _materials.Add(_axisMaterial);
        _materials.Add(_ballMaterial);
        _materials.Add(_defaultMaterial);
        _materials.Add(_finishMaterial);
        _materials.Add(_trapMaterial);
    }

    public void SetTrap()
    {
        _meshRenderer.enabled = true;
        _meshRenderer.material = _trapMaterial;
        //_meshRenderer.material = GetMaterial();

        _type = SegmentType.Trap;
    }

    public void SetEmpty()
    {
        _meshRenderer.enabled = false;

        _type = SegmentType.Empty;
    }

    public void SetFinish()
    {
        _meshRenderer.enabled = true;
        _meshRenderer.material = _finishMaterial;
        //_meshRenderer.material = GetMaterial();

        _type = SegmentType.Finish;
    }

    private Material GetMaterial()
    {
        if (_materials.Count > 0)
        {
            int _randomIndex = Random.Range(0, _materials.Count);

            _randomMaterial = _materials[_randomIndex];
            _materials.RemoveAt(_randomIndex);

            return _randomMaterial;
        }
        else
        {
            return _randomMaterial;
        }
    }
}