using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float _moveHorizontal;
    private float _moveVertical;
    private Vector2 _movement;
    private Rigidbody2D _rb2D;
    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private Joystick _joystick;

    private void Start()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            _joystick.gameObject.SetActive(true);
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            Application.targetFrameRate = 60;
        }
    }
    void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _moveHorizontal = _joystick.Horizontal;
        _moveVertical = _joystick.Vertical;

        _movement = new Vector2(_moveHorizontal, _moveVertical);
        _movement = _movement.normalized;
        _rb2D.AddForce(_movement * _speed * Time.fixedDeltaTime,  ForceMode2D.Impulse);

    }



    //[SerializeField]
    //private float _moveSpeed = 5f;
    //[SerializeField]
    //private Rigidbody2D _rb;
    //private Vector2 _movement;
    //private string _directionY = "Vertical";

    //private void Update()
    //{
    //    _movement.y = Input.GetAxisRaw(_directionY);
    //}

    //private void FixedUpdate()
    //{
    //    _rb.MovePosition(_rb.position + _movement * _moveSpeed * Time.fixedDeltaTime);
    //}
}
