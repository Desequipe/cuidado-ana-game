using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
   public float JumpForce;
   public Animator anim;

   void Start(){
       anim.GetComponent<Animator>();
       
   }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            gameObject.GetComponent<AudioSource>().Play();
            anim.SetTrigger("Jump");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            

        
        }
    }
}
