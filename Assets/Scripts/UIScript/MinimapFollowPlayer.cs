using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapFollowPlayer : MonoBehaviour
{
    public Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        Vector3 newPos = player.position;
        newPos.z = transform.position.z;
        transform.position = newPos;
    }
}
