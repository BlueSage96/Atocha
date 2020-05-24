using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update


    public float yAngle = 10f;// Used for future ability to change degrees of turning.
    public GameObject self;
    public GameObject auido;
    private bool ready = true;
    public float set;
    public bool go = false;

    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (ready)
        {
            StartCoroutine(playSound());
        }
        //self.transform.rotation *= Quaternion.AngleAxis(yAngle, Vector3.down);
    }


    IEnumerator playSound()
    {
        ready = false;
        auido.SetActive(true);
        self.transform.Rotate(0f, yAngle, 0f, Space.Self);
        if (self.transform.eulerAngles.y == set)
        {
            go = true;
        }
        
        //self.transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 1f), 90f);
        yield return new WaitForSeconds(1f);
        auido.SetActive(false);
        ready = true;
    }


}
