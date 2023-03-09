using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    [SerializeField] private string _mouseInputAxis;
    [SerializeField] private float _sensitive;

    private void Update()
    {
        if (Input.GetMouseButton(0) == true)
        {
            transform.Rotate(0, Input.GetAxis(_mouseInputAxis) * _sensitive * -1, 0);
        }
    }
}
