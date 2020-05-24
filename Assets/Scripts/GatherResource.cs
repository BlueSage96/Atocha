using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherResource : MonoBehaviour
{

    public GameObject self;
    public GameObject text;
    private void OnCollisionEnter(Collision collision)
    {

        StartCoroutine(Start());
       
     

    }



    IEnumerator Start()
    {

        text.SetActive(true);
        yield return new WaitForSeconds(3f);
        self.SetActive(false);


    }


}
