using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingLeft : MonoBehaviour
{

    [SerializeField]
    private float _speed=0;
    [SerializeField]
    private Rigidbody2D _rb;
    private bool _alive;
    void Start()
    {
        _alive = true;
        ReceivingScoreAndHealthLoss.onScore += FastenTheCircle;
        _rb = this.GetComponent<Rigidbody2D>();
        FastenTheCircle();
    }
    public void FastenTheCircle()
    {
        if (_alive==true) 
        {
            Debug.Log(_speed);
            _speed += 5f;
            Debug.Log(_speed);
            _rb.velocity = new Vector2(-_speed, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log(hitInfo.name);
        if (hitInfo.tag == "Player" || hitInfo.tag == "Finish")
        {
            _alive = false;
            Destroy(this.gameObject);
        }

    }
}
