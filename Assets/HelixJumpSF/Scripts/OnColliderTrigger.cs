using UnityEngine;

public abstract class OnColliderTrigger : MonoBehaviour
{
    private Collider _lastCollider;

    protected virtual void OnOneTriggerEnter(Collider other) { }

    private void OnTriggerEnter(Collider other)
    {
        if (_lastCollider != null && _lastCollider != other)
        {
            return;
        }

        _lastCollider = other;

        OnOneTriggerEnter(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if (_lastCollider == other)
        {
            _lastCollider = null;
        }
    }
}
