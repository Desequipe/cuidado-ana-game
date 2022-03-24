using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FalaControler : MonoBehaviour
{

    public static FalaControler instance;
     [System.Serializable]
    public class ELEMENTS
    {
        public GameObject speechPanel;
        public GameObject painel;
    
        public TextMeshProUGUI speechText;
    }
    public GameObject speechPanel { get { return elements.speechPanel; } }
    public GameObject painel { get { return elements.painel; } }
  
    public TextMeshProUGUI speechText { get { return elements.speechText; } }

    public ELEMENTS elements;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        speechPanel.SetActive(false);

        //DialospeechPanelMe.SetActive(false);
    }

    public void Say(string speech)
    {
      
            StopSpeaking();
            speaking = StartCoroutine(Speaking(speech, false)); 
    }

     public void StopSpeaking()
    {
        if (isSpeaking)
        {
            StopCoroutine(speaking);
        }
        speaking = null;
    }

    public bool isSpeaking { get { return speaking != null; } }

    //[HideInInspector] public bool isWaitingForUserInput = false;

    public string targetSpeech = "";
    Coroutine speaking = null;

    IEnumerator Speaking(string speech, bool additive)
    {
        speechPanel.SetActive(true);
        targetSpeech = speech;
        if (!additive)
            speechText.text = "";
        else
            targetSpeech = speechText.text + targetSpeech;
        //isWaitingForUserInput = false;

        while(speechText.text != targetSpeech)
        {
            speechText.text += targetSpeech[speechText.text.Length];
            yield return new WaitForFixedUpdate();
        }

        //isWaitingForUserInput = true;
        //while (isWaitingForUserInput)
            //yield return new WaitForEndOfFrame();
        StopSpeaking();
    }

    void OnTriggerEnter2D(Collider2D collider){

        if(collider.gameObject.tag == "Player"){
            Say(speechText.text);
        
            Destroy(gameObject);
        }
    }

    
   
}