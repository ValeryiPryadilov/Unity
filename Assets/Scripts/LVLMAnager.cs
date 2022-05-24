using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLMAnager : MonoBehaviour

    
{
   public static Action<float> LVLEnd;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        
        { 
           LVLEnd?.Invoke(1f);
        }

    }
}
