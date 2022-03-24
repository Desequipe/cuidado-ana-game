using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditosController : MonoBehaviour
{
    public void Menu()
    {
        Debug.Log("Voltar");
        GameObject.Find("Voltar").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(0);
    }
}
