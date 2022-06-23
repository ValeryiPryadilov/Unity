using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLvlControlller : MonoBehaviour
{
    [SerializeField] int Index;

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            SceneLoader.LoadScene(Index);
        }
    } 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
