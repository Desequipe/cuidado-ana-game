using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulo : MonoBehaviour
{
    public Rigidbody2D rb;

    public float esqRange;

    public float dirRange;

    public float speedMax;


    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
     rb.angularVelocity = speedMax;   
    }

    // Update is called once per frame
    void Update()
    {
        Push();
    }

    void Push(){
        if(transform.rotation.z > 0 
        && transform.rotation.z < dirRange
        && (rb.angularVelocity > 0)
        && rb.angularVelocity < speedMax){
            rb.angularVelocity = speedMax;
        }
        else if(transform.rotation.z < 0 
        && transform.rotation.z > dirRange
        && (rb.angularVelocity < 0)
        && rb.angularVelocity > speedMax * -1){
            rb.angularVelocity = speedMax * -1;
        }
    }
}
