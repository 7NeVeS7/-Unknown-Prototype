using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0.05f;
    void Start()
    {

    }


    void Update()
    {
        moveCharacter();
    }

    void moveCharacter()
    {
        transform.Translate(new Vector2(_speed, 0) *Time.deltaTime);
    }

}
