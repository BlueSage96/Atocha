using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatherCoconuts : MonoBehaviour
{

    public GameObject treeA;
    public GameObject treeB;
    //public GameObject coconut1;
    //public GameObject coconut2;
   // public GameObject coconut3; //Currently using just 2
    public GameObject planks;
    public GameObject self;
    
    
    

    int count = 0;
    int num = 5; // Needs to be changed to a random number, for now 5 is fine.


    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Hard Surface")// The ax is tagged with hard surface.
        {            
            treeA.SetActive(false); //Removes the tree with coconuts and activates the one without.
            treeB.SetActive(true);
            //coconut1.SetActive(true);//Turns on the coconuts so they may fall from the tree.
            //coconut2.SetActive(true);
            //coconut3.SetActive(true);

            count++;

            if (count > num)
            {
                treeB.SetActive(false);
                planks.SetActive(true);
                PlayerManager.instance.Resource += 1;//Adds one to the resource.
                self.tag = "Other";
            }//End Inside If statement
        }//End Collision info If statement

    }//End on trigger enter
    


}
