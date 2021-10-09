using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipbordScript : MonoBehaviour
{
    public int violationDesignation;
    void Awake()
    {
        //gameObject.SetActive(false);
    }
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void Active()
    {
        gameObject.SetActive(true);
    }

    public void None()
    {
        GameManager.singleton.PlayerAnswer(violationDesignation,0);
        gameObject.SetActive(false);
    }

    public void Security()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,1);
       gameObject.SetActive(false);
    }

    public void Equipment()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,2);
       gameObject.SetActive(false);
    }

    public void Themeing()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,3);
       gameObject.SetActive(false);
    }

    public void Material()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,4);
       gameObject.SetActive(false);
    }

    public void Magic()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,5);
       gameObject.SetActive(false);
    }

    public void Facilities()
    {
       GameManager.singleton.PlayerAnswer(violationDesignation,6);
       gameObject.SetActive(false);
    }


    
}
