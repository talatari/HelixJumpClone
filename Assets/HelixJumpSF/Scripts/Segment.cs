using UnityEngine;

public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}

public class Segment : MonoBehaviour
{
    [SerializeField] public SegmentType type;
}
