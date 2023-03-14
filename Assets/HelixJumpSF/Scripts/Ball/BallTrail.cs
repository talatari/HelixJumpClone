using UnityEngine;

public class BallTrail : BallEvents
{
    [SerializeField] private Transform _parentTransform;
    [SerializeField] private MeshRenderer _meshRendererVisualModel;
    [SerializeField] private Blot _blotPrefab;

    protected override void OnBallCollisionSegment(SegmentType _type)
    {
        if (_type != SegmentType.Empty)
        {
            Blot _blot = Instantiate(_blotPrefab, _parentTransform);
            _blot.Init(new Vector3(
                _meshRendererVisualModel.transform.position.x,
                transform.position.y,
                _meshRendererVisualModel.transform.position.z),
                _meshRendererVisualModel.material.color);
        }
    }
}
