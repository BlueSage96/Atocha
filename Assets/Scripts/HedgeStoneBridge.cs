using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedgeStoneBridge : MonoBehaviour
{
    public GameObject HedgeStone1;
    public GameObject HedgeStone2;
    public GameObject HedgeStone3;
    public GameObject HedgeStone4;

    public GameObject Bridge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HedgeStone1.transform.eulerAngles.y >= 90 && HedgeStone1.transform.eulerAngles.y <= 91 &&  HedgeStone2.transform.eulerAngles.y <= 271 && HedgeStone2.transform.eulerAngles.y >= 270 && HedgeStone3.transform.eulerAngles.y >= 270 && HedgeStone3.transform.eulerAngles.y <= 271 &&  HedgeStone4.transform.eulerAngles.y >= 90 && HedgeStone4.transform.eulerAngles.y <= 91)
        //if (HedgeStone1.transform.rotation.y == 90.00001 && HedgeStone2.transform.rotation.y == -90.00001 && HedgeStone3.transform.rotation.y == 270 && HedgeStone4.transform.rotation.y == 90.00001)
        {
            Bridge.SetActive(true);
        }
        
    }

    


}
