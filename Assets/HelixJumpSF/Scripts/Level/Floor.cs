using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private List<Segment> _defaultSegments;

    public void AddEmptySegment(int _countSegments)
    {
        for (int i = 0; i < _countSegments; i++)
        {
            _defaultSegments[i].SetEmpty();
        }

        for (int i = _countSegments; i >= 0; i--)
        {
            _defaultSegments.RemoveAt(i);
        }
    }

    public void AddRandomTrapSegment(int _countSegments)
    {
        for (int i = 0; i < _countSegments; i++)
        {
            int _index = Random.Range(0, _defaultSegments.Count);

            _defaultSegments[_index].SetTrap();
            _defaultSegments.RemoveAt(_index);
        }
    }

    public void SetRandomRotation()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
    }

    public void SetFinishAllSegments()
    {
        for (int i = 0; i < _defaultSegments.Count; i++)
        {
            _defaultSegments[i].SetFinish();
        }
    }


}