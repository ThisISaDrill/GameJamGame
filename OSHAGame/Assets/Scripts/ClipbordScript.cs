using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipbordScript : MonoBehaviour
{
    public int violationDesignation;
   GameObject player;
    
    
    void Start()
    {
      gameObject.SetActive(false);
      player = GameObject.Find("Player");
    }

    public void Active()
    {
        gameObject.SetActive(true);
        player.GetComponent<PlayerMovement>().isInteracting();
        
    }

    public void None()
    {
        GameManager.singleton.PlayerAnswer(violationDesignation,0);
        gameObject.SetActive(false);
        player.GetComponent<PlayerMovement>().isInteracting();
    }

    public void Security()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,1);
       gameObject.SetActive(false);
       player.GetComponent<PlayerMovement>().isInteracting();
    }

    public void Equipment()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,2);
       gameObject.SetActive(false);
       player.GetComponent<PlayerMovement>().isInteracting();
    }

    public void Themeing()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,3);
       gameObject.SetActive(false);
       player.GetComponent<PlayerMovement>().isInteracting();
    }

    public void Material()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,4);
       gameObject.SetActive(false);
       player.GetComponent<PlayerMovement>().isInteracting();
    }

    public void Magic()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,5);
       gameObject.SetActive(false);
       player.GetComponent<PlayerMovement>().isInteracting();
    }

    public void Facilities()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,6);
       gameObject.SetActive(false);
       player.GetComponent<PlayerMovement>().isInteracting();
    }


    
}
