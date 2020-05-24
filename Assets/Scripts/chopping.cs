using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class chopping : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioSource audioPlayer2;



    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Tree")
        {

            audioPlayer.enabled = true;
        }

        if (collisionInfo.tag == "Rope")
        {

            audioPlayer2.enabled = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        audioPlayer.enabled = false;
        audioPlayer2.enabled = false;
    }
}
