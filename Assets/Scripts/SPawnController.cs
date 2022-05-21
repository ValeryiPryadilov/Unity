using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPawnController : MonoBehaviour
{

    [SerializeField] GameObject m_enemy;
    [SerializeField] int MobSpawn;

    public Transform[] SpawnPos;

    private void Start()
    {
        for (int i = 0; i < MobSpawn; i++)
        
        {
            //Instantiate(m_enemy, SpawnPos.position, Quaternion.identity);
        }


        
        




    }


}
