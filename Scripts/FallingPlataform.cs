using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlataform : MonoBehaviour
{
    public float fallTime;

    private TargetJoint2D target;
    private BoxCollider2D boxCol;

    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxCol = GetComponent<BoxCollider2D>();

    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            Invoke("Falling", fallTime);
        }

       
    }

    void OnTriggerEnter2D (Collider2D collider){
         if (collider.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }

    }

    void Falling(){
        gameObject.GetComponent<AudioSource>().Play();
        target.enabled = false;
        boxCol.isTrigger = true;

    }
}
