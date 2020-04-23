using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite blueSprite, yellowSprite, redSprite;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        blueSprite = Resources.Load<Sprite>("Blue");
        yellowSprite = Resources.Load<Sprite>("Yellow");
        redSprite = Resources.Load<Sprite>("Red");
        //Debug.Log(rend.sprite);
       rend.sprite = blueSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
