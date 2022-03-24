using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueE2 : MonoBehaviour
{
    FalaControler dialogue;

    void Start()
    {
        dialogue = FalaControler.instance;
    }


    public string[] s = new string[]
    {
        "Lá está o vendedor de dog. Vou falar com ele.:JOÃO193435",
        "Ok, obrigado pela ajuda Públio.:JOÃO193435"


    };

    int index = 0;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            if (!dialogue.isSpeaking)
            {
                if (index >= s.Length)
                {

                    //Application.Quit();
                    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    SceneManager.LoadScene(0);
                    Debug.Log("Fim do diálogo, troca a cena");
                    return;
                }
                Say(s[index]);
                index++;
            }
        }
    }
    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        //string speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.Say(speech);
    }
}
