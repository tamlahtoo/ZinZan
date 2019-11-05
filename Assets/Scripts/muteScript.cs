using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteScript : MonoBehaviour
{
    private int sound = 1;
    public Sprite on;
    public Sprite off;
    public GameObject button;

    public void muteSound()
    {
        if(sound == 1)
        {
            AudioListener.volume = 0f;
            sound = 0;
        }
        else
        {
            AudioListener.volume = 1.0f;
            sound = 1;
        }
        
    }
}
