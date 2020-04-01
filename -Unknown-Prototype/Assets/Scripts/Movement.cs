using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;
    [SerializeField]
    private Rigidbody2D _rb;
    private Vector2 _movement;
    private string _directionY = "Vertical";
   
    private void Update()
    {
        _movement.y = Input.GetAxisRaw(_directionY);
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * _moveSpeed * Time.fixedDeltaTime);
    }
}
