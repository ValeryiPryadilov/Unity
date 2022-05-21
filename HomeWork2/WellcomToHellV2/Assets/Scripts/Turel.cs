using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turel : MonoBehaviour
{
    [SerializeField] GameObject Target;
    [SerializeField] Transform Gun;
    [SerializeField] GameObject _Bullet;
    [SerializeField] float TimeShoot = 2;
    [SerializeField] float Power = 800;

    bool detection;

    private void Start()
    {
        detection = false;
    }

    IEnumerator Shoot()
    {
        GameObject Bullet = Instantiate(_Bullet, Gun.transform.position, Quaternion.identity);
        
        Bullet.GetComponent<Rigidbody>().AddForce(transform.forward * Power);

        yield return new WaitForSeconds(TimeShoot);

        StartCoroutine(Shoot());
    }

    private void Update()
    {
        if (detection)
        { 
            var rotdirection = transform.position - Target.transform.position;

            var targetrotation = Quaternion.LookRotation(-rotdirection.normalized);

            transform.rotation = Quaternion.Lerp(transform.rotation , targetrotation , 20 * Time.deltaTime);
        
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            detection = true;

            StartCoroutine(Shoot());

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StopAllCoroutines();

            detection = false;

        }
    }
}
