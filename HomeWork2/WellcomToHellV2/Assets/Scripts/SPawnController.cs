using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPawnController : MonoBehaviour
{

    [SerializeField] GameObject m_enemy;

    public GameObject parrent;

    private void Start()
    {
        Instantiate(m_enemy, parrent.transform.position, transform.rotation, parrent.transform);
        Instantiate(m_enemy, parrent.transform.position, transform.rotation, parrent.transform);
        Instantiate(m_enemy, parrent.transform.position, transform.rotation, parrent.transform);
        Instantiate(m_enemy, parrent.transform.position, transform.rotation, parrent.transform);
        Instantiate(m_enemy, parrent.transform.position, transform.rotation, parrent.transform);




    }


}
