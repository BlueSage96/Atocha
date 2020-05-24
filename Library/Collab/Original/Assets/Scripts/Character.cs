using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour{
    private GameObject lemur;

    // Start is called before the first frame update
    void Start(){
        lemur = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update(){

    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Animal")){
            lemur.transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
}
