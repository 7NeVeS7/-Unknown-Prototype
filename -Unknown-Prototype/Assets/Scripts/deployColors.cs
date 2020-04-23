using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class deployColors : MonoBehaviour
{
    [SerializeField]
    private GameObject _redPrefab;
    [SerializeField]
    private float _respawnTime = 1f;
    private Vector2 _screenBounds;
    void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        StartCoroutine(ColorWave());
    }
    private void _SpawnEnemy()
    {
        GameObject a = Instantiate(_redPrefab) as GameObject;
        a.transform.position = new Vector2(_screenBounds.x*2, UnityEngine.Random.Range(-_screenBounds.y, _screenBounds.y));
    }
    IEnumerator ColorWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(_respawnTime);
            _SpawnEnemy();
        }
    }

}
