using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingletonSound : MonoBehaviour
{
    public static SingletonSound instance;

    //void Awake()
    //{
    //    if (instance == null)
    //    {
    //        DontDestroyOnLoad(this.gameObject);
    //        instance = this;
    //    }
    //    else if (instance != this)
    //    {
    //        DestroyImmediate(this.gameObject);
    //    }
    //}


    private void Awake()
    {   
        DontDestroyOnLoad(this);
    }
}
