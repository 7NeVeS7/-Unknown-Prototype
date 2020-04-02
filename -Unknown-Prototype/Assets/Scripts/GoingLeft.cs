using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingLeft : MonoBehaviour
{

    [SerializeField]
    private float _speed = 5f;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector2(-_speed, 0);
    }

}
