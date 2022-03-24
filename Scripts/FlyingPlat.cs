using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingPlat : MonoBehaviour
{
    private bool moveRight = true;
    public float speed;
    public Transform pontoA;
    public Transform pontoB;

    void FixedUpdate()
    {
      if(transform.position.x < pontoA.position.x){
        moveRight = true;
      }
      if(transform.position.x > pontoB.position.x){
          moveRight = false;
      }

      if(moveRight){
      transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y );
      }else{
      transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y );
      }
    }
} 