using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    private Rigidbody2D rb;
    private float direction;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            gameObject.AddComponent<Rigidbody2D>();
        }
    }

    private void Update()
    {
        UpdatePosition();
        SetDirection(Input.GetAxisRaw("Horizontal"));
    }

    private void UpdatePosition()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = direction * speed;
        rb.velocity = velocity;
    }

    private void SetDirection(float direction)
    {
        this.direction = direction;
    }
}
