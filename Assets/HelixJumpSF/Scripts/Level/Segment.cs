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
    [SerializeField] private Material _trapMaterial;
    [SerializeField] private Material _finishMaterial;
    [SerializeField] private SegmentType _type;

    public SegmentType Type => _type;
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetTrap()
    {
        _meshRenderer.enabled = true;
        _meshRenderer.material = _trapMaterial;

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

        _type = SegmentType.Finish;
    }
}