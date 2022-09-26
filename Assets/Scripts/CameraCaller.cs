using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCaller : MonoBehaviour
{
    public Transform camera;
    CameraFollower follower;

    private void Start()
    {
        follower = camera.GetComponent<CameraFollower>();
    }
    void CallCamera()
    {
        
    }
}
