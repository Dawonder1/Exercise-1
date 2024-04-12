using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 11f;
    private float turnSpeed = 25f;
    [SerializeField] float horsePower;
    private float horizontalInput;
    private float verticalInput;
    Rigidbody playerRb;
    [SerializeField] GameObject CenterOfMass;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = CenterOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moves the car forward based on vertical input
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);

        //rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
