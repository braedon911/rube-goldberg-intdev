using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCaller : MonoBehaviour
{
    public Transform camera;
    CameraFollower follower;
    GameObject lastCollision;

    private void Start()
    {
        follower = camera.GetComponent<CameraFollower>();
    }
    void CallCamera()
    {
        follower.currentTarget = transform;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject != lastCollision)
        {
            CallCamera();
            lastCollision = collision.gameObject;
        }
    }
}
