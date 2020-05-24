using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delaySound : MonoBehaviour
{
    public GameObject audioSource;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(VoiceOn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    IEnumerator VoiceOn()
    {
        
        
        yield return new WaitForSeconds(90f);
        audioSource.SetActive(true);
        yield return new WaitForSeconds(15f);
        audioSource.SetActive(false);
        StartCoroutine(VoiceOn());
    }

}
