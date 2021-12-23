using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public GameObject[] charPrefabs;
    public GameObject player;

    void Start()
    {
        player = (charPrefabs[(int)DataMgr.instance.currentCharacter]);
        player = Instantiate(charPrefabs[(int)DataMgr.instance.currentCharacter]);
        player.transform.position = transform.position;

    }
}
