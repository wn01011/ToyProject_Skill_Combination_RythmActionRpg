using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                var instances = FindObjectsOfType(typeof(T));
                var count = instances.Length;

                if(count > 0)
                {
                    if(count == 1)
                    {
                        return _instance = (T)instances[0];
                    }
                    for(var i = 1; i < instances.Length; ++i)
                    {
                        Destroy(instances[i]);
                    }
                    return _instance = (T)instances[0];
                }
                else
                {
                    return _instance = new GameObject($"({nameof(_instance)}){typeof(T)}").AddComponent<T>();
                }
                
            }
            else
            {
                return _instance;
            }
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
