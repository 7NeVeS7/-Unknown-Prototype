using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log(hitInfo.name);
        if (hitInfo.tag == "Player" || hitInfo.tag == "Finish")
        {
            Destroy(gameObject);
        }

    }
}
