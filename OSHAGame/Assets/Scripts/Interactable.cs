using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject clipboard;
    bool canInteract = false;

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
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        canInteract = false;
    }

    void CheckInteract()
    {
        if(Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            OnInteract();
        }
    }
}
