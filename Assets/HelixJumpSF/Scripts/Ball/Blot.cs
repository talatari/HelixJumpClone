using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Blot : MonoBehaviour
{
    private SpriteRenderer _spriteRendererBlot;
    [SerializeField] private float _offset;

    private void Awake()
    {
        _spriteRendererBlot = GetComponent<SpriteRenderer>();
    }

    public void Init(Vector3 _position, Color _color)
    {
        transform.position = _position + new Vector3(0, _offset, 0);

        transform.eulerAngles = new Vector3(90, Random.Range(0, 360), 0);

        _spriteRendererBlot.color = _color;
    }
}
