using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform currentTarget;
    [SerializeField]
    private float smoothing = 0.2f;

    void Update()
    {
        if (currentTarget != null)
        {
            Vector3 targetPosition = currentTarget.position;
            Vector3 currentPosition = transform.position;

            targetPosition = Vector3.Lerp(currentPosition, targetPosition, smoothing * Time.deltaTime);
            targetPosition.z = -10f;

            transform.position = targetPosition;
        }
    }
}
