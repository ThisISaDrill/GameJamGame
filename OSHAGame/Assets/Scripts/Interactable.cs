using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject clipboard;
    bool canInteract = false;
    GameObject popup;

    void Awake()
    {
        popup = GameObject.Find("InteractText");
    }
    void Update()
    {
        CheckInteract();
    }
   
    void OnInteract()
    {  
        clipboard.GetComponent<ClipbordScript>().Active();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        canInteract = true;
        popup.GetComponent<PopupScript>().Active();
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        canInteract = false;
        popup.GetComponent<PopupScript>().Active();
    }

    void CheckInteract()
    {
        if(Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            OnInteract();
        }
    }
}
