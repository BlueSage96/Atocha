using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Switch_hands : MonoBehaviour
{
    public GameObject hand;
    public GameObject axe;
    public GameObject plank;
    
    public int handCount = 0;
    
   

    public SteamVR_Action_Boolean grabAction;
    public SteamVR_Input_Sources handType;


    private void Update()
    {
        if (handCount == 0)
        {

            if (grabAction.GetState(handType))
            {
                StartCoroutine(axeOn());

            }//END If statement


        }//End outer if Statement

        else
        if (handCount == 2)
        {

            if (grabAction.GetState(handType))
            {
                StartCoroutine(handOn());
            }//End if else if statement

        }

        else
        if (handCount == 1)
        {
            if (grabAction.GetState(handType))
            {
                StartCoroutine(plankOn());
            }//End if else if statement
        }        

       
    


    }//END Update

    IEnumerator axeOn()
    {
        axe.SetActive(true);
        hand.SetActive(false);
        plank.SetActive(false);
        yield return new WaitForSeconds(.5f);
        handCount = 1;
    }

    IEnumerator handOn()
    {
        axe.SetActive(false);
        hand.SetActive(true);
        plank.SetActive(false);
        yield return new WaitForSeconds(.5f);
        handCount = 0;

    }

    IEnumerator plankOn()
    {
        axe.SetActive(false);
        plank.SetActive(true);
        hand.SetActive(false);
        yield return new WaitForSeconds(.5f);
        handCount= 2;

    }


}
