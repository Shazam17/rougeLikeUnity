using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowing : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.2f;
    public Vector3 offset;
  

    private void FixedUpdate()
    {
        //perform calc for position
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPos;


        //perform calc for rotation
        transform.LookAt(target);
    }
}
