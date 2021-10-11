using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupScript : MonoBehaviour
{
    bool active = false;
    // Start is called before the first frame update
    void Start()
    {
       gameObject.SetActive(active); 
    }


    public void Active()
    {
        active = !active;
        gameObject.SetActive(active);
    }
}
