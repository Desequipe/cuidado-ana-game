using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
     public void PlayGame()
    {
        Debug.Log("Iniciar");
        GameObject.Find("Iniciar").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreditGame()
    {
        Debug.Log("Creditos");
        GameObject.Find("Creditos").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(9);
    }

    public void QuitGame()
    {
        Debug.Log("Sair");
        GameObject.Find("Sair").GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}