using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 moveToPlayer = target.position + offset;
        Vector3 newPos = Vector3.Lerp(target.position, moveToPlayer, smoothSpeed);

        transform.position = newPos;
    }
}
