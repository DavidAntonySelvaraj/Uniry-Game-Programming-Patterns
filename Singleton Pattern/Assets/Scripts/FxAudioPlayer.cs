using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxAudioPlayer : MonoBehaviour
{
    
    public static FxAudioPlayer instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

}//class

















































