using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = .125f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, 0) + offset;
        /*
        Vector2 smoothedPosition = Vector2.Lerp(transform.right, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        */
        transform.position = desiredPosition;
    }
}
