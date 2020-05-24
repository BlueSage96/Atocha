//source code found here: https://github.com/UnityTutorialsHD/Unity-Tutorial-Assets/blob/master/ThrowObject.cs

using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour{
    /*public Transform player;//checks the range of the player object, player transform, and game object's position
    public Transform playerCam;//object follows the camera's movement
    public float throwForce = 10;//multiply the add force to the rigidbody (?)
    bool hasPlayer = false;//if player's in range of the object
    bool beingCarried = false;//checks if object's being thrown
    public AudioClip[] soundToPlay;
    private AudioSource audio1;
    
    private bool touched = false;

    //get component of the audio source
    void Start(){
        audio1 = GetComponent<AudioSource>();
    }

    void Update(){
        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        //distance has to be 2.5 or greater otherwise we can't pick it up
        if (dist <= 2.5f){
            hasPlayer = true;
        }
        else{
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetButtonDown("Use")){
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }
        if (beingCarried){
            if (touched){
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }

            if (Input.GetMouseButtonDown(0)){
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                RandomAudio();
            }
            else if (Input.GetMouseButtonDown(1)){
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }
    void RandomAudio(){
        if (audio1.isPlaying){
            return;
        }
        audio1.clip = soundToPlay[Random.Range(0, soundToPlay.Length)];
        audio1.Play();

    }
    void OnTriggerEnter(){
        if (beingCarried){
            touched = true;
        }
    }*/
}