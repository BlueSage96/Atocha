using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour
{
    public GameObject self;
    public GameObject transparent;
    public GameObject fullSelf;
    public Slider resourceBar;
    public GameObject sound;






    private void OnTriggerEnter(Collider collisionInfo)
    {

        if (collisionInfo.tag == "Resource")
        { 
            if (resourceBar.value > 0)
            {
                fullSelf.SetActive(true);
                transparent.SetActive(false);
                self.SetActive(false);
                PlayerManager.instance.Resource --;
                sound.SetActive(true);
            }
    }
    }
}
