using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta2 : MonoBehaviour
{
     public Animator anim;
    public botaoanimation botao;
    public Collider2D col;
    public bool open = false;
    public bool tocando = false;
   

    void Start()
    {
        botao = GameObject.Find("BotaoEsq").GetComponent<botaoanimation>();
       

        col = gameObject.GetComponent<Collider2D>();
    }

    
    void Update()
    {
        if(botao.on){
            Destroy(col);
            anim.SetTrigger("Open");
            open = true;
            StartCoroutine(PortaSom());
        }
        
    }

     IEnumerator PortaSom()
    {
        while (open){ 
        GameObject.Find("SomPorta").GetComponent<AudioSource>().Play();
        tocando = true;

            yield return new WaitForSeconds(1f);
            Destroy(GameObject.Find("SomPorta"));
        }


    }
}
