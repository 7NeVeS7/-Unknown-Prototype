using UnityEngine;
using System.Collections;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2D;
    private float _thrust = 10.0f;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
       // transform.position = new Vector2(2.0f, 0);
    }

    void FixedUpdate()
    {
        rb2D.AddForce(transform.right * _thrust, ForceMode2D.Force);
    }
}