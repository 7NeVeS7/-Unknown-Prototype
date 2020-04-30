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
        
        FastenTheCircle();
    }
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void FastenTheCircle() 
    {
        if (_alive==true) 
        {
            _speed += 5f;
            _rb.velocity = new Vector2(-_speed, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log(hitInfo.name);
        if (hitInfo.tag == "Player" || hitInfo.tag == "Finish")  //getcomponent
        {
            _alive = false;
            Destroy(this.gameObject);
        }

    }
}
