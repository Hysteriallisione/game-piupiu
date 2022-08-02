using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public Rigidbody rigidbodyComponent;
    public float forceInspe;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        verticalInput = Input.GetAxis("Vertical");


       // if (Input.GetKeyDown(KeyCode.Joystick1Button4))
       // {
          //  Player.transform.Rotate = new Vector3(+1, 0, 0);
       // }
}

private void FixedUpdate()
    {
        rigidbodyComponent.AddForce(new Vector3(horizontalInput * forceInspe, 0, 0));
        rigidbodyComponent.AddForce(new Vector3(0, 0, verticalInput * forceInspe));
    }
}