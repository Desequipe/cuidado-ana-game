using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaanimation : MonoBehaviour
{
    public Animator anim;
    public botaoanimation botao1, botao2, botao3;
    public Collider2D col;
    public bool open = false;
    public bool tocando = false;
   

    void Start()
    {
        botao1 = GameObject.Find("BotaoEsq").GetComponent<botaoanimation>();
        botao2 = GameObject.Find("BotaoEsq 2").GetComponent<botaoanimation>();
        botao3 = GameObject.Find("Botao3").GetComponent<botaoanimation>();
        

        col = gameObject.GetComponent<Collider2D>();
    }

    
    void Update()
    {
        if(botao1.on && botao2.on && botao3.on){
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
