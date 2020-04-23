using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployColors : MonoBehaviour
{
    [SerializeField]
    private GameObject _redPrefab;
    [SerializeField]
    private float _respawnTime = 1f;
    private Vector2 screenBounds;
    void Start()
    {
        
    }
    private void _SpawnEnemy()
    {
        GameObject a = Instantiate(_redPrefab) as GameObject;
        //a.transform.position = new Vector2(screenBounds.x*-2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    private void Update()
    {
         
    }

}
