using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCube : MonoBehaviour
{
    private float _moveHorizontal;
    private float _moveVertical;
    private Vector3 _movement;
    private Rigidbody _rb;
    [SerializeField]
    private float _speed = 20f;
    [SerializeField]
    private Joystick _joystick;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _moveHorizontal = -_joystick.Horizontal;
        _moveVertical= -_joystick.Vertical;

        _movement = new Vector3(_moveHorizontal, 0, _moveVertical);
        _movement = _movement.normalized;
        _rb.AddForce(_movement * _speed * Time.fixedDeltaTime);

    }
}
