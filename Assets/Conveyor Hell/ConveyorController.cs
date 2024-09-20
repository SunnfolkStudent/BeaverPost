using System;
using UnityEngine;

public class ConveyorController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 10f;

    public Vector3 direction;

    private PlayerController player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Left"))
        {
            direction = new Vector2(-1,0);
        }

        if (other.CompareTag("Right"))
        {
            direction = new Vector2(1, 0);
        }

        if (other.CompareTag("Up"))
        {
            direction = new Vector2(0, 1);
        }

        if (other.CompareTag("Down"))
        {
            direction = new Vector2(0, -1);
        }

        if (other.CompareTag("Out"))
        {
            player.score -= scoreValue;
        }
    }
}
