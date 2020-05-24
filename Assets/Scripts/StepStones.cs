using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepStones : MonoBehaviour
{
    public GameObject stepStones;
    public GameObject exo;
    


    private void OnTriggerEnter(Collider other)
    {
        stepStones.SetActive(true);
        exo.SetActive(false);

    }
}
