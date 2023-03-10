using UnityEngine;

public abstract class OnColliderTrigger : MonoBehaviour
{
    private Collider _lastCollider;

    protected virtual void OnOneTriggerEnter(Collider _other) { }

    private void OnTriggerEnter(Collider _other)
    {
        if (_lastCollider != null && _lastCollider != _other)
        {
            return;
        }

        _lastCollider = _other;

        OnOneTriggerEnter(_other);
    }

    private void OnTriggerExit(Collider _other)
    {
        if (_lastCollider == _other)
        {
            _lastCollider = null;
        }
    }
}
