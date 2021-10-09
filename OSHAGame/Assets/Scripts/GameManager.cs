using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton; 
    public GameObject[] interactables;

    public List<int> correctAnswers;
    public List<int> playerAnswers;
    //public List<int> violations;

    void Awake()
    {
        singleton = this;
    }
    void Start()
    {
        interactables = GameObject.FindGameObjectsWithTag("Clipboard");
        InitViolations();
    }

    void InitViolations()
    {
       //for(int i = 0; i < 7; i++)
       {
           //violations.Add(i);
       }
       //0 = no violation, 1 = Security concerns, 2 = poorly maintained equipment, 3 = improper themeing
       // 4 = substandard material, 5 = Improper Use of Magic, 6 = Improper use of facilities
       for(int i = 0; i < 6; i++)
       {
           playerAnswers.Add(0);
       }
    }

    public void PlayerAnswer(int vd, int v)
    {
        playerAnswers[vd] = v;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
