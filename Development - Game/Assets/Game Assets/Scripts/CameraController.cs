using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    public Vector3 offsetPosition = new Vector3(0, 3, -5);

    public Vector3 offsetRotation = new Vector3(15, 0, 0);

    // LateUpdate is called once per frame after all Update functions have been completed.
    void LateUpdate()
    {
        transform.position = player.transform.position + player.transform.TransformDirection(offsetPosition);
        transform.rotation = player.transform.rotation * Quaternion.Euler(offsetRotation);
    }
}
