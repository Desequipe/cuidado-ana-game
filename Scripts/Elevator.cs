using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private bool moveDown = true;
    public float speed;
    public Transform pontoA;
    public Transform pontoB;

    void FixedUpdate()
    {
      if(transform.position.y > pontoA.position.y){
        moveDown = false;
      }
      if(transform.position.y < pontoB.position.y){
          moveDown = true;
      }

      if(moveDown){
      transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
      }else{
      transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
      }
    }
} 
