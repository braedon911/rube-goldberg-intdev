using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().WakeUp();
        }
    }
}
