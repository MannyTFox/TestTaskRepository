using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    Vector2 movement;
    [SerializeField] float speed;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = movement * speed;
    }
}
