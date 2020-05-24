using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;

    public static PlayerManager instance;
    public int Resource;
    public int Thirst;
    public int Hunger;
    
    public Slider hungerBar;
    public Slider thirstBar;
    public Slider resourceBar;

    private void Start()
    {
        instance = this;
    }//End Start
    public void Update()
    {
        updateHunger();// Sets the hunger bar to the current value
        updateThirst();//Sets the thirst bar to the current value
        updateResource();//Sets the resource bar to the current value
    }//End update
    public virtual void updateHunger()
    {
        hungerBar.value = Hunger;
    }//End updateHunger

    public virtual void updateThirst()
    {
        thirstBar.value = Thirst;
    }//End updateThirst

    public virtual void updateResource()
    {
        resourceBar.value = Resource;
    }

}//End PlayerManager
