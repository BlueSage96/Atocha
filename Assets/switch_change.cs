using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collisionInfo)
    {




        if (collisionInfo.tag == "Switch")
        {

            Switch_players.instance.switcher = false;


        }



    }// End on trigger
}
