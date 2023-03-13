using System.Collections.Generic;
using UnityEngine;

public class ColorGenerator : MonoBehaviour
{
    [SerializeField] private Material _axis_mat;
    [SerializeField] private Material _ball_mat;
    [SerializeField] private Material _default_segment;
    [SerializeField] private Material _finish_segment;
    [SerializeField] private Material _trap_segment;

    private Material _randomMaterial;
    private List<Material> _materials;

    private void Start()
    {
        //_materials.Add(_axisMaterial);
        //_materials.Add(_ballMaterial);
        //_materials.Add(_defaultMaterial);
        //_materials.Add(_finishMaterial);
        //_materials.Add(_trapMaterial);

        //Debug.Log(_materials.Count);
    }

    public Material GetMaterial()
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
