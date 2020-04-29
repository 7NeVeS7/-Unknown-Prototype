using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject(typeof(T).ToString());
                go.AddComponent<T>();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this as T;
        Init();
    }
    public virtual void Init()
    {

    }
}
