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
    // why public?
    [SerializeField] public SegmentType type;
}
