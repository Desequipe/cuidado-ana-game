using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Próximo : MonoBehaviour
{
    void Update(){

        if(Input.GetButtonDown("Jump")){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
