using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] Transform Door;

    private void OnTriggerEnter(Collider other)
    {
        Door.Translate(Vector3.down);
        Door.Translate(Vector3.down);
        Door.Translate(Vector3.down);
        Door.Translate(Vector3.down);
    }

    
        
    
}
