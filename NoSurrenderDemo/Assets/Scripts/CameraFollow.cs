using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    [Range (0.01f, 1.00f)]
    public float smoothfactor = 0.5f;
    private Vector3 cameraoffset;
    void Start()
    {
        cameraoffset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newposition = player.position + cameraoffset;
        transform.position = Vector3.Slerp(transform.position, newposition, smoothfactor);
    }
}
