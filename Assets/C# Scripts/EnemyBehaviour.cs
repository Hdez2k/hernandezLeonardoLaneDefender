using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int health = 2;

    public GameController controller;
    public float speed;

    public AudioClip enemyHit;
    public AudioClip loseLife;

    private void Start()
    {
        controller = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector3 camPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(loseLife, camPos);

            controller.lives--;
            controller.livesText.text = "Lives: " + controller.lives;

            Destroy(gameObject);

            controller.UpdateScore(-100);
        }
        else if(collision.gameObject.tag == "Barrier")
        {
            Vector3 camPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(loseLife, camPos);
            
            controller.LoseLife();

            Destroy(gameObject);

            controller.UpdateScore(-100);
        }
        else if(collision.gameObject.tag=="Bullet")
        {
            health--;

            Vector3 camPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(enemyHit, camPos);

            if(health<=0)
            {
                controller.UpdateScore(100);
                Destroy(gameObject);
            }
        }
    }
}
