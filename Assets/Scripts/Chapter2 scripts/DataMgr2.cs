using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character2
{
    Hensel2, Gretel2
}

public class DataMgr2 : MonoBehaviour
{
    public static DataMgr2 instance;
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public Character2 currentCharacter;



}

