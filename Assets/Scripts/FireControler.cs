using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControler : MonoBehaviour
{
    [SerializeField] Transform Gun;
    [SerializeField] GameObject _Bullet;
    [SerializeField] float Power = 800;
    [SerializeField] Camera _Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1")) 
        
        {
            Vector3 MousePos = Input.mousePosition;

            var ray = _Camera.ScreenPointToRay(MousePos);

            if (Physics.Raycast(ray, out var hint, 1000))
            {
                GameObject Bullet = Instantiate(_Bullet, Gun.transform.position, Quaternion.identity);

                Bullet.GetComponent<Rigidbody>().AddForce((hint.point - Gun.position).normalized * Power);
            }

            Debug.Log(_Camera.ScreenToWorldPoint(MousePos));

            

        }
    }
}
