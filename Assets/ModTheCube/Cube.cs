using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
  
    [SerializeField] float walkspeed = 5f;
    [SerializeField] float sensitivity = 100;
    Rigidbody rb;
    public static Vector3 Rot;

    void Start()
    {
    
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move(h, v);

        float xRot = Input.GetAxisRaw("Mouse X");

        Rotate(xRot);
    }
     void Move(float h,float v)
    {
        rb.transform.Translate(h * walkspeed * Time.fixedDeltaTime, 0.0f, 0.0f);
        rb.transform.Translate(0.0f, 0.0f, v * walkspeed * Time.fixedDeltaTime);
    }

    void Rotate(float xRot)
    {
        Rot = Vector3.up * sensitivity;
        transform.Rotate(Rot* xRot *Time.fixedDeltaTime);
    }
}

