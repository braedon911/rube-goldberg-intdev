using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform currentTarget;
    [SerializeField]
    private float smoothing = 0.1f;

    void Update()
    {
        if (currentTarget != null)
        {
            Vector3 targetPosition = currentTarget.position;
            Vector3 currentPosition = transform.position;

            transform.position = Vector3.Lerp(currentPosition, targetPosition, smoothing) + new Vector3(0f,0f,-10f);
        }
    }
}
