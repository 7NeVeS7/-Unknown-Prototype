using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;
    [SerializeField]
    private Rigidbody2D rb;
    private Vector2 _movement;
    private string _direction = "Vertical";
    private void Update()
    {
        _movement.y = Input.GetAxisRaw(_direction);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + _movement * _moveSpeed * Time.fixedDeltaTime);
    }
}
