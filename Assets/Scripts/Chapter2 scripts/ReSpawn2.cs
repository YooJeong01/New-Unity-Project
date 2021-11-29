using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn2 : MonoBehaviour
{
    public GameObject[] charPrefabs;
    public GameObject player;

    void Start()
    {
        player = Instantiate(charPrefabs[(int)DataMgr2.instance.currentCharacter]);
        player.transform.position = transform.position;
    }
}

