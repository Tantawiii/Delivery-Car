using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject CarFollower;
    // Follow player with the camera
    void LateUpdate()
    {
        transform.position = CarFollower.transform.position + new Vector3(0,0,-2);
    }
}
