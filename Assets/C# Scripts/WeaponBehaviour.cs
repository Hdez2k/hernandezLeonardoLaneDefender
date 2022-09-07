using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;

    public GameObject Flash;

    public AudioClip explosion;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();

            Vector3 camPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(explosion,camPos);
        }
    }

    void Shoot()
    {
        Instantiate(Flash, transform.position, transform.rotation);

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
