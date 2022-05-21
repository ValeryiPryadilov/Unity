using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour


{
    [SerializeField] float MovementSpeed = 600;
    [SerializeField] float JumpPower = 1000;
    bool isgrounded;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

     
    // Update is called once per frame
    void Update()
    {
        Move();     

        Jump();

        Debug.DrawRay(transform.position, transform.forward * 100);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isgrounded = true;
    }

    void Jump()

    {
        if (Input.GetKeyUp(KeyCode.Space))
        {

            Debug.Log("Spase");
            if(isgrounded == true)
            {
                Debug.Log("Graund");
                //float J = Input.GetAxis("Jump") * 60 * Time.deltaTime;
                rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
                rb.AddForce(new Vector3(0, 1, 0) * JumpPower * Time.deltaTime, ForceMode.VelocityChange);
                isgrounded=false;
            }

        }
        


    
    
    }
    void Move()
    {
        var xMov = Input.GetAxis("Horizontal") * MovementSpeed * Time.deltaTime;
        var zMov = Input.GetAxis("Vertical") * MovementSpeed * Time.deltaTime;

        rb.velocity = transform.TransformDirection(xMov, rb.velocity.y, zMov);
        //rb.MovePosition(transform.position + new Vector3(xMov, 0, zMov));
    }
}
