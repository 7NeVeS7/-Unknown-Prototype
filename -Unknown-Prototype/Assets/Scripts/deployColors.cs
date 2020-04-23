using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployColors : MonoBehaviour
{
    [SerializeField]
    private GameObject _redPrefab;
    [SerializeField]
    private GameObject _bluePrefab;
    [SerializeField] 
    private GameObject _yellowPrefab;
    [SerializeField] 
    private float _spawnTime = 1f;
    private Vector2 _screenBounds;
    void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        StartCoroutine(ColorWave());
    }
    private void _SpawnColor()
    {
        GameObject a = Instantiate(_redPrefab) as GameObject;
        a.transform.position = new Vector2(_screenBounds.x * 2, UnityEngine.Random.Range(-_screenBounds.y, _screenBounds.y));
    }
    IEnumerator ColorWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnTime);

            _SpawnColor();
        }
    }

}
