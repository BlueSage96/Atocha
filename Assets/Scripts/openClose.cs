using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class openClose : MonoBehaviour
{
    public GameObject thisTop;
    public GameObject otherTop;
    public GameObject treasure;
    public AudioSource audioPlayer;
    //public GameObject picture;
    public GameObject exo;
    private bool closed = true;
    //public GameObject video;
   
    
    



    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Hand")
        {
            if (closed){
                thisTop.SetActive(false);
                otherTop.SetActive(true);
                treasure.SetActive(true);
                audioPlayer.enabled = true;
                //picture.SetActive(false);
                //video.SetActive(true);
                StartCoroutine(Soundoff());
                exo.SetActive(false);
                closed = false;
            }
            else
            {
                thisTop.SetActive(true);
                otherTop.SetActive(false);
                closed = true;
            }
        }

    }

    
    IEnumerator Soundoff()
    {


        yield return new WaitForSeconds(1.5f);
        audioPlayer.enabled = false;
        
    }



}
