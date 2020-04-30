using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployColors : MonoBehaviour
{ 
    [SerializeField] 
    private float _spawnTime = 1f;
    private Vector2 _screenBounds;
    [SerializeField]
    private GameObject[] _Color = new GameObject[3];
    private float _speed = 0;
    private float _horizontal = 15f;
    private float _vetrical = 4.3f;

    void Start()
    {
        _screenBounds = (new Vector2(_horizontal, _vetrical)); 
        StartCoroutine(ColorWave());
        //FastenTheCircle();
        Debug.Log(_screenBounds.y +  -_screenBounds.y);

    }
    private void _SpawnColor(int i)
    {
        //Debug.Log(i);
        GameObject a = Instantiate(_Color[i]) as GameObject;
        a.transform.position = new Vector2(_screenBounds.x * 2, Random.Range(-_screenBounds.y, _screenBounds.y));
    }
    IEnumerator ColorWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnTime);
            _SpawnColor(Random.Range(0, 3));
        }
    }
  
    
}
