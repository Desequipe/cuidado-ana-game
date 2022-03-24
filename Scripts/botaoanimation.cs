using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botaoanimation : MonoBehaviour
{
  
   public Animator anim;
   public bool on = false;
   
    void Start()
    {

    }

    void Update()
    {

    }
        
        
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Box" ){
            gameObject.GetComponent<AudioSource>().Play();
            anim.SetTrigger("On");
            on = true;
        }
    }
}