using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class item1 : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D collider){

        if(collider.gameObject.tag == "Player"){
            gameObject.GetComponent<AudioSource>().Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Destroy(gameObject);
        }
    }
}
