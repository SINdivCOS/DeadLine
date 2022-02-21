using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestoryMusic : MonoBehaviour
{
    // Start is called before the first frame update
    private static DontDestoryMusic instance = null;
    public static DontDestoryMusic Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(transform.gameObject);
    }
}
