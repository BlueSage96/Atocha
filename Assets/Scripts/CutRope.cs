using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutRope : MonoBehaviour
{


    public GameObject floatingBridge;
    public GameObject levelBridge;
    public GameObject rope;
    private int count;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Hard Surface")// The ax is tagged with hard surface.
        {
            count++;

            if (count > 2)
            {

                rope.SetActive(false); //Removes the rope.
                levelBridge.SetActive(true);
                floatingBridge.SetActive(false);//Turns off the floating bridge.

            }// End inside if statement.
            
        }//End Collision info If statement

    }//End on trigger enter
}
