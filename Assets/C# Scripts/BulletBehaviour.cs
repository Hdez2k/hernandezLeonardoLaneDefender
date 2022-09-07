using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed = 20;
    public Rigidbody2D rb;

    public GameObject Explosion;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Instantiate(Explosion, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
