using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatusTwo : MonoBehaviour
{
    public bool gameLost = false;
    public bool gameWon = false;


    private void OnTriggerEnter(Collider collisionInfo)
    {

       


        if (collisionInfo.tag == "Lose")
        {
            //Restart Game
            gameLost = true;
            SceneManager.LoadScene("Beach Scene");


        }


        if(collisionInfo.tag == "Win")
        {
            //Go to winning Screen
            //gameWon = true;
            SceneManager.LoadScene("Win Scene");
        }
    }// End on trigger

    private void FixedUpdate()
    {
        if (gameLost)
        {
           // SceneManager.LoadScene("Beach Scene");
        }

        if (gameWon)
        {
            //SceneManager.LoadScene("Starting Scene");
        }

    }


    void Restart()
    {
        //SceneManager.LoadScene("Beach Scene");
        gameLost = false;
    }


    void Win()
    {
        //SceneManager.LoadScene("Win Scene");

    }

}
