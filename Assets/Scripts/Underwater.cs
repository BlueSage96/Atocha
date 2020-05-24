using UnityEngine;

public class Underwater : MonoBehaviour{
    public float waterLevel;//can change ourselves
    private float terrain;//can change ourselves
    private bool isUnderwater;
    private Color normalColor;
    private Color underwaterColor;

    private void Start(){
        normalColor = new Color(0.53f,0.81f,1.0f,0.60f);//sky blue
        underwaterColor = new Color(0.66f, 0.78f, 0.88f, 0.3f);
    }

    private void Update(){

        //if the y position is under the waterlevel use the underwater color
        //otherwise, the normal sky color is used
        //will do something similar for the terrain
        if(transform.position.y < waterLevel != isUnderwater){
            isUnderwater = transform.position.y < waterLevel;

            if (isUnderwater) SetUnderwater();

            if (!isUnderwater) SetNormal();
        }

        if (transform.position.y > waterLevel != isUnderwater){
          if (!isUnderwater) SetNormal();
       }
    }

    void SetNormal(){
        //sets the normal color
        RenderSettings.fogColor = normalColor;
        RenderSettings.fogDensity = 0.0005f;
        //terrain = 100;
    }

    void SetUnderwater(){
        //set the underwater color
        RenderSettings.fogColor = underwaterColor;
        RenderSettings.fogDensity = 0.05f;
        //terrain = 100;
    }
}
