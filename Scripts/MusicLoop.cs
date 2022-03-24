using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoop : MonoBehaviour
{
    [System.Serializable]
    public class ELEMENTS
    {
        public GameObject inicio;
        public GameObject loop;
    
    }
    public GameObject inicio { get { return elements.inicio; } }
    public GameObject loop { get { return elements.loop; } }
  
   

    public ELEMENTS elements;
    
    void Start()
    {
        StartCoroutine(TocarLoop());
    }

    void Update()
    {
        
    }

    IEnumerator TocarLoop()
    {
       
            yield return new WaitForSeconds(25.714f);
            loop.GetComponent<AudioSource>().Play();
    }
}
