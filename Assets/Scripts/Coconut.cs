using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coconut : MonoBehaviour
{
    public GameObject coconutWhole;
    public GameObject coconutOpen;
   
    


    int num = 3; //needs to be set to a random number, 5 will work for now.
    int count = 0;
    public bool eatMe = false; //a tag to allow the item to be eaten.

    public int food;
    public int water;




    private void OnTriggerEnter(Collider collisionInfo)
    {

        if (collisionInfo.tag == "Hard Surface")
        {

            count++; 
            //Debug.Log(transform.name + " has hit a hard surface this many times: " + count);
            if (count >= num)//num should be replaced with a random number at some point
            {
                coconutWhole.SetActive(false);
                coconutOpen.SetActive(true);
                eatMe = true;
                

                
            }//End of inside if statement

        }//End outside if statement

        if (collisionInfo.tag == "Mouth") // Allows the player to "Eat" the food.
        {
            if (eatMe)
            {
                coconutOpen.SetActive(false);
                coconutWhole.SetActive(false);
                

                PlayerManager.instance.Hunger += food;
                PlayerManager.instance.Thirst += water;

            }
        }



    }// End of ontigger

    
}
