using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target; // attach to Doctor

    public float smoothSpeed = 0.125f;
    public Vector3 offset; // set z axis to around -3

    private void FixedUpdate()
    {
        Vector3 moveToPlayer = target.position + offset;
        Vector3 newPos = Vector3.Lerp(target.position, moveToPlayer, smoothSpeed);

        transform.position = newPos;
    }
}
