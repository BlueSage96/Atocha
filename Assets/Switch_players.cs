using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_players : MonoBehaviour
{

    public bool switcher = true;
    public GameObject player1;
    public GameObject player2;

    public static Switch_players instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (switcher)
        {
            player1.SetActive(true);
            player2.SetActive(false);
        }
        else
        {
            player2.SetActive(true);
            player1.SetActive(false);
        }
        
    }//End update

    
}
