using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        //Set the camera's position behind the player by an offset.
        transform.position = player.transform.position + offset;
    }
}
