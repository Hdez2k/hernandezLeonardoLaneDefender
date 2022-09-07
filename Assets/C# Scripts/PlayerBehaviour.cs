using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public int lives;
    public float speed = 3;
    void Update()
    {
        float yMove = Input.GetAxis("Vertical");

        Vector3 newPos = transform.position;

        newPos.y += yMove * Time.deltaTime * speed;

        newPos.y = Mathf.Clamp(newPos.y, -3.86f, 1.28f);

        transform.position = newPos;
    }
}
