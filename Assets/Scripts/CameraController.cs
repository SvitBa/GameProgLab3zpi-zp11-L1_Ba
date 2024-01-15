using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    public Transform player; // The player's transform
    public float smoothTime = 0.3f; // Smoothing time for camera movement

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (player != null)
        {
            // Calculate target position with a slight offset in the y-axis
            Vector3 targetPosition = new Vector3(player.position.x, player.position.y, transform.position.z);

            // Smoothly move the camera towards the target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}

