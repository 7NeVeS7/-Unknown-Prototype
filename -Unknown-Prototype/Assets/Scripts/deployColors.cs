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
    void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        StartCoroutine(ColorWave());
    }
    private void _SpawnColor(int i)
    {
        Debug.Log(i);
        GameObject a = Instantiate(_Color[i]) as GameObject;
        a.transform.position = new Vector2(_screenBounds.x * 2, UnityEngine.Random.Range(-_screenBounds.y, _screenBounds.y));
    }
    IEnumerator ColorWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnTime);

            _SpawnColor(UnityEngine.Random.Range(0, 3));
        }
    }

}
